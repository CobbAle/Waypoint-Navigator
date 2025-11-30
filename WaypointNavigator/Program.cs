using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WaypointNavigator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        public const string LoginFile = "LoginFile.sqlite";
        public static string ConnectionString_LoginFile = string.Format("Data Source={0};Version=3;", LoginFile);

        public const string Notices = "Notices.sqlite";
        public static string ConnectionString_Notices = string.Format("Data Source={0};Version=3", Notices);

        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            generateDatabase();
            generateNoticesDatabase();
            Application.Run(new LoginRegister());
        }



        static void generateDatabase()
        {
            //Only create the database if the file does not already exist
            if (!File.Exists(LoginFile))
            {
                SQLiteConnection.CreateFile(LoginFile);
            }


            //create table within the database (check if it exists is in the SQL query)
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(ConnectionString_LoginFile))
            {
            m_dbConnection.Open();
            string sql = @"CREATE TABLE IF NOT EXISTS [UserDetails] (
                        [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        [FirstName] TINYTEXT  NULL,
                        [SecondName] TINYTEXT  NULL,
                        [Username] TINYTEXT  NULL,
                        [EmailAddress] TINYTEXT NULL,
                        [Password] TINYTEXT  NULL,
                        [AccessLevel] TINYTEXT '1',
                        [TwoFactorAuth] TINYTEXT NULL,
                        [LastLogin] TIMESTAMP NULL
                        );"; //Generates a table with each row as a column in the table.

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        }

    


        static void generateNoticesDatabase()
        {
            //Only create the database if the file does not already exist
            if (!File.Exists(Notices))
            {
                SQLiteConnection.CreateFile(Notices);
            }


            //create table within the database (check if it exists is in the SQL query)
            using (SQLiteConnection m_dbConnection = new SQLiteConnection(ConnectionString_Notices))
            {
                m_dbConnection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS [Notices] (
                        [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        [NoticeText] TINYTEXT  NULL,
                        [ExpiryDate] TIMESTAMP  NULL,
                        [Author] TINYTEXT  NULL
                        );"; //Generates a table with each row as a column in the table.

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
            }
        }
        
        
        static string hashPassword(string password, string FirstName) // This subroutine takes the password and performs a hashing algorithm to make accessing passwords harder.
        {
            char startingChar;
            string hashedPassword = null;
            int previousChar;
            int asciiValue;
            int temp;

            startingChar = FirstName[1];

            previousChar = (int)startingChar; //Takes the first letter of the users name as an ASCII value to use as a starting character

            foreach (char c in password) //Iterates through each character
            {
                asciiValue = (int)c; //Converts the current character c, into an ASCII value in order to perfom a bitwise operation.
                temp = previousChar ^ asciiValue; // Performs an XOR operation on the previousChar with the asciiValue for the current character 

                hashedPassword = hashedPassword + (char)temp; //Turns the hashed ascii bit value into an ascii character
            }
            return hashedPassword;


        }
    }
}
