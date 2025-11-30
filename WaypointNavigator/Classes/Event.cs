using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaypointNavigator
{
    internal class Event
    {
        private const string DATABASE_FILE = "Events.sqlite";
        private static string CONNECTION_STRING = string.Format("Data Source={0};Version=3;", DATABASE_FILE);

        public int EventID;
        public string EventName;
        public string DateOfEvent;
        public string TimeOfEvent;
        public string SignupClose;

        public string EventCreator;

        public string EventClass;
        public string SignedUpUsers;

        public Event()
        {

        }


        public Event(string eventName, string eventCreator, List<string> eventClass, DateTime dateOfEvent, DateTime timeOfEvent, DateTime signupClose)
        {
            EventName = eventName;
            EventCreator = eventCreator;

            foreach (string Class in eventClass)
            {
                this.EventClass += Class + ", ";
            }

            EventClass = this.EventClass.TrimEnd(',', ' ');

            DateOfEvent = dateOfEvent.Date.ToString("dd-MM-yyyy");
            TimeOfEvent = timeOfEvent.ToString("HH:mm");
            SignupClose = signupClose.Date.ToString("dd-MM-yyyy");


            RegisterEvent();

        }

        public void LoadEvent(int ID)
        {

            this.EventID = ID;
            string query = string.Format("SELECT * FROM [EventDetails] WHERE [ID] = @id;");

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {

                dbConnection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@id", EventID);

                    Debug.WriteLine(command.CommandText);
                    using (var reader = command.ExecuteReader())
                    {



                        {
                            while (reader.Read())
                            {
                                Debug.Write("true");

                                this.EventName = reader.GetString(1);
                                this.DateOfEvent = reader.GetString(2);
                                this.TimeOfEvent = reader.GetString(3);
                                this.SignupClose = reader.GetString(4);
                                this.EventClass = reader.GetString(5);
                                this.EventCreator = reader.GetString(6);

                                if (!reader.IsDBNull(7))
                                    this.SignedUpUsers = reader.GetString(7);

                            }
                        }
                    }
                }
            }

            if (DateTime.Parse(DateOfEvent) < DateTime.Today)
            {
                DeleteEvent();
            }
        }
        private void RegisterEvent()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO [EventDetails] ([EventName], [EventStartDate], [EventStartTime], [EventSignupClose], " +
                    "[EventClasses], [EventAuthor]) VALUES (@eventname, @eventstartdate, @eventstarttime, @eventsignupclose, " +
                    "@eventclasses, @eventcreator);";
                insertCmd.Parameters.AddWithValue("eventname", this.EventName);
                insertCmd.Parameters.AddWithValue("eventstartdate", this.DateOfEvent);
                insertCmd.Parameters.AddWithValue("eventstarttime", this.TimeOfEvent);
                insertCmd.Parameters.AddWithValue("eventsignupclose", this.SignupClose);
                insertCmd.Parameters.AddWithValue("eventclasses", this.EventClass);
                insertCmd.Parameters.AddWithValue("eventcreator", this.EventCreator);
                insertCmd.ExecuteNonQuery();

                dbConnection.Close();
            }
        }

        public void DeleteEvent()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "DELETE FROM [EventDetails] WHERE [ID] = @id;";
                insertCmd.Parameters.AddWithValue("@id", this.EventID);

                insertCmd.ExecuteNonQuery();
                Debug.WriteLine(insertCmd.CommandText);
                dbConnection.Close();
            }


        }

        public void UserSignup(string User)
        {
            SignedUpUsers = SignedUpUsers + User + ", ";
            SignedUpUsers.TrimEnd(',', ' ');

            UpdateSignupList();

        }

        public void UserUnsignup(string User)
        {
            int startIndex = SignedUpUsers.IndexOf(User[0]); //returns the start index of the string
            int endIndex = startIndex + User.Length;
            if (endIndex <= SignedUpUsers.Length && startIndex != -1)
            {
                if (SignedUpUsers[endIndex] == ',')
                {
                    SignedUpUsers = SignedUpUsers.Remove(startIndex, User.Length + 2);
                    UpdateSignupList();
                }
                else
                {
                    SignedUpUsers = SignedUpUsers.Remove(startIndex, User.Length);
                    UpdateSignupList();
                }
            }
            else if (startIndex != -1)
            {
                SignedUpUsers = SignedUpUsers.Remove(startIndex, User.Length);
                UpdateSignupList();
            }

        }

        private void UpdateSignupList()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "UPDATE [EventDetails] SET [SignedupUsers] = @signup WHERE [ID] = @id;";
                insertCmd.Parameters.AddWithValue("@signup", this.SignedUpUsers);
                insertCmd.Parameters.AddWithValue("@id", this.EventID);
                insertCmd.ExecuteNonQuery();

                dbConnection.Close();
            }
        }

        public void UpdateEventDetails(string toUpdate, DateTime newEventDetail)
        {
            if (toUpdate == "StartDate")
            {
                this.DateOfEvent = newEventDetail.Date.ToString("dd-MM-yyyy");
            }
            else if (toUpdate == "SignupCloseDate")
            {
                this.SignupClose = newEventDetail.Date.ToString("dd-MM-yyyy");
            }
            else if (toUpdate == "EventTime")
            {
                this.TimeOfEvent = newEventDetail.ToString("HH:mm");
            }

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING)) //Insets data into SQLite table
            {
                dbConnection.Open();


                var insertCmd = dbConnection.CreateCommand();
                insertCmd.CommandText = "UPDATE [EventDetails] SET [EventStartDate] = @eventstartdate, [EventStartTime] = @eventstarttime, [EventSignupClose] = @signupclose WHERE [ID] = @id;";
                insertCmd.Parameters.AddWithValue("@eventstartdate", this.DateOfEvent);
                insertCmd.Parameters.AddWithValue("@eventstarttime", this.TimeOfEvent);
                insertCmd.Parameters.AddWithValue("@signupclose", this.SignupClose);
                insertCmd.Parameters.AddWithValue("@id", this.EventID);
                insertCmd.ExecuteNonQuery();

                dbConnection.Close();
            }



        }

    }
}


