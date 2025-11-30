using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace WaypointNavigator
{

    public partial class frmMainApplication : Form
    {
        private int selectedCategory = 4;
        private User SelectedUser;

        private const string DATABASE_FILE = "Notices.sqlite";
        private static string CONNECTION_STRING = string.Format("Data Source={0};Version=3;Pooling=false;", DATABASE_FILE);

        private const string DATABASE_FILE_EVENTS = "Events.sqlite";
        private static string CONNECTION_STRING_EVENTS = string.Format("Data Source={0};Version=3;Pooling=false;", DATABASE_FILE_EVENTS);

        public int noticeID = 0; //Notice Counter
        private AdminUser listOfUsers = new AdminUser();

        private List<WayPoint> wayPoints = new List<WayPoint>();
        private List<WayPoint> closedWayPoints = new List<WayPoint>();
        private List<WayPoint> openWayPoints = new List<WayPoint>();

        private int selectedWaypointIndex = -1;
        private Image originalMapImage = null; // Store the original map image 
        private Image markersChart = null;
        private Image clearChart = null;

        public frmMainApplication()
        {
        }

        public frmMainApplication(User AccessedUser)
        {
            SelectedUser = AccessedUser;
            InitializeComponent();
            if (AccessedUser.AccessLevel == "3")
            {
                adminToolStripMenuItem.Visible = true;
                btnDeleteNotice.Visible = true;
            }
            routeplotterToolStripMenuItem.BackColor = Color.FromArgb(52, 152, 219);
            markersChart = new Bitmap("Map_Markers.png");
            clearChart = new Bitmap("Map_Clear.png");
        }

        private void NoticesToolStripMenuItem_Click_1(object sender, EventArgs e)  //Notice Page
        {
            if (selectedCategory != 1)
            {
                resetSelectedCatgeory(selectedCategory);
                NoticesToolStripMenuItem.BackColor = Color.FromArgb(52, 152, 219);
                pnlNoticePage.Visible = true;
                selectedCategory = 1;

                FillNoticeBox();
            }
        }

        private void btnNextNotice_Click(object sender, EventArgs e)
        {
            FillNoticeBox();
        }

        private void FillNoticeBox()
        {
            List<int> noticeIds = new List<int>();
            List<Notice> notices = new List<Notice>();

            noticeIds = getIDs();//returns a list of all the notice IDs
            if (noticeIds.Count > 0)
            {
                foreach (int noticeId in noticeIds)
                {
                    Notice temporaryNotice = new Notice(noticeId);
                    if (temporaryNotice.getMessage() != null)
                    {
                        notices.Add(temporaryNotice);

                    }
                }

                if (noticeID >= notices.Count)
                {
                    noticeID = 0;

                }

              
                    if (notices[noticeID].getMessage() != null)
                    {
                        rtbNoticesHome.Text = notices[noticeID].getMessage();
                        lblNoticesAuthor.Text = ("Message Author: " + notices[noticeID].getAuthor());
                        noticeID++;
                    }
               
            }
        }

        private List<int> getIDs() //Get IDs (for NoticePage)
        {
            List<int> noticeIDs = new List<int>();
            string query = (@"SELECT * FROM [Notices]");

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        noticeIDs.Add(reader.GetInt32(0));
                    }
                }

                dbConnection.Close(); // Close the connection to the database
            }

            return noticeIDs;
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            string NoticeToDelete = rtbNoticesHome.Text;
            string query = "DELETE FROM [Notices] WHERE [NoticeText] = @noticeToDelete;";

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);

                dbConnection.Open();
                var insertCmd = dbConnection.CreateCommand();
                command.Parameters.AddWithValue("@noticeToDelete", NoticeToDelete);
                Debug.WriteLine(command.CommandText);
                command.ExecuteNonQuery();

                dbConnection.Close(); // Close the connection to the database
            }

            rtbNoticesHome.Text = "";
            lblNoticesAuthor.Text = "Message Author: ";
        }



        private void resetSelectedCatgeory(int categoryToReset) //Everything
        {
            switch (categoryToReset)
            {
                case 0: //Home
                    break;
                case 1: //Notices
                    NoticesToolStripMenuItem.BackColor = Color.FromArgb(41, 128, 185);
                    pnlNoticePage.Visible = false;
                    break;
                case 2: //Events
                    EventsToolStripMenuItem.BackColor = Color.FromArgb(41, 128, 185);
                    pnlEvents.Visible = false;
                    break;
                case 3: //Calendar
                  
                    break;
                case 4: //RoutePlotter
                    routeplotterToolStripMenuItem.BackColor = Color.FromArgb(41, 128, 185);
                    pnlRoutePlotter.Visible = false;
                    break;
                case 5: //Friends
                    break;
                case 6: //Admin
                    adminToolStripMenuItem.BackColor = Color.FromArgb(41, 128, 185);
                    pnlAdmin.Hide();
                    break;
            }
        }

        private void EventsToolStripMenuItem_Click(object sender, EventArgs e) //Events Page
        {
            if (selectedCategory != 2)
            {
                resetSelectedCatgeory(selectedCategory);
                EventsToolStripMenuItem.BackColor = Color.FromArgb(52, 152, 219);
                pnlEvents.Visible = true;
                selectedCategory = 2;

                if (SelectedUser.AccessLevel == "3")
                {
                    btnAdminView.Visible = true;
                }

            }
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e) //Calendar Page
        {
            if (selectedCategory != 3)
            {
                
            }
        }

        private void routePlotterToolStripMenuItem_Click(object sender, EventArgs e) //Messages Page (TBC)
        {
            if (selectedCategory != 4)
            {
                resetSelectedCatgeory(selectedCategory);
                routeplotterToolStripMenuItem.BackColor = Color.FromArgb(52, 152, 219);
                selectedCategory = 4;

                pnlRoutePlotter.Visible = true;

                // Store the original map image if not already stored
                if (originalMapImage == null && pbxChart.Image != null)
                {
                    originalMapImage = new Bitmap(pbxChart.Image);
                }
            }
        }

        private void pbxChart_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Store original map image if not already stored
            if (originalMapImage == null && pbxChart.Image != null)
            {
                originalMapImage = new Bitmap(pbxChart.Image);
            }

            if (pbxChart.Image == null) return;

            // Convert click coordinates from PictureBox space to Image space
            // because SizeMode is StretchImage, the co-ordinates need to be scaled too.
            float scaleX = (float)pbxChart.Image.Width / pbxChart.ClientSize.Width;
            float scaleY = (float)pbxChart.Image.Height / pbxChart.ClientSize.Height;

            int imageX = (int)(e.X * scaleX);
            int imageY = (int)(e.Y * scaleY);

            WayPoint newWayPoint = new WayPoint(imageX, imageY);
            wayPoints.Add(newWayPoint);




            // Redraw all waypoints on a clean map
            RedrawAllWaypoints();
            RefreshWaypointsList();
        }

        private void RefreshWaypointsList()
        {
            lstWaypoints.Items.Clear();

            for (int i = 0; i < wayPoints.Count; i++)
            {
                lstWaypoints.Items.Add($"Waypoint {i + 1}: ({wayPoints[i].X}, {wayPoints[i].Y})");
            }
        }

        private void RedrawAllWaypoints()
        {
            if (originalMapImage != null)
            {
                // Create a fresh copy of the original map image
                Bitmap cleanMap = new Bitmap(originalMapImage);

                // Draw all waypoints on the clean map
                using (Graphics g = Graphics.FromImage(cleanMap))
                {
                    for (int i = 0; i < wayPoints.Count; i++)
                    {
                        bool isHighlighted = (i == selectedWaypointIndex);
                        wayPoints[i].Draw(g, isHighlighted);
                    }
                }

                if (wayPoints.Count > 1)
                {
                    for (int i = 0; i < wayPoints.Count; i++)
                    {

                        Graphics g = Graphics.FromImage(cleanMap);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        Color color = Color.Red;
                        using (Pen linePen = new Pen(color, 2))
                        {
                            if ((i + 1) < wayPoints.Count)
                                g.DrawLine(linePen, wayPoints[i].X, wayPoints[i].Y, wayPoints[i + 1].X, wayPoints[i + 1].Y);
                        }


                    }
                }

                pbxChart.Image = cleanMap;
                pbxChart.Refresh();
            }
        }


        private void lbxWaypoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedIndex >= 0 && lstWaypoints.SelectedIndex < wayPoints.Count)
            {
                selectedWaypointIndex = lstWaypoints.SelectedIndex;


                WayPoint selectedWaypoint = wayPoints[selectedWaypointIndex];
                string Colour = selectedWaypoint.PinColor.ToString();

                txtWaypointX.Text = selectedWaypoint.X.ToString();
                txtWaypointY.Text = selectedWaypoint.Y.ToString();
               
                RedrawAllWaypoints();
            }
            else
            {
                selectedWaypointIndex = -1;
                RedrawAllWaypoints();
            }
        }

        private void btnUpdateWaypoint_Click(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedIndex >= 0 && lstWaypoints.SelectedIndex < wayPoints.Count)
            {
                try
                {
                    int newX = int.Parse(txtWaypointX.Text);
                    int newY = int.Parse(txtWaypointY.Text);


                    wayPoints[lstWaypoints.SelectedIndex].X = newX;
                    wayPoints[lstWaypoints.SelectedIndex].Y = newY;

                    txtWaypointX.Text = "";
                    txtWaypointY.Text = "";

                    RedrawAllWaypoints();
                    RefreshWaypointsList();

                    MessageBox.Show("Waypoint updated successfully!", "Success");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid integer coordinates.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a waypoint to update.", "Error");
            }
        }

        private void btnDeleteWaypoint_Click(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedIndex >= 0 && lstWaypoints.SelectedIndex < wayPoints.Count)
            {
                wayPoints.RemoveAt(lstWaypoints.SelectedIndex);
                selectedWaypointIndex = -1;

                RedrawAllWaypoints();
                RefreshWaypointsList();

                txtWaypointX.Text = "";
                txtWaypointY.Text = "";

                MessageBox.Show("Waypoint deleted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Please select a waypoint to delete.", "Error");
            }
        }
        private void btnBestRoute_Click(object sender, EventArgs e)
        {
            if (wayPoints.Count > 0)
            {
                List<WayPoint> previousWaypoints = new List<WayPoint>();
                List<WayPoint> bestRoute = new List<WayPoint>();
                WayPoint currentWaypoint = wayPoints[0];
                WayPoint bestWaypoint;


                do
                {
                    previousWaypoints.Add(currentWaypoint);
                    bestRoute.Add(currentWaypoint);

                    bestWaypoint = bestRouteFinder(currentWaypoint, previousWaypoints);
                    currentWaypoint = bestWaypoint;


                } while (currentWaypoint != bestRoute[bestRoute.Count - 1]);

                foreach (WayPoint point in bestRoute)
                {
                    if (originalMapImage != null)
                    {
                        // Create a fresh copy of the original map image
                        Bitmap cleanMap = new Bitmap(originalMapImage);

                        // Draw all waypoints on the clean map
                        using (Graphics g = Graphics.FromImage(cleanMap))
                        {
                            for (int i = 0; i < bestRoute.Count; i++)
                            {
                                bool isHighlighted = (i == selectedWaypointIndex);
                                bestRoute[i].Draw(g, isHighlighted);
                            }
                        }

                        wayPoints = bestRoute;

                        if (bestRoute.Count > 1)
                        {
                            for (int i = 0; i < bestRoute.Count; i++)
                            {

                                Graphics g = Graphics.FromImage(cleanMap);
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                Color color = Color.Red;
                                using (Pen linePen = new Pen(color, 2))
                                {
                                    if ((i + 1) < bestRoute.Count)
                                        g.DrawLine(linePen, bestRoute[i].X, bestRoute[i].Y, bestRoute[i + 1].X, bestRoute[i + 1].Y);
                                }


                            }
                        }

                        pbxChart.Image = cleanMap;
                        pbxChart.Refresh();
                    }


                }


            }
        }

        public WayPoint bestRouteFinder(WayPoint CurrentWaypoint, List<WayPoint> PreviousWaypoints)
        {
            int distance, changeX, changeY, bestDistance;
            WayPoint bestOption = CurrentWaypoint;

            bestDistance = -1;

            foreach (WayPoint nextWaypoint in wayPoints)
            {
                if (!PreviousWaypoints.Contains(nextWaypoint))
                {
                    changeX = (nextWaypoint.X - CurrentWaypoint.X);
                    changeY = (nextWaypoint.Y - CurrentWaypoint.Y);
                    distance = (changeX * changeX) + (changeY * changeY);

                    if (distance < bestDistance || bestDistance == -1)
                    {
                        bestDistance = distance;
                        bestOption = nextWaypoint;
                    }
                }
            }

            return bestOption;
        }


        private void friendsToolStripMenuItem_Click(object sender, EventArgs e) //Friends Page (To be removed, keeping for logic)
        {


        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e) //Admin Page
        {
            if (selectedCategory != 6)
            {
                resetSelectedCatgeory(selectedCategory);
                adminToolStripMenuItem.BackColor = Color.FromArgb(52, 152, 219);
                selectedCategory = 6;
                pnlAdmin.Show();
            }
        }

        private void lbxSuggestedFreinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            User suggestedFriend = new User();
        }

        private void MainApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbxAdminSearch_TextChanged(object sender, EventArgs e)
        {
            lbxAdminUsers.Items.Clear();
            listOfUsers.clearUsers();
            string SearchText = tbxAdminSearch.Text;
            listOfUsers.UserDetails(SearchText);

            foreach (string U in listOfUsers.foundUsers)
            {
                lbxAdminUsers.Items.Add(U);
            }
        }

        private void lbxAdminUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdminDeleteUser.Show();
            btnAdminUpdate.Show();
            int index = lbxAdminUsers.SelectedIndex;
            listOfUsers.userLookup(index); //Looks up the user details of the selected user

            lblAdminDisplayUser.Text = listOfUsers.Username;
            lblAdminDisplayFirstName.Text = listOfUsers.FirstName;
            lblAdminDisplayLastName.Text = listOfUsers.LastName;
            lblAdminDisplayEmail.Text = listOfUsers.Email;

            switch (listOfUsers.AccessLevel)
            {
                case "1":
                    lblAdminDisplayAccess.Text = "User";
                    break;
                case "2":
                    lblAdminDisplayAccess.Text = "Organizer";
                    break;
                case "3":
                    lblAdminDisplayAccess.Text = "Administrator";
                    break;
            }
        }

        private void btnAdminDeleteUser_Click(object sender, EventArgs e)
        {
            int index = lbxAdminUsers.SelectedIndex;
            listOfUsers.deleteUser(index);
            lbxAdminUsers.Items.RemoveAt(index);

            ResetAdminPanel();
        }

        private void ResetAdminPanel()
        {
            lblAdminDisplayUser.Text = "-";
            lblAdminDisplayFirstName.Text = "-";
            lblAdminDisplayLastName.Text = "-";
            lblAdminDisplayEmail.Text = "-";
            lblAdminDisplayAccess.Text = "-";

            tbxAdminSearch.Text = "";
            btnAdminDeleteUser.Hide();

            btnAdminUpdate.Hide();
            pnlUpdateAdmin.Visible = false;
        }

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            tbxUsernameUpdate.Text = listOfUsers.Username;
            tbxFNUpdate.Text = listOfUsers.FirstName;
            tbxLNUpdate.Text = listOfUsers.LastName;
            tbxEmailUpdate.Text = listOfUsers.Email;
            cbxAccess.SelectedIndex = int.Parse(listOfUsers.AccessLevel) - 1;

            pnlUpdateAdmin.Visible = true;
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            listOfUsers.FirstName = tbxFNUpdate.Text;
            listOfUsers.LastName = tbxLNUpdate.Text;
            listOfUsers.Email = tbxEmailUpdate.Text;
            listOfUsers.Username = tbxUsernameUpdate.Text;
            listOfUsers.AccessLevel = (cbxAccess.SelectedIndex + 1).ToString();

            listOfUsers.updateUser();
            lbxAdminUsers.SelectedIndex = -1;
            lbxAdminUsers.Items.Clear();
            listOfUsers.clearUsers();

            ResetAdminPanel();
        }

        private void btnPostNotice_Click(object sender, EventArgs e)
        {
            string message;
            DateTime expireByDate;
            string author;

            if (dtpNotice.Value > DateTime.Now)
            {
                author = SelectedUser.FirstName + " " + SelectedUser.LastName;
                message = rtbNotices.Text;
                expireByDate = dtpNotice.Value;

                Notice newNotice = new Notice(message, expireByDate, author);
                MessageBox.Show("Notice Created Successfully", "Waypoint Navigator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Notice Creation Failed", "Waypoint Navigator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void pnlRoutePlotter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtMarkings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMarkings.Checked == true)
            {
                pbxChart.Image = markersChart;
                originalMapImage = pbxChart.Image;

            }



            RedrawAllWaypoints();

        }

        private void rbtClear_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtClear.Checked == true)
            {
                pbxChart.Image = clearChart;
                originalMapImage = pbxChart.Image;

                RedrawAllWaypoints();
            }
        }

        private void pbxChart_BackgroundImageChanged(object sender, EventArgs e)
        {
            RedrawAllWaypoints();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            bool validEvent = true;
            string eventName, eventCreator;
            List<string> eventClasses = new List<string>();
            DateTime dateOfEvent, timeOfEvent, signupCloseDate;

            if (tbxEventName.Text.Length == 0 || clbCreateEventClasses.SelectedItems.Count == 0
                || dtpCreateTimeOfEvent.Value > dtpSignupClose.Value)
            {
                validEvent = false;
                MessageBox.Show("Event Creation Failed, are all the details correct?", "Waypoint Navigator Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (validEvent)
            {

                eventName = tbxEventName.Text;
                eventCreator = SelectedUser.Username;

                //eventClasses Logic
                foreach (int eventClassIndex in clbCreateEventClasses.CheckedIndices)
                    eventClasses.Add(clbCreateEventClasses.Items[eventClassIndex].ToString());



                dateOfEvent = dtpDateOfEvent.Value;
                timeOfEvent = dtpCreateTimeOfEvent.Value;
                signupCloseDate = dtpSignupClose.Value;

                Event newEvent = new Event(eventName, eventCreator, eventClasses, dateOfEvent, timeOfEvent, signupCloseDate);
                MessageBox.Show("Event Created Successfully", "Waypoint Navigator", MessageBoxButtons.OK);
            }


            tbxEventName.Text = "";

            for (int i = 0; i < clbCreateEventClasses.Items.Count; i++)
            {
                clbCreateEventClasses.SetItemChecked(i, false);
            }


            clbCreateEventClasses.ClearSelected();
            dtpDateOfEvent.Value = DateTime.Now;
            dtpSignupClose.Value = DateTime.Now;
            dtpCreateTimeOfEvent.Value = DateTime.Now.Date;

        }




        private List<Event> events = new List<Event>();
        private int currentEventIndex;
        private void dtpSelectEvent_ValueChanged(object sender, EventArgs e)
        {
            ResetEventDetails();
            Debug.WriteLine("Test");
            events = GetEventIDs(dtpSelectEvent.Value.Date);
            currentEventIndex = 0;


            foreach (Event ev in events)
            {
                events[currentEventIndex].LoadEvent(ev.EventID);
                currentEventIndex++;
            }

            Debug.WriteLine(events.Count);

            if (events.Count > 0)
                LoadEventDetails(events[0]);





        }

        private List<Event> GetEventIDs(DateTime date)
        {
            List<Event> events = new List<Event>();

            string query = string.Format("SELECT * FROM [EventDetails] WHERE [EventStartDate] = @eventstartdate;");

            using (SQLiteConnection dbConnection = new SQLiteConnection(CONNECTION_STRING_EVENTS))
            {

                dbConnection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@eventstartdate", date.ToString("dd-MM-yyyy"));

                    Debug.WriteLine(command.CommandText);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event ev = new Event();
                            ev.EventID = int.Parse(reader["ID"].ToString());
                            Debug.WriteLine(ev.EventID + "<-- Event ID");
                            events.Add(ev);
                        }

                        Debug.WriteLine("Events.Length = " + events.Count);
                    }
                }
            }



            return events;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Restart(); //restarts the application allowing for users to log out of their account

        }

        private void btnNextEvent_Click(object sender, EventArgs e)
        {
            currentEventIndex++;
            if (currentEventIndex > events.Count - 1)
            {
                currentEventIndex = 0;
            }



            if (events.Count != 0)
                LoadEventDetails(events[currentEventIndex]);

        }

        private void LoadEventDetails(Event LoadedEvent)
        {
            Debug.WriteLine(LoadedEvent.EventID);
            Debug.WriteLine(currentEventIndex);
            lblSelectedEventName.Text = ("Event ID + Name: " + LoadedEvent.EventID + " | " + LoadedEvent.EventName);
            lblSelectedEventDate.Text = ("Event Date: " + LoadedEvent.DateOfEvent);
            lblSelectedEventTime.Text = ("Event Time: " + LoadedEvent.TimeOfEvent);
            lblSelectedEventAuthor.Text = ("Event Creator: " + LoadedEvent.EventCreator);
            lblSelectedEventClasses.Text = ("Racing Classes: " + LoadedEvent.EventClass);

            if (DateTime.Parse(LoadedEvent.SignupClose) < DateTime.Now)
            {
                lblSelectedEventSignups.Text = "Signups: Closed";
            }
            else
            {
                lblSelectedEventSignups.Text = "Signups: Open until " + LoadedEvent.SignupClose.TrimEnd('0', ':');
            }

            if (! (DateTime.Parse(LoadedEvent.SignupClose) > DateTime.Now))
            {
                btnSingupsClosed.Visible = true;
            }
            else if (LoadedEvent.SignedUpUsers == null ||
                !LoadedEvent.SignedUpUsers.Contains(SelectedUser.Username))
            { 
                btnSingupsClosed.Visible = false;
                btnJoinEvent.Visible = true;
                btnLeaveEvent.Visible = false;
            }
            else
            {
                btnSingupsClosed.Visible = false;
                btnJoinEvent.Visible = false;
                btnLeaveEvent.Visible = true;
            }


        }

        private void btnPreviousEvent_Click(object sender, EventArgs e)
        {
            currentEventIndex--;
            if (currentEventIndex < 0)
            {
                currentEventIndex = (events.Count - 1);
            }

            if (events.Count != 0)
                LoadEventDetails(events[currentEventIndex]);


        }

        private void ResetEventDetails()
        {
            lblSelectedEventName.Text = ("Event ID + Name: ");
            lblSelectedEventDate.Text = ("Event Date: ");
            lblSelectedEventTime.Text = ("Event Time: ");
            lblSelectedEventAuthor.Text = ("Event Creator: ");
            lblSelectedEventClasses.Text = ("Racing Classes: ");
            lblSelectedEventSignups.Text = "Signups: ";
            
         
        }

        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];

            LoadedEvent.UserSignup(SelectedUser.Username);

            btnJoinEvent.Visible = false;
            btnLeaveEvent.Visible = true;
        }

        private void btnLeaveEvent_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.UserUnsignup(SelectedUser.Username);

            btnJoinEvent.Visible  = true;
            btnLeaveEvent.Visible = false;
            
             
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            pnlEventAdminView.Visible = true; 
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.DeleteEvent();

        }

        private void btnChangeCloseDate_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.UpdateEventDetails("SignupCloseDate", dtpChangeEventDetails.Value);
        }

        private bool SQLInjectionDetector(string text)
        {
            if (text.Contains(';'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnChangeEventDate_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.UpdateEventDetails("StartDate", dtpChangeEventDetails.Value);
        }

        private void btnChangeEventTime_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.UpdateEventDetails("EventTime", dtpChangeEventDetails.Value);
        }

        private void btnCloseSignup_Click(object sender, EventArgs e)
        {
            Event LoadedEvent = events[currentEventIndex - 1];
            LoadedEvent.UpdateEventDetails("SignupCloseDate", DateTime.Today);
        }
    }
}

