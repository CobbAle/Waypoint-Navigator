using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WaypointNavigator
{
    public class User
    {
        //SQL File and connection details
        public const string DATABASE_FILE = "LoginFile.sqlite";
        public static string CONNECTION_STRING = string.Format("Data Source={0};Version=3;", DATABASE_FILE);

        //User Details
        protected int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string LastLogin { get; set; }
        public string AccessLevel { get; set; }
        public string RaceClasses { get; set; }

        public User()
        {

        }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }

        public void NameFromEmail(string email)
        {
            string Name = null;
            string query = (@"SELECT [FirstName] FROM [UserDetails] WHERE [EmailAddress] = @Email;");



            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                command.Parameters.AddWithValue("@Email", email);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Name = reader["FirstName"].ToString();

                    }
                }
                dbConnection.Close(); // Close the connection to the database
            }

            this.FirstName = Name;

        }
        public void RegisterUser()
        {
            this.Username = userNameGenerator();
            bool valid = false;

            valid = emailInUseChecker();


            if (valid == true)
            {

                //Need to add username verification Check if username is in use

                this.Password = hashPassword(); //Hashes Password


                using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
                {
                    dbConnection.Open();


                    var insertCmd = dbConnection.CreateCommand();
                    insertCmd.CommandText = "INSERT INTO [UserDetails] ([FirstName], [SecondName], [Username], [EmailAddress], [Password]) VALUES (@firstName, @lastName, @username, @emailAddress, @password)";
                    insertCmd.Parameters.AddWithValue("firstName", this.FirstName);
                    insertCmd.Parameters.AddWithValue("lastName", this.LastName);
                    insertCmd.Parameters.AddWithValue("username", this.Username);
                    insertCmd.Parameters.AddWithValue("emailAddress", this.Email);
                    insertCmd.Parameters.AddWithValue("password", this.Password);
                    insertCmd.ExecuteNonQuery();

                    dbConnection.Close();
                }
            }
        }

        public string hashPassword() // This subroutine takes the password and performs a hashing algorithm to make accessing passwords harder.
        {
            char startingChar;
            string hashedPassword = null;
            int previousChar;
            int asciiValue;
            int temp;

            startingChar = Password[1];

            previousChar = (int)startingChar; //Takes the first letter of the users name as an ASCII value to use as a starting character

            foreach (char c in this.Password) //Iterates through each character
            {
                asciiValue = (int)c; //Converts the current character c, into an ASCII value in order to perfom a bitwise operation.
                temp = previousChar ^ asciiValue; // Performs an XOR operation on the previousChar with the asciiValue for the current character 

                hashedPassword += (char)temp; //Turns the hashed ascii bit value into an ascii character
            }
            return hashedPassword;
        }

        private bool emailInUseChecker()
        {
            int emailFound;
            bool valid;

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "SELECT * FROM [UserDetails] WHERE [EmailAddress] = (@emailaddress)";//Used to return an integer value, if > 0 then the email is already in use
                insertCmd.Parameters.AddWithValue("emailaddress", this.Email); //Replaces @emailadress with the actual value

                emailFound = insertCmd.ExecuteNonQuery(); //Executes command

                dbConnection.Close();
            }

            if (emailFound != -1)
            {
                MessageBox.Show("This email is already in use!", "Waypoint Navigator Account Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }
            else valid = true;

            return valid;
        }

        private string userNameGenerator()
        {
            string generatedUsername;

            string currentYear = ((DateTime.Today.Year).ToString()).Substring(2); // Takes the last two digits of the year (e.g. 25)
            generatedUsername = currentYear + this.FirstName[0] + "." + this.LastName; //Generates username, YYF.Last

            return generatedUsername;
        }

        public bool checkLogin(string email, string password)
        {
            // Logic to be made... select password (hashed) from table, compare value to hashed password.
            string databaseEmail;
          
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "SELECT [Password] FROM [UserDetails] WHERE [EmailAddress] = (@email)";//Used to return an integer value, if > 0 then the username is already in use
                insertCmd.Parameters.AddWithValue("@email", email); //Replaces @email with the actual value


                using (var reader = insertCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        databaseEmail = reader.GetString(0);
                        if (databaseEmail == password)
                        {
                            return true;
                        }

                    }
                }
                dbConnection.Close();
            }

            return false;            
        }
    
         public void FillUserDetails()
        {
            
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                string databaseEmail;

                dbConnection.Open();
                

                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "SELECT * FROM [UserDetails] WHERE [EmailAddress] = (@email)";//Used to return an integer value, if > 0 then the username is already in use
                insertCmd.Parameters.AddWithValue("@email", this.Email); //Replaces @email with the actual value


                using (var reader = insertCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        databaseEmail = reader.GetString(4);
                        if (databaseEmail == this.Email)
                        {
                            this.ID = reader.GetInt32(0); 
                            this.FirstName = reader.GetString(1);
                            this.LastName = reader.GetString(2);
                            this.Username = reader.GetString(3);
                            this.Email = reader.GetString(4);
                            this.AccessLevel = reader.GetString(6);
                        
                        }
                    }
                }
                dbConnection.Close();
            }
        }
        

        public void FillUserDetails(int ID)
        {

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                int userID;

                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "SELECT * FROM [UserDetails] WHERE [ID] = (@id)";//Used to return an integer value, if > 0 then the username is already in use
                insertCmd.Parameters.AddWithValue("@id", ID); //Replaces @email with the actual value


                using (var reader = insertCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                        if ((userID) == ID)
                        {

                            this.FirstName = reader.GetString(1);
                            this.LastName = reader.GetString(2);
                            this.Username = reader.GetString(3);
                            this.Email = reader.GetString(4);
                           
                        }
                    }
                }
                dbConnection.Close();
            }
        }
    }
}


