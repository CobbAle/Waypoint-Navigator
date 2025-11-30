using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace WaypointNavigator
{
    public class AdminUser : User
    {
        public List<string> foundUsers = new List<string>();
        private List<String> foundUsersEmails = new List<string>();
        public AdminUser()
        {

        }

        public void UserDetails(string userSearch)
        {

            userSearch = "" + userSearch + "%";
            string firstName, lastName, fullName, userEmail;
            string query = (@"SELECT * FROM [UserDetails] WHERE [FirstName] LIKE @search OR [SecondName] LIKE @search OR [UserName] LIKE @search;");


            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@search", userSearch);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);
                        userEmail = reader.GetString(4);
                        fullName = firstName + " " + lastName;
                        foundUsers.Add(fullName);
                        foundUsersEmails.Add(userEmail);
                    }
                }

            }
        }

        public void userLookup(int index)
        {

            if (index != -1)
            {
                Email = foundUsersEmails.ElementAt(index);
                FillUserDetails();
                Email = Email;
            }
        }

        public void clearUsers()
        {
            foundUsers.Clear();
            foundUsersEmails.Clear();

        }

        public void deleteUser(int index)
        {
            string query = (@"DELETE FROM [UserDetails] WHERE [EmailAddress] = @Email;");


            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@Email", Email);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();
                command.ExecuteNonQuery();
                dbConnection.Close();
            }

            foundUsers.RemoveAt(index);
            foundUsersEmails.RemoveAt(index);
        }

        public void updateUser()
        {
            string query = (@"UPDATE [UserDetails] SET [FirstName] = @FN, [SecondName] = @SN, [Username] = @UN, [EmailAddress] = @EA, [AccessLevel] = @AL WHERE [ID] = @id;");


            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@FN", this.FirstName);
                command.Parameters.AddWithValue("@SN",this.LastName);
                command.Parameters.AddWithValue("@UN", this.Username);
                command.Parameters.AddWithValue("@EA", this.Email);
                command.Parameters.AddWithValue("@AL", this.AccessLevel);
                command.Parameters.AddWithValue("@id", this.ID);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();
                command.ExecuteNonQuery();
                dbConnection.Close();
            }

        }
    }
}
