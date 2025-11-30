namespace WaypointNavigator
{
    partial class frmMainApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApplication));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.routeplotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoticesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblCreateTimeOfEvent = new System.Windows.Forms.Label();
            this.dtpCreateTimeOfEvent = new System.Windows.Forms.DateTimePicker();
            this.clbCreateEventClasses = new System.Windows.Forms.CheckedListBox();
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.lblCreateEventClasses = new System.Windows.Forms.Label();
            this.lblCreateEventName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSignupClose = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfEvent = new System.Windows.Forms.Label();
            this.dtpDateOfEvent = new System.Windows.Forms.DateTimePicker();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.lblEventCreation = new System.Windows.Forms.Label();
            this.lblNoticeDate = new System.Windows.Forms.Label();
            this.dtpNotice = new System.Windows.Forms.DateTimePicker();
            this.btnPostNotice = new System.Windows.Forms.Button();
            this.lblNotice = new System.Windows.Forms.Label();
            this.rtbNotices = new System.Windows.Forms.RichTextBox();
            this.pnlUpdateAdmin = new System.Windows.Forms.Panel();
            this.btnUpdateConfirm = new System.Windows.Forms.Button();
            this.cbxAccess = new System.Windows.Forms.ComboBox();
            this.tbxEmailUpdate = new System.Windows.Forms.TextBox();
            this.tbxLNUpdate = new System.Windows.Forms.TextBox();
            this.tbxFNUpdate = new System.Windows.Forms.TextBox();
            this.tbxUsernameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateAccess = new System.Windows.Forms.Label();
            this.pnlUpdateUsername = new System.Windows.Forms.Label();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdateFN = new System.Windows.Forms.Label();
            this.lblUpdateLN = new System.Windows.Forms.Label();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            this.btnAdminDeleteUser = new System.Windows.Forms.Button();
            this.lblAdminDisplayAccess = new System.Windows.Forms.Label();
            this.lblAdminDisplayEmail = new System.Windows.Forms.Label();
            this.lblAdminDisplayLastName = new System.Windows.Forms.Label();
            this.lblAdminDisplayFirstName = new System.Windows.Forms.Label();
            this.lblAdminDisplayUser = new System.Windows.Forms.Label();
            this.lblAdminAccessLevel = new System.Windows.Forms.Label();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminLastName = new System.Windows.Forms.Label();
            this.lblAdminFirstName = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.lbxAdminUsers = new System.Windows.Forms.ListBox();
            this.tbxAdminSearch = new System.Windows.Forms.TextBox();
            this.pnlRoutePlotter = new System.Windows.Forms.Panel();
            this.btnFindBestRoute = new System.Windows.Forms.Button();
            this.rbtMarkings = new System.Windows.Forms.RadioButton();
            this.rbtClear = new System.Windows.Forms.RadioButton();
            this.lblChartType = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteWaypoint = new System.Windows.Forms.Button();
            this.btnUpdateWaypoint = new System.Windows.Forms.Button();
            this.txtWaypointY = new System.Windows.Forms.TextBox();
            this.txtWaypointX = new System.Windows.Forms.TextBox();
            this.lblWaypointY = new System.Windows.Forms.Label();
            this.lblWaypointX = new System.Windows.Forms.Label();
            this.lstWaypoints = new System.Windows.Forms.ListBox();
            this.lblWaypoints = new System.Windows.Forms.Label();
            this.pbxChart = new System.Windows.Forms.PictureBox();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.pnlEventAdminView = new System.Windows.Forms.Panel();
            this.dtpChangeEventDetails = new System.Windows.Forms.DateTimePicker();
            this.btnChangeEventTime = new System.Windows.Forms.Button();
            this.btnChangeEventDate = new System.Windows.Forms.Button();
            this.btnChangeCloseDate = new System.Windows.Forms.Button();
            this.btnCloseSignup = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.dtpSelectEvent = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSingupsClosed = new System.Windows.Forms.Button();
            this.btnNextEvent = new System.Windows.Forms.Button();
            this.btnPreviousEvent = new System.Windows.Forms.Button();
            this.btnAdminView = new System.Windows.Forms.Button();
            this.btnLeaveEvent = new System.Windows.Forms.Button();
            this.btnJoinEvent = new System.Windows.Forms.Button();
            this.lblSelectedEventTime = new System.Windows.Forms.Label();
            this.lblSelectedEventDate = new System.Windows.Forms.Label();
            this.lblSelectedEventAuthor = new System.Windows.Forms.Label();
            this.lblSelectedEventClasses = new System.Windows.Forms.Label();
            this.lblSelectedEventSignups = new System.Windows.Forms.Label();
            this.lblSelectedEventName = new System.Windows.Forms.Label();
            this.rtbNoticesHome = new System.Windows.Forms.RichTextBox();
            this.lblNoticesAuthor = new System.Windows.Forms.Label();
            this.btnNextNotice = new System.Windows.Forms.Button();
            this.btnDeleteNotice = new System.Windows.Forms.Button();
            this.pnlNoticePage = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlUpdateAdmin.SuspendLayout();
            this.pnlRoutePlotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChart)).BeginInit();
            this.pnlEvents.SuspendLayout();
            this.pnlEventAdminView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNoticePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeplotterToolStripMenuItem,
            this.NoticesToolStripMenuItem,
            this.EventsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1593, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // routeplotterToolStripMenuItem
            // 
            this.routeplotterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.routeplotterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.routeplotterToolStripMenuItem.Name = "routeplotterToolStripMenuItem";
            this.routeplotterToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.routeplotterToolStripMenuItem.Size = new System.Drawing.Size(187, 40);
            this.routeplotterToolStripMenuItem.Text = "🗺 Route Plotter";
            this.routeplotterToolStripMenuItem.Click += new System.EventHandler(this.routePlotterToolStripMenuItem_Click);
            // 
            // NoticesToolStripMenuItem
            // 
            this.NoticesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NoticesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.NoticesToolStripMenuItem.Name = "NoticesToolStripMenuItem";
            this.NoticesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.NoticesToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.NoticesToolStripMenuItem.Text = "📋 Notices";
            this.NoticesToolStripMenuItem.Click += new System.EventHandler(this.NoticesToolStripMenuItem_Click_1);
            // 
            // EventsToolStripMenuItem
            // 
            this.EventsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EventsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem";
            this.EventsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.EventsToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.EventsToolStripMenuItem.Text = "📅 Events";
            this.EventsToolStripMenuItem.Click += new System.EventHandler(this.EventsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(130, 40);
            this.adminToolStripMenuItem.Text = "⚙ Admin";
            this.adminToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(130, 40);
            this.logOutToolStripMenuItem.Text = "➜] Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.lblCreateTimeOfEvent);
            this.pnlAdmin.Controls.Add(this.dtpCreateTimeOfEvent);
            this.pnlAdmin.Controls.Add(this.clbCreateEventClasses);
            this.pnlAdmin.Controls.Add(this.tbxEventName);
            this.pnlAdmin.Controls.Add(this.lblCreateEventClasses);
            this.pnlAdmin.Controls.Add(this.lblCreateEventName);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.dtpSignupClose);
            this.pnlAdmin.Controls.Add(this.lblDateOfEvent);
            this.pnlAdmin.Controls.Add(this.dtpDateOfEvent);
            this.pnlAdmin.Controls.Add(this.btnCreateEvent);
            this.pnlAdmin.Controls.Add(this.lblEventCreation);
            this.pnlAdmin.Controls.Add(this.lblNoticeDate);
            this.pnlAdmin.Controls.Add(this.dtpNotice);
            this.pnlAdmin.Controls.Add(this.btnPostNotice);
            this.pnlAdmin.Controls.Add(this.lblNotice);
            this.pnlAdmin.Controls.Add(this.rtbNotices);
            this.pnlAdmin.Controls.Add(this.pnlUpdateAdmin);
            this.pnlAdmin.Controls.Add(this.btnAdminUpdate);
            this.pnlAdmin.Controls.Add(this.btnAdminDeleteUser);
            this.pnlAdmin.Controls.Add(this.lblAdminDisplayAccess);
            this.pnlAdmin.Controls.Add(this.lblAdminDisplayEmail);
            this.pnlAdmin.Controls.Add(this.lblAdminDisplayLastName);
            this.pnlAdmin.Controls.Add(this.lblAdminDisplayFirstName);
            this.pnlAdmin.Controls.Add(this.lblAdminDisplayUser);
            this.pnlAdmin.Controls.Add(this.lblAdminAccessLevel);
            this.pnlAdmin.Controls.Add(this.lblAdminEmail);
            this.pnlAdmin.Controls.Add(this.lblAdminLastName);
            this.pnlAdmin.Controls.Add(this.lblAdminFirstName);
            this.pnlAdmin.Controls.Add(this.lblAdminUsername);
            this.pnlAdmin.Controls.Add(this.lbxAdminUsers);
            this.pnlAdmin.Controls.Add(this.tbxAdminSearch);
            this.pnlAdmin.Location = new System.Drawing.Point(12, 47);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1235, 602);
            this.pnlAdmin.TabIndex = 12;
            this.pnlAdmin.Visible = false;
            // 
            // lblCreateTimeOfEvent
            // 
            this.lblCreateTimeOfEvent.AutoSize = true;
            this.lblCreateTimeOfEvent.Location = new System.Drawing.Point(-2, 112);
            this.lblCreateTimeOfEvent.Name = "lblCreateTimeOfEvent";
            this.lblCreateTimeOfEvent.Size = new System.Drawing.Size(124, 25);
            this.lblCreateTimeOfEvent.TabIndex = 32;
            this.lblCreateTimeOfEvent.Text = "Time of event:";
            // 
            // dtpCreateTimeOfEvent
            // 
            this.dtpCreateTimeOfEvent.CustomFormat = "hh:mm";
            this.dtpCreateTimeOfEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCreateTimeOfEvent.Location = new System.Drawing.Point(3, 142);
            this.dtpCreateTimeOfEvent.Name = "dtpCreateTimeOfEvent";
            this.dtpCreateTimeOfEvent.Size = new System.Drawing.Size(276, 31);
            this.dtpCreateTimeOfEvent.TabIndex = 31;
            this.dtpCreateTimeOfEvent.Value = new System.DateTime(2025, 11, 25, 0, 0, 0, 0);
            // 
            // clbCreateEventClasses
            // 
            this.clbCreateEventClasses.CheckOnClick = true;
            this.clbCreateEventClasses.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbCreateEventClasses.FormattingEnabled = true;
            this.clbCreateEventClasses.Items.AddRange(new object[] {
            "ICLA 7 ",
            "Optimist",
            "Topper",
            "RS Aero",
            "470",
            "Safety Boat",
            "Other"});
            this.clbCreateEventClasses.Location = new System.Drawing.Point(333, 35);
            this.clbCreateEventClasses.Name = "clbCreateEventClasses";
            this.clbCreateEventClasses.Size = new System.Drawing.Size(162, 200);
            this.clbCreateEventClasses.TabIndex = 30;
            // 
            // tbxEventName
            // 
            this.tbxEventName.Location = new System.Drawing.Point(120, 26);
            this.tbxEventName.Name = "tbxEventName";
            this.tbxEventName.Size = new System.Drawing.Size(159, 31);
            this.tbxEventName.TabIndex = 29;
            // 
            // lblCreateEventClasses
            // 
            this.lblCreateEventClasses.AutoSize = true;
            this.lblCreateEventClasses.Location = new System.Drawing.Point(328, 4);
            this.lblCreateEventClasses.Name = "lblCreateEventClasses";
            this.lblCreateEventClasses.Size = new System.Drawing.Size(167, 25);
            this.lblCreateEventClasses.TabIndex = 28;
            this.lblCreateEventClasses.Text = "Competing Classes:";
            // 
            // lblCreateEventName
            // 
            this.lblCreateEventName.AutoSize = true;
            this.lblCreateEventName.Location = new System.Drawing.Point(3, 29);
            this.lblCreateEventName.Name = "lblCreateEventName";
            this.lblCreateEventName.Size = new System.Drawing.Size(111, 25);
            this.lblCreateEventName.TabIndex = 27;
            this.lblCreateEventName.Text = "Event Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Signup Close Date";
            // 
            // dtpSignupClose
            // 
            this.dtpSignupClose.CustomFormat = "dd/MM/yyyy";
            this.dtpSignupClose.Location = new System.Drawing.Point(3, 79);
            this.dtpSignupClose.Name = "dtpSignupClose";
            this.dtpSignupClose.Size = new System.Drawing.Size(276, 31);
            this.dtpSignupClose.TabIndex = 25;
            this.dtpSignupClose.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // lblDateOfEvent
            // 
            this.lblDateOfEvent.AutoSize = true;
            this.lblDateOfEvent.Location = new System.Drawing.Point(3, 173);
            this.lblDateOfEvent.Name = "lblDateOfEvent";
            this.lblDateOfEvent.Size = new System.Drawing.Size(123, 25);
            this.lblDateOfEvent.TabIndex = 24;
            this.lblDateOfEvent.Text = "Date of event:";
            // 
            // dtpDateOfEvent
            // 
            this.dtpDateOfEvent.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfEvent.Location = new System.Drawing.Point(4, 201);
            this.dtpDateOfEvent.Name = "dtpDateOfEvent";
            this.dtpDateOfEvent.Size = new System.Drawing.Size(276, 31);
            this.dtpDateOfEvent.TabIndex = 23;
            this.dtpDateOfEvent.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.Location = new System.Drawing.Point(3, 236);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(161, 42);
            this.btnCreateEvent.TabIndex = 22;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lblEventCreation
            // 
            this.lblEventCreation.AutoSize = true;
            this.lblEventCreation.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCreation.Location = new System.Drawing.Point(-1, 4);
            this.lblEventCreation.Name = "lblEventCreation";
            this.lblEventCreation.Size = new System.Drawing.Size(75, 22);
            this.lblEventCreation.TabIndex = 21;
            this.lblEventCreation.Text = "Event:";
            // 
            // lblNoticeDate
            // 
            this.lblNoticeDate.AutoSize = true;
            this.lblNoticeDate.Location = new System.Drawing.Point(5, 495);
            this.lblNoticeDate.Name = "lblNoticeDate";
            this.lblNoticeDate.Size = new System.Drawing.Size(127, 25);
            this.lblNoticeDate.TabIndex = 19;
            this.lblNoticeDate.Text = "Date to Expire:";
            // 
            // dtpNotice
            // 
            this.dtpNotice.Location = new System.Drawing.Point(9, 523);
            this.dtpNotice.Name = "dtpNotice";
            this.dtpNotice.Size = new System.Drawing.Size(276, 31);
            this.dtpNotice.TabIndex = 18;
            this.dtpNotice.Value = new System.DateTime(2025, 11, 26, 0, 0, 0, 0);
            // 
            // btnPostNotice
            // 
            this.btnPostNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPostNotice.FlatAppearance.BorderSize = 0;
            this.btnPostNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPostNotice.ForeColor = System.Drawing.Color.White;
            this.btnPostNotice.Location = new System.Drawing.Point(10, 560);
            this.btnPostNotice.Name = "btnPostNotice";
            this.btnPostNotice.Size = new System.Drawing.Size(161, 42);
            this.btnPostNotice.TabIndex = 17;
            this.btnPostNotice.Text = "Post Notice";
            this.btnPostNotice.UseVisualStyleBackColor = false;
            this.btnPostNotice.Click += new System.EventHandler(this.btnPostNotice_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(0, 278);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(87, 22);
            this.lblNotice.TabIndex = 16;
            this.lblNotice.Text = "Notice:";
            // 
            // rtbNotices
            // 
            this.rtbNotices.AcceptsTab = true;
            this.rtbNotices.Location = new System.Drawing.Point(3, 303);
            this.rtbNotices.MaxLength = 700;
            this.rtbNotices.Name = "rtbNotices";
            this.rtbNotices.Size = new System.Drawing.Size(478, 189);
            this.rtbNotices.TabIndex = 15;
            this.rtbNotices.Text = "";
            // 
            // pnlUpdateAdmin
            // 
            this.pnlUpdateAdmin.Controls.Add(this.btnUpdateConfirm);
            this.pnlUpdateAdmin.Controls.Add(this.cbxAccess);
            this.pnlUpdateAdmin.Controls.Add(this.tbxEmailUpdate);
            this.pnlUpdateAdmin.Controls.Add(this.tbxLNUpdate);
            this.pnlUpdateAdmin.Controls.Add(this.tbxFNUpdate);
            this.pnlUpdateAdmin.Controls.Add(this.tbxUsernameUpdate);
            this.pnlUpdateAdmin.Controls.Add(this.lblUpdateAccess);
            this.pnlUpdateAdmin.Controls.Add(this.pnlUpdateUsername);
            this.pnlUpdateAdmin.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateAdmin.Controls.Add(this.lblUpdateFN);
            this.pnlUpdateAdmin.Controls.Add(this.lblUpdateLN);
            this.pnlUpdateAdmin.Location = new System.Drawing.Point(933, 210);
            this.pnlUpdateAdmin.Name = "pnlUpdateAdmin";
            this.pnlUpdateAdmin.Size = new System.Drawing.Size(299, 225);
            this.pnlUpdateAdmin.TabIndex = 14;
            this.pnlUpdateAdmin.Visible = false;
            // 
            // btnUpdateConfirm
            // 
            this.btnUpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUpdateConfirm.FlatAppearance.BorderSize = 0;
            this.btnUpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateConfirm.ForeColor = System.Drawing.Color.White;
            this.btnUpdateConfirm.Location = new System.Drawing.Point(7, 163);
            this.btnUpdateConfirm.Name = "btnUpdateConfirm";
            this.btnUpdateConfirm.Size = new System.Drawing.Size(280, 48);
            this.btnUpdateConfirm.TabIndex = 24;
            this.btnUpdateConfirm.Text = "Update";
            this.btnUpdateConfirm.UseVisualStyleBackColor = false;
            this.btnUpdateConfirm.Click += new System.EventHandler(this.btnUpdateConfirm_Click);
            // 
            // cbxAccess
            // 
            this.cbxAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccess.FormattingEnabled = true;
            this.cbxAccess.Items.AddRange(new object[] {
            "User",
            "Organiser",
            "Administrator"});
            this.cbxAccess.Location = new System.Drawing.Point(112, 120);
            this.cbxAccess.Name = "cbxAccess";
            this.cbxAccess.Size = new System.Drawing.Size(178, 33);
            this.cbxAccess.TabIndex = 15;
            // 
            // tbxEmailUpdate
            // 
            this.tbxEmailUpdate.Location = new System.Drawing.Point(112, 89);
            this.tbxEmailUpdate.Name = "tbxEmailUpdate";
            this.tbxEmailUpdate.Size = new System.Drawing.Size(178, 31);
            this.tbxEmailUpdate.TabIndex = 23;
            // 
            // tbxLNUpdate
            // 
            this.tbxLNUpdate.Location = new System.Drawing.Point(112, 58);
            this.tbxLNUpdate.Name = "tbxLNUpdate";
            this.tbxLNUpdate.Size = new System.Drawing.Size(178, 31);
            this.tbxLNUpdate.TabIndex = 22;
            // 
            // tbxFNUpdate
            // 
            this.tbxFNUpdate.Location = new System.Drawing.Point(112, 32);
            this.tbxFNUpdate.Name = "tbxFNUpdate";
            this.tbxFNUpdate.Size = new System.Drawing.Size(178, 31);
            this.tbxFNUpdate.TabIndex = 21;
            // 
            // tbxUsernameUpdate
            // 
            this.tbxUsernameUpdate.Location = new System.Drawing.Point(112, 5);
            this.tbxUsernameUpdate.Name = "tbxUsernameUpdate";
            this.tbxUsernameUpdate.Size = new System.Drawing.Size(178, 31);
            this.tbxUsernameUpdate.TabIndex = 20;
            // 
            // lblUpdateAccess
            // 
            this.lblUpdateAccess.AutoSize = true;
            this.lblUpdateAccess.Location = new System.Drawing.Point(3, 120);
            this.lblUpdateAccess.Name = "lblUpdateAccess";
            this.lblUpdateAccess.Size = new System.Drawing.Size(113, 25);
            this.lblUpdateAccess.TabIndex = 19;
            this.lblUpdateAccess.Text = "Access Level:";
            // 
            // pnlUpdateUsername
            // 
            this.pnlUpdateUsername.AutoSize = true;
            this.pnlUpdateUsername.Location = new System.Drawing.Point(3, 8);
            this.pnlUpdateUsername.Name = "pnlUpdateUsername";
            this.pnlUpdateUsername.Size = new System.Drawing.Size(95, 25);
            this.pnlUpdateUsername.TabIndex = 15;
            this.pnlUpdateUsername.Text = "Username:";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(3, 93);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(58, 25);
            this.lblUpdateEmail.TabIndex = 18;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // lblUpdateFN
            // 
            this.lblUpdateFN.AutoSize = true;
            this.lblUpdateFN.Location = new System.Drawing.Point(3, 35);
            this.lblUpdateFN.Name = "lblUpdateFN";
            this.lblUpdateFN.Size = new System.Drawing.Size(101, 25);
            this.lblUpdateFN.TabIndex = 16;
            this.lblUpdateFN.Text = "First Name:";
            // 
            // lblUpdateLN
            // 
            this.lblUpdateLN.AutoSize = true;
            this.lblUpdateLN.Location = new System.Drawing.Point(3, 61);
            this.lblUpdateLN.Name = "lblUpdateLN";
            this.lblUpdateLN.Size = new System.Drawing.Size(99, 25);
            this.lblUpdateLN.TabIndex = 17;
            this.lblUpdateLN.Text = "Last Name:";
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdminUpdate.FlatAppearance.BorderSize = 0;
            this.btnAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAdminUpdate.Location = new System.Drawing.Point(678, 244);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(233, 34);
            this.btnAdminUpdate.TabIndex = 13;
            this.btnAdminUpdate.Text = "Update User";
            this.btnAdminUpdate.UseVisualStyleBackColor = false;
            this.btnAdminUpdate.Visible = false;
            this.btnAdminUpdate.Click += new System.EventHandler(this.btnAdminUpdate_Click);
            // 
            // btnAdminDeleteUser
            // 
            this.btnAdminDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAdminDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnAdminDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnAdminDeleteUser.Location = new System.Drawing.Point(678, 204);
            this.btnAdminDeleteUser.Name = "btnAdminDeleteUser";
            this.btnAdminDeleteUser.Size = new System.Drawing.Size(233, 34);
            this.btnAdminDeleteUser.TabIndex = 12;
            this.btnAdminDeleteUser.Text = "Delete User";
            this.btnAdminDeleteUser.UseVisualStyleBackColor = false;
            this.btnAdminDeleteUser.Visible = false;
            this.btnAdminDeleteUser.Click += new System.EventHandler(this.btnAdminDeleteUser_Click);
            // 
            // lblAdminDisplayAccess
            // 
            this.lblAdminDisplayAccess.AutoSize = true;
            this.lblAdminDisplayAccess.Location = new System.Drawing.Point(1041, 126);
            this.lblAdminDisplayAccess.Name = "lblAdminDisplayAccess";
            this.lblAdminDisplayAccess.Size = new System.Drawing.Size(19, 25);
            this.lblAdminDisplayAccess.TabIndex = 11;
            this.lblAdminDisplayAccess.Text = "-";
            // 
            // lblAdminDisplayEmail
            // 
            this.lblAdminDisplayEmail.AutoSize = true;
            this.lblAdminDisplayEmail.Location = new System.Drawing.Point(1041, 82);
            this.lblAdminDisplayEmail.Name = "lblAdminDisplayEmail";
            this.lblAdminDisplayEmail.Size = new System.Drawing.Size(19, 25);
            this.lblAdminDisplayEmail.TabIndex = 10;
            this.lblAdminDisplayEmail.Text = "-";
            // 
            // lblAdminDisplayLastName
            // 
            this.lblAdminDisplayLastName.AutoSize = true;
            this.lblAdminDisplayLastName.Location = new System.Drawing.Point(1041, 64);
            this.lblAdminDisplayLastName.Name = "lblAdminDisplayLastName";
            this.lblAdminDisplayLastName.Size = new System.Drawing.Size(19, 25);
            this.lblAdminDisplayLastName.TabIndex = 9;
            this.lblAdminDisplayLastName.Text = "-";
            // 
            // lblAdminDisplayFirstName
            // 
            this.lblAdminDisplayFirstName.AutoSize = true;
            this.lblAdminDisplayFirstName.Location = new System.Drawing.Point(1041, 44);
            this.lblAdminDisplayFirstName.Name = "lblAdminDisplayFirstName";
            this.lblAdminDisplayFirstName.Size = new System.Drawing.Size(19, 25);
            this.lblAdminDisplayFirstName.TabIndex = 8;
            this.lblAdminDisplayFirstName.Text = "-";
            // 
            // lblAdminDisplayUser
            // 
            this.lblAdminDisplayUser.AutoSize = true;
            this.lblAdminDisplayUser.Location = new System.Drawing.Point(1041, 11);
            this.lblAdminDisplayUser.Name = "lblAdminDisplayUser";
            this.lblAdminDisplayUser.Size = new System.Drawing.Size(19, 25);
            this.lblAdminDisplayUser.TabIndex = 7;
            this.lblAdminDisplayUser.Text = "-";
            // 
            // lblAdminAccessLevel
            // 
            this.lblAdminAccessLevel.AutoSize = true;
            this.lblAdminAccessLevel.Location = new System.Drawing.Point(917, 126);
            this.lblAdminAccessLevel.Name = "lblAdminAccessLevel";
            this.lblAdminAccessLevel.Size = new System.Drawing.Size(113, 25);
            this.lblAdminAccessLevel.TabIndex = 6;
            this.lblAdminAccessLevel.Text = "Access Level:";
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Location = new System.Drawing.Point(917, 84);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(58, 25);
            this.lblAdminEmail.TabIndex = 5;
            this.lblAdminEmail.Text = "Email:";
            // 
            // lblAdminLastName
            // 
            this.lblAdminLastName.AutoSize = true;
            this.lblAdminLastName.Location = new System.Drawing.Point(917, 64);
            this.lblAdminLastName.Name = "lblAdminLastName";
            this.lblAdminLastName.Size = new System.Drawing.Size(99, 25);
            this.lblAdminLastName.TabIndex = 4;
            this.lblAdminLastName.Text = "Last Name:";
            // 
            // lblAdminFirstName
            // 
            this.lblAdminFirstName.AutoSize = true;
            this.lblAdminFirstName.Location = new System.Drawing.Point(917, 44);
            this.lblAdminFirstName.Name = "lblAdminFirstName";
            this.lblAdminFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblAdminFirstName.TabIndex = 3;
            this.lblAdminFirstName.Text = "First Name:";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Location = new System.Drawing.Point(917, 14);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(95, 25);
            this.lblAdminUsername.TabIndex = 2;
            this.lblAdminUsername.Text = "Username:";
            // 
            // lbxAdminUsers
            // 
            this.lbxAdminUsers.FormattingEnabled = true;
            this.lbxAdminUsers.ItemHeight = 25;
            this.lbxAdminUsers.Location = new System.Drawing.Point(678, 44);
            this.lbxAdminUsers.Name = "lbxAdminUsers";
            this.lbxAdminUsers.Size = new System.Drawing.Size(233, 129);
            this.lbxAdminUsers.TabIndex = 1;
            this.lbxAdminUsers.SelectedIndexChanged += new System.EventHandler(this.lbxAdminUsers_SelectedIndexChanged);
            // 
            // tbxAdminSearch
            // 
            this.tbxAdminSearch.Location = new System.Drawing.Point(678, 11);
            this.tbxAdminSearch.Name = "tbxAdminSearch";
            this.tbxAdminSearch.Size = new System.Drawing.Size(233, 31);
            this.tbxAdminSearch.TabIndex = 0;
            this.tbxAdminSearch.Text = "Search for user";
            this.tbxAdminSearch.TextChanged += new System.EventHandler(this.tbxAdminSearch_TextChanged);
            // 
            // pnlRoutePlotter
            // 
            this.pnlRoutePlotter.Controls.Add(this.btnFindBestRoute);
            this.pnlRoutePlotter.Controls.Add(this.rbtMarkings);
            this.pnlRoutePlotter.Controls.Add(this.rbtClear);
            this.pnlRoutePlotter.Controls.Add(this.lblChartType);
            this.pnlRoutePlotter.Controls.Add(this.button2);
            this.pnlRoutePlotter.Controls.Add(this.button1);
            this.pnlRoutePlotter.Controls.Add(this.btnDeleteWaypoint);
            this.pnlRoutePlotter.Controls.Add(this.btnUpdateWaypoint);
            this.pnlRoutePlotter.Controls.Add(this.txtWaypointY);
            this.pnlRoutePlotter.Controls.Add(this.txtWaypointX);
            this.pnlRoutePlotter.Controls.Add(this.lblWaypointY);
            this.pnlRoutePlotter.Controls.Add(this.lblWaypointX);
            this.pnlRoutePlotter.Controls.Add(this.lstWaypoints);
            this.pnlRoutePlotter.Controls.Add(this.lblWaypoints);
            this.pnlRoutePlotter.Controls.Add(this.pbxChart);
            this.pnlRoutePlotter.Location = new System.Drawing.Point(30, 48);
            this.pnlRoutePlotter.Name = "pnlRoutePlotter";
            this.pnlRoutePlotter.Size = new System.Drawing.Size(1332, 563);
            this.pnlRoutePlotter.TabIndex = 14;
            this.pnlRoutePlotter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRoutePlotter_Paint);
            // 
            // btnFindBestRoute
            // 
            this.btnFindBestRoute.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFindBestRoute.FlatAppearance.BorderSize = 0;
            this.btnFindBestRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBestRoute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindBestRoute.ForeColor = System.Drawing.Color.White;
            this.btnFindBestRoute.Location = new System.Drawing.Point(928, 440);
            this.btnFindBestRoute.Name = "btnFindBestRoute";
            this.btnFindBestRoute.Size = new System.Drawing.Size(280, 40);
            this.btnFindBestRoute.TabIndex = 14;
            this.btnFindBestRoute.Text = "Find Best Route";
            this.btnFindBestRoute.UseVisualStyleBackColor = false;
            this.btnFindBestRoute.Click += new System.EventHandler(this.btnBestRoute_Click);
            // 
            // rbtMarkings
            // 
            this.rbtMarkings.AutoSize = true;
            this.rbtMarkings.Checked = true;
            this.rbtMarkings.Location = new System.Drawing.Point(1034, 203);
            this.rbtMarkings.Name = "rbtMarkings";
            this.rbtMarkings.Size = new System.Drawing.Size(110, 29);
            this.rbtMarkings.TabIndex = 13;
            this.rbtMarkings.TabStop = true;
            this.rbtMarkings.Text = "Markings";
            this.rbtMarkings.UseVisualStyleBackColor = true;
            this.rbtMarkings.CheckedChanged += new System.EventHandler(this.rbtMarkings_CheckedChanged);
            // 
            // rbtClear
            // 
            this.rbtClear.AutoSize = true;
            this.rbtClear.Location = new System.Drawing.Point(1034, 235);
            this.rbtClear.Name = "rbtClear";
            this.rbtClear.Size = new System.Drawing.Size(139, 29);
            this.rbtClear.TabIndex = 12;
            this.rbtClear.Text = "No Markings";
            this.rbtClear.UseVisualStyleBackColor = true;
            this.rbtClear.CheckedChanged += new System.EventHandler(this.rbtClear_CheckedChanged);
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Location = new System.Drawing.Point(920, 203);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(100, 25);
            this.lblChartType.TabIndex = 11;
            this.lblChartType.Text = "Chart Type:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1073, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete Waypoint";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnDeleteWaypoint_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(928, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update Waypoint";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUpdateWaypoint_Click);
            // 
            // btnDeleteWaypoint
            // 
            this.btnDeleteWaypoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteWaypoint.FlatAppearance.BorderSize = 0;
            this.btnDeleteWaypoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWaypoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteWaypoint.ForeColor = System.Drawing.Color.White;
            this.btnDeleteWaypoint.Location = new System.Drawing.Point(1073, 387);
            this.btnDeleteWaypoint.Name = "btnDeleteWaypoint";
            this.btnDeleteWaypoint.Size = new System.Drawing.Size(135, 40);
            this.btnDeleteWaypoint.TabIndex = 8;
            this.btnDeleteWaypoint.Text = "Delete Waypoint";
            this.btnDeleteWaypoint.UseVisualStyleBackColor = false;
            this.btnDeleteWaypoint.Click += new System.EventHandler(this.btnDeleteWaypoint_Click);
            // 
            // btnUpdateWaypoint
            // 
            this.btnUpdateWaypoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpdateWaypoint.FlatAppearance.BorderSize = 0;
            this.btnUpdateWaypoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWaypoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateWaypoint.ForeColor = System.Drawing.Color.White;
            this.btnUpdateWaypoint.Location = new System.Drawing.Point(928, 387);
            this.btnUpdateWaypoint.Name = "btnUpdateWaypoint";
            this.btnUpdateWaypoint.Size = new System.Drawing.Size(135, 40);
            this.btnUpdateWaypoint.TabIndex = 7;
            this.btnUpdateWaypoint.Text = "Update Waypoint";
            this.btnUpdateWaypoint.UseVisualStyleBackColor = false;
            this.btnUpdateWaypoint.Click += new System.EventHandler(this.btnUpdateWaypoint_Click);
            // 
            // txtWaypointY
            // 
            this.txtWaypointY.Location = new System.Drawing.Point(1034, 306);
            this.txtWaypointY.Name = "txtWaypointY";
            this.txtWaypointY.Size = new System.Drawing.Size(180, 31);
            this.txtWaypointY.TabIndex = 6;
            // 
            // txtWaypointX
            // 
            this.txtWaypointX.Location = new System.Drawing.Point(1034, 274);
            this.txtWaypointX.Name = "txtWaypointX";
            this.txtWaypointX.Size = new System.Drawing.Size(180, 31);
            this.txtWaypointX.TabIndex = 5;
            // 
            // lblWaypointY
            // 
            this.lblWaypointY.AutoSize = true;
            this.lblWaypointY.Location = new System.Drawing.Point(920, 309);
            this.lblWaypointY.Name = "lblWaypointY";
            this.lblWaypointY.Size = new System.Drawing.Size(119, 25);
            this.lblWaypointY.TabIndex = 4;
            this.lblWaypointY.Text = "Y Coordinate:";
            // 
            // lblWaypointX
            // 
            this.lblWaypointX.AutoSize = true;
            this.lblWaypointX.Location = new System.Drawing.Point(920, 277);
            this.lblWaypointX.Name = "lblWaypointX";
            this.lblWaypointX.Size = new System.Drawing.Size(120, 25);
            this.lblWaypointX.TabIndex = 3;
            this.lblWaypointX.Text = "X Coordinate:";
            // 
            // lstWaypoints
            // 
            this.lstWaypoints.FormattingEnabled = true;
            this.lstWaypoints.ItemHeight = 25;
            this.lstWaypoints.Location = new System.Drawing.Point(920, 40);
            this.lstWaypoints.Name = "lstWaypoints";
            this.lstWaypoints.Size = new System.Drawing.Size(280, 154);
            this.lstWaypoints.TabIndex = 2;
            this.lstWaypoints.SelectedIndexChanged += new System.EventHandler(this.lbxWaypoints_SelectedIndexChanged);
            // 
            // lblWaypoints
            // 
            this.lblWaypoints.AutoSize = true;
            this.lblWaypoints.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWaypoints.Location = new System.Drawing.Point(920, 10);
            this.lblWaypoints.Name = "lblWaypoints";
            this.lblWaypoints.Size = new System.Drawing.Size(112, 28);
            this.lblWaypoints.TabIndex = 1;
            this.lblWaypoints.Text = "Waypoints";
            // 
            // pbxChart
            // 
            this.pbxChart.Image = ((System.Drawing.Image)(resources.GetObject("pbxChart.Image")));
            this.pbxChart.Location = new System.Drawing.Point(12, 10);
            this.pbxChart.Name = "pbxChart";
            this.pbxChart.Size = new System.Drawing.Size(774, 526);
            this.pbxChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChart.TabIndex = 0;
            this.pbxChart.TabStop = false;
            this.pbxChart.BackgroundImageChanged += new System.EventHandler(this.pbxChart_BackgroundImageChanged);
            this.pbxChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxChart_MouseClick);
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.pnlEventAdminView);
            this.pnlEvents.Controls.Add(this.dtpSelectEvent);
            this.pnlEvents.Controls.Add(this.panel1);
            this.pnlEvents.Location = new System.Drawing.Point(3, 58);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(1287, 595);
            this.pnlEvents.TabIndex = 15;
            this.pnlEvents.Visible = false;
            // 
            // pnlEventAdminView
            // 
            this.pnlEventAdminView.Controls.Add(this.dtpChangeEventDetails);
            this.pnlEventAdminView.Controls.Add(this.btnChangeEventTime);
            this.pnlEventAdminView.Controls.Add(this.btnChangeEventDate);
            this.pnlEventAdminView.Controls.Add(this.btnChangeCloseDate);
            this.pnlEventAdminView.Controls.Add(this.btnCloseSignup);
            this.pnlEventAdminView.Controls.Add(this.btnDeleteEvent);
            this.pnlEventAdminView.Location = new System.Drawing.Point(408, 377);
            this.pnlEventAdminView.Name = "pnlEventAdminView";
            this.pnlEventAdminView.Size = new System.Drawing.Size(555, 176);
            this.pnlEventAdminView.TabIndex = 12;
            this.pnlEventAdminView.Visible = false;
            // 
            // dtpChangeEventDetails
            // 
            this.dtpChangeEventDetails.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpChangeEventDetails.CustomFormat = "dd/MM/yyyy | hh:mm";
            this.dtpChangeEventDetails.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChangeEventDetails.Location = new System.Drawing.Point(8, 73);
            this.dtpChangeEventDetails.Name = "dtpChangeEventDetails";
            this.dtpChangeEventDetails.Size = new System.Drawing.Size(324, 31);
            this.dtpChangeEventDetails.TabIndex = 14;
            // 
            // btnChangeEventTime
            // 
            this.btnChangeEventTime.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChangeEventTime.Location = new System.Drawing.Point(369, 101);
            this.btnChangeEventTime.Name = "btnChangeEventTime";
            this.btnChangeEventTime.Size = new System.Drawing.Size(178, 42);
            this.btnChangeEventTime.TabIndex = 13;
            this.btnChangeEventTime.Text = "Change Event Time";
            this.btnChangeEventTime.UseVisualStyleBackColor = false;
            this.btnChangeEventTime.Click += new System.EventHandler(this.btnChangeEventTime_Click);
            // 
            // btnChangeEventDate
            // 
            this.btnChangeEventDate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChangeEventDate.Location = new System.Drawing.Point(369, 53);
            this.btnChangeEventDate.Name = "btnChangeEventDate";
            this.btnChangeEventDate.Size = new System.Drawing.Size(178, 42);
            this.btnChangeEventDate.TabIndex = 12;
            this.btnChangeEventDate.Text = "Change Event Date";
            this.btnChangeEventDate.UseVisualStyleBackColor = false;
            this.btnChangeEventDate.Click += new System.EventHandler(this.btnChangeEventDate_Click);
            // 
            // btnChangeCloseDate
            // 
            this.btnChangeCloseDate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChangeCloseDate.Location = new System.Drawing.Point(369, 5);
            this.btnChangeCloseDate.Name = "btnChangeCloseDate";
            this.btnChangeCloseDate.Size = new System.Drawing.Size(178, 42);
            this.btnChangeCloseDate.TabIndex = 11;
            this.btnChangeCloseDate.Text = "Change Close Date";
            this.btnChangeCloseDate.UseVisualStyleBackColor = false;
            this.btnChangeCloseDate.Click += new System.EventHandler(this.btnChangeCloseDate_Click);
            // 
            // btnCloseSignup
            // 
            this.btnCloseSignup.BackColor = System.Drawing.Color.LightBlue;
            this.btnCloseSignup.Location = new System.Drawing.Point(192, 5);
            this.btnCloseSignup.Name = "btnCloseSignup";
            this.btnCloseSignup.Size = new System.Drawing.Size(178, 42);
            this.btnCloseSignup.TabIndex = 10;
            this.btnCloseSignup.Text = "Close Signup";
            this.btnCloseSignup.UseVisualStyleBackColor = false;
            this.btnCloseSignup.Click += new System.EventHandler(this.btnCloseSignup_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteEvent.Location = new System.Drawing.Point(8, 5);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(178, 42);
            this.btnDeleteEvent.TabIndex = 7;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // dtpSelectEvent
            // 
            this.dtpSelectEvent.Location = new System.Drawing.Point(39, 85);
            this.dtpSelectEvent.Name = "dtpSelectEvent";
            this.dtpSelectEvent.Size = new System.Drawing.Size(204, 31);
            this.dtpSelectEvent.TabIndex = 3;
            this.dtpSelectEvent.ValueChanged += new System.EventHandler(this.dtpSelectEvent_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSingupsClosed);
            this.panel1.Controls.Add(this.btnNextEvent);
            this.panel1.Controls.Add(this.btnPreviousEvent);
            this.panel1.Controls.Add(this.btnAdminView);
            this.panel1.Controls.Add(this.btnLeaveEvent);
            this.panel1.Controls.Add(this.btnJoinEvent);
            this.panel1.Controls.Add(this.lblSelectedEventTime);
            this.panel1.Controls.Add(this.lblSelectedEventDate);
            this.panel1.Controls.Add(this.lblSelectedEventAuthor);
            this.panel1.Controls.Add(this.lblSelectedEventClasses);
            this.panel1.Controls.Add(this.lblSelectedEventSignups);
            this.panel1.Controls.Add(this.lblSelectedEventName);
            this.panel1.Location = new System.Drawing.Point(408, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 311);
            this.panel1.TabIndex = 2;
            // 
            // btnSingupsClosed
            // 
            this.btnSingupsClosed.BackColor = System.Drawing.Color.DarkGray;
            this.btnSingupsClosed.Enabled = false;
            this.btnSingupsClosed.Location = new System.Drawing.Point(8, 201);
            this.btnSingupsClosed.Name = "btnSingupsClosed";
            this.btnSingupsClosed.Size = new System.Drawing.Size(178, 42);
            this.btnSingupsClosed.TabIndex = 12;
            this.btnSingupsClosed.Text = "Signups Closed";
            this.btnSingupsClosed.UseVisualStyleBackColor = false;
            this.btnSingupsClosed.Visible = false;
            // 
            // btnNextEvent
            // 
            this.btnNextEvent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNextEvent.Location = new System.Drawing.Point(369, 200);
            this.btnNextEvent.Name = "btnNextEvent";
            this.btnNextEvent.Size = new System.Drawing.Size(178, 42);
            this.btnNextEvent.TabIndex = 11;
            this.btnNextEvent.Text = "Next Event";
            this.btnNextEvent.UseVisualStyleBackColor = false;
            this.btnNextEvent.Click += new System.EventHandler(this.btnNextEvent_Click);
            // 
            // btnPreviousEvent
            // 
            this.btnPreviousEvent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPreviousEvent.Location = new System.Drawing.Point(192, 201);
            this.btnPreviousEvent.Name = "btnPreviousEvent";
            this.btnPreviousEvent.Size = new System.Drawing.Size(178, 42);
            this.btnPreviousEvent.TabIndex = 10;
            this.btnPreviousEvent.Text = "Previous Event";
            this.btnPreviousEvent.UseVisualStyleBackColor = false;
            this.btnPreviousEvent.Click += new System.EventHandler(this.btnPreviousEvent_Click);
            // 
            // btnAdminView
            // 
            this.btnAdminView.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdminView.Location = new System.Drawing.Point(8, 248);
            this.btnAdminView.Name = "btnAdminView";
            this.btnAdminView.Size = new System.Drawing.Size(178, 42);
            this.btnAdminView.TabIndex = 9;
            this.btnAdminView.Text = "Enter Admin View";
            this.btnAdminView.UseVisualStyleBackColor = false;
            this.btnAdminView.Visible = false;
            this.btnAdminView.Click += new System.EventHandler(this.btnAdminView_Click);
            // 
            // btnLeaveEvent
            // 
            this.btnLeaveEvent.BackColor = System.Drawing.Color.Salmon;
            this.btnLeaveEvent.Location = new System.Drawing.Point(7, 200);
            this.btnLeaveEvent.Name = "btnLeaveEvent";
            this.btnLeaveEvent.Size = new System.Drawing.Size(178, 42);
            this.btnLeaveEvent.TabIndex = 8;
            this.btnLeaveEvent.Text = "Remove Signup";
            this.btnLeaveEvent.UseVisualStyleBackColor = false;
            this.btnLeaveEvent.Click += new System.EventHandler(this.btnLeaveEvent_Click);
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.BackColor = System.Drawing.Color.LightGreen;
            this.btnJoinEvent.Location = new System.Drawing.Point(8, 200);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(178, 42);
            this.btnJoinEvent.TabIndex = 7;
            this.btnJoinEvent.Text = "Join Event";
            this.btnJoinEvent.UseVisualStyleBackColor = false;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click);
            // 
            // lblSelectedEventTime
            // 
            this.lblSelectedEventTime.AutoSize = true;
            this.lblSelectedEventTime.Location = new System.Drawing.Point(3, 134);
            this.lblSelectedEventTime.Name = "lblSelectedEventTime";
            this.lblSelectedEventTime.Size = new System.Drawing.Size(102, 25);
            this.lblSelectedEventTime.TabIndex = 6;
            this.lblSelectedEventTime.Text = "Event Time:";
            // 
            // lblSelectedEventDate
            // 
            this.lblSelectedEventDate.AutoSize = true;
            this.lblSelectedEventDate.Location = new System.Drawing.Point(3, 109);
            this.lblSelectedEventDate.Name = "lblSelectedEventDate";
            this.lblSelectedEventDate.Size = new System.Drawing.Size(101, 25);
            this.lblSelectedEventDate.TabIndex = 5;
            this.lblSelectedEventDate.Text = "Event Date:";
            // 
            // lblSelectedEventAuthor
            // 
            this.lblSelectedEventAuthor.AutoSize = true;
            this.lblSelectedEventAuthor.Location = new System.Drawing.Point(3, 82);
            this.lblSelectedEventAuthor.Name = "lblSelectedEventAuthor";
            this.lblSelectedEventAuthor.Size = new System.Drawing.Size(122, 25);
            this.lblSelectedEventAuthor.TabIndex = 4;
            this.lblSelectedEventAuthor.Text = "Event Creator:";
            // 
            // lblSelectedEventClasses
            // 
            this.lblSelectedEventClasses.AutoSize = true;
            this.lblSelectedEventClasses.Location = new System.Drawing.Point(3, 57);
            this.lblSelectedEventClasses.Name = "lblSelectedEventClasses";
            this.lblSelectedEventClasses.Size = new System.Drawing.Size(131, 25);
            this.lblSelectedEventClasses.TabIndex = 3;
            this.lblSelectedEventClasses.Text = "Racing Classes:";
            // 
            // lblSelectedEventSignups
            // 
            this.lblSelectedEventSignups.AutoSize = true;
            this.lblSelectedEventSignups.Location = new System.Drawing.Point(2, 35);
            this.lblSelectedEventSignups.Name = "lblSelectedEventSignups";
            this.lblSelectedEventSignups.Size = new System.Drawing.Size(80, 25);
            this.lblSelectedEventSignups.TabIndex = 2;
            this.lblSelectedEventSignups.Text = "Signups:";
            // 
            // lblSelectedEventName
            // 
            this.lblSelectedEventName.AutoSize = true;
            this.lblSelectedEventName.Location = new System.Drawing.Point(3, 10);
            this.lblSelectedEventName.Name = "lblSelectedEventName";
            this.lblSelectedEventName.Size = new System.Drawing.Size(151, 25);
            this.lblSelectedEventName.TabIndex = 1;
            this.lblSelectedEventName.Text = "Event ID + Name:";
            // 
            // rtbNoticesHome
            // 
            this.rtbNoticesHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbNoticesHome.Location = new System.Drawing.Point(22, 17);
            this.rtbNoticesHome.Name = "rtbNoticesHome";
            this.rtbNoticesHome.ReadOnly = true;
            this.rtbNoticesHome.Size = new System.Drawing.Size(575, 230);
            this.rtbNoticesHome.TabIndex = 0;
            this.rtbNoticesHome.Text = "";
            // 
            // lblNoticesAuthor
            // 
            this.lblNoticesAuthor.AutoSize = true;
            this.lblNoticesAuthor.Location = new System.Drawing.Point(25, 254);
            this.lblNoticesAuthor.Name = "lblNoticesAuthor";
            this.lblNoticesAuthor.Size = new System.Drawing.Size(146, 25);
            this.lblNoticesAuthor.TabIndex = 1;
            this.lblNoticesAuthor.Text = "Message Author:";
            // 
            // btnNextNotice
            // 
            this.btnNextNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNextNotice.FlatAppearance.BorderSize = 0;
            this.btnNextNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextNotice.ForeColor = System.Drawing.Color.White;
            this.btnNextNotice.Location = new System.Drawing.Point(21, 280);
            this.btnNextNotice.Name = "btnNextNotice";
            this.btnNextNotice.Size = new System.Drawing.Size(134, 57);
            this.btnNextNotice.TabIndex = 2;
            this.btnNextNotice.Text = "Next Notice";
            this.btnNextNotice.UseVisualStyleBackColor = false;
            this.btnNextNotice.Click += new System.EventHandler(this.btnNextNotice_Click);
            // 
            // btnDeleteNotice
            // 
            this.btnDeleteNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteNotice.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteNotice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotice.Location = new System.Drawing.Point(162, 281);
            this.btnDeleteNotice.Name = "btnDeleteNotice";
            this.btnDeleteNotice.Size = new System.Drawing.Size(129, 56);
            this.btnDeleteNotice.TabIndex = 3;
            this.btnDeleteNotice.Text = "Delete Notice";
            this.btnDeleteNotice.UseVisualStyleBackColor = false;
            this.btnDeleteNotice.Visible = false;
            this.btnDeleteNotice.Click += new System.EventHandler(this.btnDeleteNotice_Click);
            // 
            // pnlNoticePage
            // 
            this.pnlNoticePage.Controls.Add(this.btnDeleteNotice);
            this.pnlNoticePage.Controls.Add(this.btnNextNotice);
            this.pnlNoticePage.Controls.Add(this.lblNoticesAuthor);
            this.pnlNoticePage.Controls.Add(this.rtbNoticesHome);
            this.pnlNoticePage.Location = new System.Drawing.Point(0, 65);
            this.pnlNoticePage.Name = "pnlNoticePage";
            this.pnlNoticePage.Size = new System.Drawing.Size(1217, 605);
            this.pnlNoticePage.TabIndex = 13;
            this.pnlNoticePage.Visible = false;
            // 
            // frmMainApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1593, 654);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlEvents);
            this.Controls.Add(this.pnlRoutePlotter);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.pnlNoticePage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainApplication";
            this.Text = "Waypoint Navigator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApplication_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlUpdateAdmin.ResumeLayout(false);
            this.pnlUpdateAdmin.PerformLayout();
            this.pnlRoutePlotter.ResumeLayout(false);
            this.pnlRoutePlotter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChart)).EndInit();
            this.pnlEvents.ResumeLayout(false);
            this.pnlEventAdminView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNoticePage.ResumeLayout(false);
            this.pnlNoticePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NoticesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeplotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.TextBox tbxAdminSearch;
        private System.Windows.Forms.ListBox lbxAdminUsers;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.Label lblAdminAccessLevel;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.Label lblAdminLastName;
        private System.Windows.Forms.Label lblAdminFirstName;
        private System.Windows.Forms.Label lblAdminDisplayAccess;
        private System.Windows.Forms.Label lblAdminDisplayEmail;
        private System.Windows.Forms.Label lblAdminDisplayLastName;
        private System.Windows.Forms.Label lblAdminDisplayFirstName;
        private System.Windows.Forms.Label lblAdminDisplayUser;
        private System.Windows.Forms.Button btnAdminDeleteUser;
        private System.Windows.Forms.Panel pnlUpdateAdmin;
        private System.Windows.Forms.Label lblUpdateAccess;
        private System.Windows.Forms.Label pnlUpdateUsername;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdateFN;
        private System.Windows.Forms.Label lblUpdateLN;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.TextBox tbxEmailUpdate;
        private System.Windows.Forms.TextBox tbxLNUpdate;
        private System.Windows.Forms.TextBox tbxFNUpdate;
        private System.Windows.Forms.TextBox tbxUsernameUpdate;
        private System.Windows.Forms.ComboBox cbxAccess;
        private System.Windows.Forms.Button btnUpdateConfirm;
        private System.Windows.Forms.RichTextBox rtbNotices;
        private System.Windows.Forms.DateTimePicker dtpNotice;
        private System.Windows.Forms.Button btnPostNotice;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblNoticeDate;
        private System.Windows.Forms.Panel pnlRoutePlotter;
        private System.Windows.Forms.PictureBox pbxChart;
        private System.Windows.Forms.Label lblWaypoints;
        private System.Windows.Forms.ListBox lstWaypoints;
        private System.Windows.Forms.Label lblWaypointX;
        private System.Windows.Forms.Label lblWaypointY;
        private System.Windows.Forms.TextBox txtWaypointX;
        private System.Windows.Forms.TextBox txtWaypointY;
        private System.Windows.Forms.Button btnUpdateWaypoint;
        private System.Windows.Forms.Button btnDeleteWaypoint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtMarkings;
        private System.Windows.Forms.RadioButton rbtClear;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.Button btnFindBestRoute;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label lblDateOfEvent;
        private System.Windows.Forms.DateTimePicker dtpDateOfEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label lblEventCreation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSignupClose;
        private System.Windows.Forms.Label lblCreateEventName;
        private System.Windows.Forms.Label lblCreateEventClasses;
        private System.Windows.Forms.TextBox tbxEventName;
        private System.Windows.Forms.Label lblCreateTimeOfEvent;
        private System.Windows.Forms.DateTimePicker dtpCreateTimeOfEvent;
        private System.Windows.Forms.CheckedListBox clbCreateEventClasses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectedEventSignups;
        private System.Windows.Forms.Label lblSelectedEventName;
        private System.Windows.Forms.Label lblSelectedEventAuthor;
        private System.Windows.Forms.Label lblSelectedEventClasses;
        private System.Windows.Forms.Label lblSelectedEventTime;
        private System.Windows.Forms.Label lblSelectedEventDate;
        private System.Windows.Forms.Button btnLeaveEvent;
        private System.Windows.Forms.Button btnJoinEvent;
        private System.Windows.Forms.Button btnNextEvent;
        private System.Windows.Forms.Button btnPreviousEvent;
        private System.Windows.Forms.Button btnAdminView;
        private System.Windows.Forms.DateTimePicker dtpSelectEvent;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbNoticesHome;
        private System.Windows.Forms.Label lblNoticesAuthor;
        private System.Windows.Forms.Button btnNextNotice;
        private System.Windows.Forms.Button btnDeleteNotice;
        private System.Windows.Forms.Panel pnlNoticePage;
        private System.Windows.Forms.Panel pnlEventAdminView;
        private System.Windows.Forms.Button btnCloseSignup;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnChangeCloseDate;
        private System.Windows.Forms.Button btnChangeEventTime;
        private System.Windows.Forms.Button btnChangeEventDate;
        private System.Windows.Forms.DateTimePicker dtpChangeEventDetails;
        private System.Windows.Forms.Button btnSingupsClosed;
    }
}