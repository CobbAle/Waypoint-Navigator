using System;
using System.Data.SQLite;

namespace WaypointNavigator
{
    internal class Notice
    {
        private string noticeMessage;
        private DateTime expiryDate;
        private string author;
        private int ID;
        private const string DATABASE_FILE = "Notices.sqlite";
        private static string CONNECTION_STRING = string.Format("Data Source={0};Version=3;", DATABASE_FILE);

        public Notice(int LoadedID) 
        {
            //Code to load notice based on ID. Should link to a list, check expiry date, if expired delete.
            ID = LoadedID;
            loadNotice();
            
            if (expiryDate < DateTime.UtcNow)
            DeleteExpiredNotice();
        }

        

        private void loadNotice()
        {
            string query = (@"SELECT * FROM [Notices] WHERE [ID] = @id;");



            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@id", ID);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        noticeMessage = reader.GetString(1);
                        expiryDate = reader.GetDateTime(2);
                        author = reader.GetString(3);
                    }
                }

          
                dbConnection.Close(); // Close the connection to the database
            }
        }

        public string getMessage()
        {
            return noticeMessage;
        }

        public string getAuthor()
        {
            return author;
        }

        public DateTime getDate()
        {
            return expiryDate;
        }

        private void DeleteExpiredNotice()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "DELETE FROM [Notices] WHERE [ID] = @id;";
                insertCmd.Parameters.AddWithValue("@id", ID);
                insertCmd.ExecuteNonQuery();

                dbConnection.Close();
            }

            ID = -1;
            noticeMessage = null;
        }
        

        public Notice(string message, DateTime date, string Author ) 
        {
            noticeMessage = message;
            expiryDate = date;
            author = Author;

            uploadNotice();
        }

        private void uploadNotice()
        {


            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO [Notices] ([NoticeText], [ExpiryDate], [Author]) VALUES (@text, @date, @postAuthor)";
                insertCmd.Parameters.AddWithValue("text", this.noticeMessage);
                insertCmd.Parameters.AddWithValue("date", this.expiryDate);
                insertCmd.Parameters.AddWithValue("postAuthor", this.author);
                insertCmd.ExecuteNonQuery();

                dbConnection.Close();
            }
        }
    }
}
