namespace GradeTracker_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login = new Panel();
            CreateAccountBuuton = new Button();
            LoginError = new Label();
            Loginbutton = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            CourseDisplay = new Panel();
            CreateAssignmentSitchButton = new Button();
            AddSelectedStudentButton = new Button();
            StudentSelectDropDown = new ComboBox();
            TeacherCourseDetailsBackButton = new Button();
            AssignCourse = new Label();
            AssignmentList = new ListBox();
            label5 = new Label();
            StudentListBox = new ListBox();
            CourseNameLabel = new Label();
            CreateAssignmentPanel = new Panel();
            CreateAccountpanel = new Panel();
            CreateAccountCreate = new Button();
            UserTypeDropDown = new ComboBox();
            CreateAccountPassword = new TextBox();
            CreateAccountUserName = new TextBox();
            CreateAssignmentButton = new Button();
            MaxPointsTextBox = new TextBox();
            AssignmentTitleTextBox = new TextBox();
            Menu = new Panel();
            StudentCourseDisplay = new Panel();
            label10 = new Label();
            GPATextBox = new TextBox();
            label4 = new Label();
            CourseGradeTextBox = new TextBox();
            StudentCourseDisplayBackButton = new Button();
            label6 = new Label();
            AssignmentListBoxStudent = new ListBox();
            CourseNameLableStudent = new Label();
            TeacherViewOfStudent = new Panel();
            TeacherViewOfStudentBackButton = new Button();
            label7 = new Label();
            TeacherViewStudentAssignmentsList = new ListBox();
            StudentNameLabel = new Label();
            MenuBackButton = new Button();
            courses = new Button();
            label2 = new Label();
            AddCoursePanel = new Panel();
            AddCourseButton = new Button();
            NewCourseNameTextBox = new TextBox();
            StudentAssingmentEditor = new Panel();
            StudentAssingmentEditorBack = new Button();
            StudentAssingmentEditorComment = new TextBox();
            label13 = new Label();
            StudentAssingmentEditorComments = new ListBox();
            StudentAssingmentEditorTotalPoints = new TextBox();
            label12 = new Label();
            StudentAssingmentEditorPointsScored = new TextBox();
            label11 = new Label();
            StudentAssingmentEditorCourseName = new Label();
            TeacherAssignmentEditor = new Panel();
            TeacherAssignmentEditorSave = new Button();
            TeacherAssingmentEditorNewComment = new TextBox();
            TeacherAssingmentEditorComments = new ListBox();
            TeacherAssignmentEditorTotalPoints = new TextBox();
            label9 = new Label();
            TeacherAssignmentEditorPointsScored = new TextBox();
            label8 = new Label();
            TeacherAssignmentEditorAssignmentName = new Label();
            TeacherAssignmentEditorStudentName = new Label();
            courseList = new Panel();
            CreateCourseButton = new Button();
            CourseListBackButton = new Button();
            CourselistBox = new ListBox();
            label3 = new Label();
            Login.SuspendLayout();
            CourseDisplay.SuspendLayout();
            CreateAssignmentPanel.SuspendLayout();
            CreateAccountpanel.SuspendLayout();
            Menu.SuspendLayout();
            StudentCourseDisplay.SuspendLayout();
            TeacherViewOfStudent.SuspendLayout();
            AddCoursePanel.SuspendLayout();
            StudentAssingmentEditor.SuspendLayout();
            TeacherAssignmentEditor.SuspendLayout();
            courseList.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Controls.Add(CreateAccountBuuton);
            Login.Controls.Add(LoginError);
            Login.Controls.Add(Loginbutton);
            Login.Controls.Add(Password);
            Login.Controls.Add(Username);
            Login.Controls.Add(label1);
            Login.Dock = DockStyle.Fill;
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(1091, 667);
            Login.TabIndex = 0;
            // 
            // CreateAccountBuuton
            // 
            CreateAccountBuuton.Anchor = AnchorStyles.Top;
            CreateAccountBuuton.Location = new Point(466, 225);
            CreateAccountBuuton.Name = "CreateAccountBuuton";
            CreateAccountBuuton.Size = new Size(153, 34);
            CreateAccountBuuton.TabIndex = 5;
            CreateAccountBuuton.Text = "Create Account";
            CreateAccountBuuton.UseVisualStyleBackColor = true;
            CreateAccountBuuton.Click += CreateAccountBuuton_Click;
            // 
            // LoginError
            // 
            LoginError.Anchor = AnchorStyles.Top;
            LoginError.AutoSize = true;
            LoginError.Location = new Point(478, 138);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 25);
            LoginError.TabIndex = 4;
            // 
            // Loginbutton
            // 
            Loginbutton.Anchor = AnchorStyles.Top;
            Loginbutton.Location = new Point(469, 175);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(150, 33);
            Loginbutton.TabIndex = 3;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top;
            Password.Location = new Point(469, 98);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(150, 31);
            Password.TabIndex = 2;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top;
            Username.Location = new Point(469, 47);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(150, 31);
            Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(517, 7);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // CourseDisplay
            // 
            CourseDisplay.Controls.Add(CreateAssignmentSitchButton);
            CourseDisplay.Controls.Add(AddSelectedStudentButton);
            CourseDisplay.Controls.Add(StudentSelectDropDown);
            CourseDisplay.Controls.Add(TeacherCourseDetailsBackButton);
            CourseDisplay.Controls.Add(Login);
            CourseDisplay.Controls.Add(AssignCourse);
            CourseDisplay.Controls.Add(AssignmentList);
            CourseDisplay.Controls.Add(label5);
            CourseDisplay.Controls.Add(StudentListBox);
            CourseDisplay.Controls.Add(CourseNameLabel);
            CourseDisplay.Dock = DockStyle.Fill;
            CourseDisplay.Location = new Point(0, 0);
            CourseDisplay.Name = "CourseDisplay";
            CourseDisplay.Size = new Size(1091, 667);
            CourseDisplay.TabIndex = 1;
            // 
            // CreateAssignmentSitchButton
            // 
            CreateAssignmentSitchButton.Anchor = AnchorStyles.Top;
            CreateAssignmentSitchButton.Location = new Point(542, 220);
            CreateAssignmentSitchButton.Name = "CreateAssignmentSitchButton";
            CreateAssignmentSitchButton.Size = new Size(210, 34);
            CreateAssignmentSitchButton.TabIndex = 8;
            CreateAssignmentSitchButton.Text = "Create Assignment";
            CreateAssignmentSitchButton.UseVisualStyleBackColor = true;
            CreateAssignmentSitchButton.Click += CreateAssignmentSitchButton_Click;
            // 
            // AddSelectedStudentButton
            // 
            AddSelectedStudentButton.Anchor = AnchorStyles.Top;
            AddSelectedStudentButton.Location = new Point(542, 180);
            AddSelectedStudentButton.Name = "AddSelectedStudentButton";
            AddSelectedStudentButton.Size = new Size(213, 34);
            AddSelectedStudentButton.TabIndex = 7;
            AddSelectedStudentButton.Text = "Add student to course";
            AddSelectedStudentButton.UseVisualStyleBackColor = true;
            AddSelectedStudentButton.Click += AddSelectedStudentButton_Click;
            // 
            // StudentSelectDropDown
            // 
            StudentSelectDropDown.Anchor = AnchorStyles.Top;
            StudentSelectDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentSelectDropDown.FormattingEnabled = true;
            StudentSelectDropDown.Location = new Point(300, 180);
            StudentSelectDropDown.Name = "StudentSelectDropDown";
            StudentSelectDropDown.Size = new Size(221, 33);
            StudentSelectDropDown.TabIndex = 6;
            // 
            // TeacherCourseDetailsBackButton
            // 
            TeacherCourseDetailsBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TeacherCourseDetailsBackButton.Location = new Point(927, 24);
            TeacherCourseDetailsBackButton.Name = "TeacherCourseDetailsBackButton";
            TeacherCourseDetailsBackButton.Size = new Size(112, 34);
            TeacherCourseDetailsBackButton.TabIndex = 5;
            TeacherCourseDetailsBackButton.Text = "Back";
            TeacherCourseDetailsBackButton.UseVisualStyleBackColor = true;
            TeacherCourseDetailsBackButton.Click += TeacherCourseDetailsBackButton_Click;
            // 
            // AssignCourse
            // 
            AssignCourse.Anchor = AnchorStyles.Top;
            AssignCourse.AutoSize = true;
            AssignCourse.Location = new Point(310, 225);
            AssignCourse.Margin = new Padding(4, 0, 4, 0);
            AssignCourse.Name = "AssignCourse";
            AssignCourse.Size = new Size(193, 25);
            AssignCourse.TabIndex = 4;
            AssignCourse.Text = "Assignments in Course";
            // 
            // AssignmentList
            // 
            AssignmentList.Anchor = AnchorStyles.Top;
            AssignmentList.FormattingEnabled = true;
            AssignmentList.ItemHeight = 25;
            AssignmentList.Location = new Point(300, 257);
            AssignmentList.Margin = new Padding(4, 5, 4, 5);
            AssignmentList.Name = "AssignmentList";
            AssignmentList.Size = new Size(455, 129);
            AssignmentList.TabIndex = 3;
            AssignmentList.SelectedIndexChanged += AssignmentList_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(304, 33);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 2;
            label5.Text = "Students in Course";
            // 
            // StudentListBox
            // 
            StudentListBox.Anchor = AnchorStyles.Top;
            StudentListBox.FormattingEnabled = true;
            StudentListBox.ItemHeight = 25;
            StudentListBox.Location = new Point(300, 70);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(455, 104);
            StudentListBox.TabIndex = 1;
            StudentListBox.SelectedIndexChanged += StudentListBox_SelectedIndexChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.Anchor = AnchorStyles.Top;
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Location = new Point(248, 8);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(137, 25);
            CourseNameLabel.TabIndex = 0;
            CourseNameLabel.Text = "<course name>";
            // 
            // CreateAssignmentPanel
            // 
            CreateAssignmentPanel.Controls.Add(CreateAccountpanel);
            CreateAssignmentPanel.Controls.Add(CreateAssignmentButton);
            CreateAssignmentPanel.Controls.Add(MaxPointsTextBox);
            CreateAssignmentPanel.Controls.Add(AssignmentTitleTextBox);
            CreateAssignmentPanel.Dock = DockStyle.Fill;
            CreateAssignmentPanel.Location = new Point(0, 0);
            CreateAssignmentPanel.Name = "CreateAssignmentPanel";
            CreateAssignmentPanel.Size = new Size(1091, 667);
            CreateAssignmentPanel.TabIndex = 2;
            // 
            // CreateAccountpanel
            // 
            CreateAccountpanel.Controls.Add(CourseDisplay);
            CreateAccountpanel.Controls.Add(CreateAccountCreate);
            CreateAccountpanel.Controls.Add(UserTypeDropDown);
            CreateAccountpanel.Controls.Add(CreateAccountPassword);
            CreateAccountpanel.Controls.Add(CreateAccountUserName);
            CreateAccountpanel.Dock = DockStyle.Fill;
            CreateAccountpanel.Location = new Point(0, 0);
            CreateAccountpanel.Name = "CreateAccountpanel";
            CreateAccountpanel.Size = new Size(1091, 667);
            CreateAccountpanel.TabIndex = 2;
            // 
            // CreateAccountCreate
            // 
            CreateAccountCreate.Anchor = AnchorStyles.Top;
            CreateAccountCreate.Location = new Point(487, 249);
            CreateAccountCreate.Name = "CreateAccountCreate";
            CreateAccountCreate.Size = new Size(150, 34);
            CreateAccountCreate.TabIndex = 3;
            CreateAccountCreate.Text = "Create account";
            CreateAccountCreate.UseVisualStyleBackColor = true;
            CreateAccountCreate.Click += CreateAccountCreate_Click;
            // 
            // UserTypeDropDown
            // 
            UserTypeDropDown.Anchor = AnchorStyles.Top;
            UserTypeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            UserTypeDropDown.FormattingEnabled = true;
            UserTypeDropDown.Location = new Point(464, 173);
            UserTypeDropDown.Name = "UserTypeDropDown";
            UserTypeDropDown.Size = new Size(182, 33);
            UserTypeDropDown.TabIndex = 2;
            // 
            // CreateAccountPassword
            // 
            CreateAccountPassword.Anchor = AnchorStyles.Top;
            CreateAccountPassword.Location = new Point(487, 119);
            CreateAccountPassword.Name = "CreateAccountPassword";
            CreateAccountPassword.PlaceholderText = "Password";
            CreateAccountPassword.Size = new Size(150, 31);
            CreateAccountPassword.TabIndex = 1;
            // 
            // CreateAccountUserName
            // 
            CreateAccountUserName.Anchor = AnchorStyles.Top;
            CreateAccountUserName.Location = new Point(487, 62);
            CreateAccountUserName.Name = "CreateAccountUserName";
            CreateAccountUserName.PlaceholderText = "Username";
            CreateAccountUserName.Size = new Size(150, 31);
            CreateAccountUserName.TabIndex = 0;
            // 
            // CreateAssignmentButton
            // 
            CreateAssignmentButton.Anchor = AnchorStyles.Top;
            CreateAssignmentButton.Location = new Point(475, 196);
            CreateAssignmentButton.Name = "CreateAssignmentButton";
            CreateAssignmentButton.Size = new Size(177, 34);
            CreateAssignmentButton.TabIndex = 2;
            CreateAssignmentButton.Text = "Create Assignment";
            CreateAssignmentButton.UseVisualStyleBackColor = true;
            CreateAssignmentButton.Click += CreateAssignmentButton_Click;
            // 
            // MaxPointsTextBox
            // 
            MaxPointsTextBox.Anchor = AnchorStyles.Top;
            MaxPointsTextBox.Location = new Point(444, 124);
            MaxPointsTextBox.Name = "MaxPointsTextBox";
            MaxPointsTextBox.PlaceholderText = "Max points";
            MaxPointsTextBox.Size = new Size(243, 31);
            MaxPointsTextBox.TabIndex = 1;
            // 
            // AssignmentTitleTextBox
            // 
            AssignmentTitleTextBox.Anchor = AnchorStyles.Top;
            AssignmentTitleTextBox.Location = new Point(444, 70);
            AssignmentTitleTextBox.Name = "AssignmentTitleTextBox";
            AssignmentTitleTextBox.PlaceholderText = "Assignment title";
            AssignmentTitleTextBox.Size = new Size(243, 31);
            AssignmentTitleTextBox.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.Controls.Add(StudentCourseDisplay);
            Menu.Controls.Add(MenuBackButton);
            Menu.Controls.Add(courses);
            Menu.Controls.Add(label2);
            Menu.Dock = DockStyle.Fill;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1091, 667);
            Menu.TabIndex = 1;
            // 
            // StudentCourseDisplay
            // 
            StudentCourseDisplay.Controls.Add(label10);
            StudentCourseDisplay.Controls.Add(GPATextBox);
            StudentCourseDisplay.Controls.Add(label4);
            StudentCourseDisplay.Controls.Add(CourseGradeTextBox);
            StudentCourseDisplay.Controls.Add(StudentCourseDisplayBackButton);
            StudentCourseDisplay.Controls.Add(label6);
            StudentCourseDisplay.Controls.Add(AssignmentListBoxStudent);
            StudentCourseDisplay.Controls.Add(CourseNameLableStudent);
            StudentCourseDisplay.Controls.Add(TeacherViewOfStudent);
            StudentCourseDisplay.Dock = DockStyle.Fill;
            StudentCourseDisplay.Location = new Point(0, 0);
            StudentCourseDisplay.Name = "StudentCourseDisplay";
            StudentCourseDisplay.Size = new Size(1091, 667);
            StudentCourseDisplay.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(475, 36);
            label10.Name = "label10";
            label10.Size = new Size(45, 25);
            label10.TabIndex = 7;
            label10.Text = "GPA";
            // 
            // GPATextBox
            // 
            GPATextBox.Anchor = AnchorStyles.Top;
            GPATextBox.Location = new Point(423, 83);
            GPATextBox.Name = "GPATextBox";
            GPATextBox.ReadOnly = true;
            GPATextBox.Size = new Size(150, 31);
            GPATextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(579, 36);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 5;
            label4.Text = "Course grade (%)";
            // 
            // CourseGradeTextBox
            // 
            CourseGradeTextBox.Anchor = AnchorStyles.Top;
            CourseGradeTextBox.Location = new Point(579, 83);
            CourseGradeTextBox.Name = "CourseGradeTextBox";
            CourseGradeTextBox.ReadOnly = true;
            CourseGradeTextBox.Size = new Size(150, 31);
            CourseGradeTextBox.TabIndex = 4;
            // 
            // StudentCourseDisplayBackButton
            // 
            StudentCourseDisplayBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StudentCourseDisplayBackButton.Location = new Point(984, 44);
            StudentCourseDisplayBackButton.Name = "StudentCourseDisplayBackButton";
            StudentCourseDisplayBackButton.Size = new Size(112, 34);
            StudentCourseDisplayBackButton.TabIndex = 3;
            StudentCourseDisplayBackButton.Text = "Back";
            StudentCourseDisplayBackButton.UseVisualStyleBackColor = true;
            StudentCourseDisplayBackButton.Click += StudentCourseDisplayBackButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(336, 117);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 2;
            label6.Text = "Assignments";
            label6.Click += label6_Click;
            // 
            // AssignmentListBoxStudent
            // 
            AssignmentListBoxStudent.Anchor = AnchorStyles.Top;
            AssignmentListBoxStudent.FormattingEnabled = true;
            AssignmentListBoxStudent.ItemHeight = 25;
            AssignmentListBoxStudent.Location = new Point(336, 159);
            AssignmentListBoxStudent.Name = "AssignmentListBoxStudent";
            AssignmentListBoxStudent.Size = new Size(455, 154);
            AssignmentListBoxStudent.TabIndex = 1;
            AssignmentListBoxStudent.SelectedIndexChanged += AssignmentListBoxStudent_SelectedIndexChanged;
            // 
            // CourseNameLableStudent
            // 
            CourseNameLableStudent.Anchor = AnchorStyles.Top;
            CourseNameLableStudent.AutoSize = true;
            CourseNameLableStudent.Location = new Point(284, 28);
            CourseNameLableStudent.Name = "CourseNameLableStudent";
            CourseNameLableStudent.Size = new Size(143, 25);
            CourseNameLableStudent.TabIndex = 0;
            CourseNameLableStudent.Text = "<Course Name>";
            // 
            // TeacherViewOfStudent
            // 
            TeacherViewOfStudent.Controls.Add(CreateAssignmentPanel);
            TeacherViewOfStudent.Controls.Add(TeacherViewOfStudentBackButton);
            TeacherViewOfStudent.Controls.Add(label7);
            TeacherViewOfStudent.Controls.Add(TeacherViewStudentAssignmentsList);
            TeacherViewOfStudent.Controls.Add(StudentNameLabel);
            TeacherViewOfStudent.Dock = DockStyle.Fill;
            TeacherViewOfStudent.Location = new Point(0, 0);
            TeacherViewOfStudent.Name = "TeacherViewOfStudent";
            TeacherViewOfStudent.Size = new Size(1091, 667);
            TeacherViewOfStudent.TabIndex = 1;
            // 
            // TeacherViewOfStudentBackButton
            // 
            TeacherViewOfStudentBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TeacherViewOfStudentBackButton.Location = new Point(945, 42);
            TeacherViewOfStudentBackButton.Name = "TeacherViewOfStudentBackButton";
            TeacherViewOfStudentBackButton.Size = new Size(112, 34);
            TeacherViewOfStudentBackButton.TabIndex = 3;
            TeacherViewOfStudentBackButton.Text = "Back";
            TeacherViewOfStudentBackButton.UseVisualStyleBackColor = true;
            TeacherViewOfStudentBackButton.Click += TeacherViewOfStudentBackButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(300, 64);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 2;
            label7.Text = "Assignments";
            // 
            // TeacherViewStudentAssignmentsList
            // 
            TeacherViewStudentAssignmentsList.Anchor = AnchorStyles.Top;
            TeacherViewStudentAssignmentsList.FormattingEnabled = true;
            TeacherViewStudentAssignmentsList.ItemHeight = 25;
            TeacherViewStudentAssignmentsList.Location = new Point(300, 92);
            TeacherViewStudentAssignmentsList.Name = "TeacherViewStudentAssignmentsList";
            TeacherViewStudentAssignmentsList.Size = new Size(478, 254);
            TeacherViewStudentAssignmentsList.TabIndex = 1;
            TeacherViewStudentAssignmentsList.SelectedIndexChanged += TeacherViewStudentAssignmentsList_SelectedIndexChanged;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.Anchor = AnchorStyles.Top;
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(267, 20);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(146, 25);
            StudentNameLabel.TabIndex = 0;
            StudentNameLabel.Text = "<Student name>";
            StudentNameLabel.Click += StudentNameLabel_Click;
            // 
            // MenuBackButton
            // 
            MenuBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MenuBackButton.Location = new Point(975, 12);
            MenuBackButton.Name = "MenuBackButton";
            MenuBackButton.Size = new Size(112, 34);
            MenuBackButton.TabIndex = 2;
            MenuBackButton.Text = "Back";
            MenuBackButton.UseVisualStyleBackColor = true;
            MenuBackButton.Click += MenuBackButton_Click;
            // 
            // courses
            // 
            courses.Anchor = AnchorStyles.Top;
            courses.Location = new Point(487, 48);
            courses.Name = "courses";
            courses.Size = new Size(111, 33);
            courses.TabIndex = 1;
            courses.Text = "Courses";
            courses.UseVisualStyleBackColor = true;
            courses.Click += courses_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(520, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            // 
            // AddCoursePanel
            // 
            AddCoursePanel.Controls.Add(AddCourseButton);
            AddCoursePanel.Controls.Add(Menu);
            AddCoursePanel.Controls.Add(NewCourseNameTextBox);
            AddCoursePanel.Dock = DockStyle.Fill;
            AddCoursePanel.Location = new Point(0, 0);
            AddCoursePanel.Name = "AddCoursePanel";
            AddCoursePanel.Size = new Size(1091, 667);
            AddCoursePanel.TabIndex = 3;
            // 
            // AddCourseButton
            // 
            AddCourseButton.Anchor = AnchorStyles.Top;
            AddCourseButton.Location = new Point(478, 159);
            AddCourseButton.Name = "AddCourseButton";
            AddCourseButton.Size = new Size(151, 34);
            AddCourseButton.TabIndex = 1;
            AddCourseButton.Text = "Add Course";
            AddCourseButton.UseVisualStyleBackColor = true;
            AddCourseButton.Click += AddCourseButton_Click;
            // 
            // NewCourseNameTextBox
            // 
            NewCourseNameTextBox.Anchor = AnchorStyles.Top;
            NewCourseNameTextBox.Location = new Point(377, 74);
            NewCourseNameTextBox.Name = "NewCourseNameTextBox";
            NewCourseNameTextBox.PlaceholderText = "New course name";
            NewCourseNameTextBox.Size = new Size(369, 31);
            NewCourseNameTextBox.TabIndex = 0;
            // 
            // StudentAssingmentEditor
            // 
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorBack);
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorComment);
            StudentAssingmentEditor.Controls.Add(label13);
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorComments);
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorTotalPoints);
            StudentAssingmentEditor.Controls.Add(label12);
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorPointsScored);
            StudentAssingmentEditor.Controls.Add(label11);
            StudentAssingmentEditor.Controls.Add(StudentAssingmentEditorCourseName);
            StudentAssingmentEditor.Dock = DockStyle.Fill;
            StudentAssingmentEditor.Location = new Point(0, 0);
            StudentAssingmentEditor.Name = "StudentAssingmentEditor";
            StudentAssingmentEditor.Size = new Size(1091, 667);
            StudentAssingmentEditor.TabIndex = 1;
            // 
            // StudentAssingmentEditorBack
            // 
            StudentAssingmentEditorBack.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorBack.Location = new Point(454, 311);
            StudentAssingmentEditorBack.Name = "StudentAssingmentEditorBack";
            StudentAssingmentEditorBack.Size = new Size(135, 34);
            StudentAssingmentEditorBack.TabIndex = 8;
            StudentAssingmentEditorBack.Text = "Save and Back";
            StudentAssingmentEditorBack.UseVisualStyleBackColor = true;
            StudentAssingmentEditorBack.Click += StudentAssingmentEditorBack_Click;
            // 
            // StudentAssingmentEditorComment
            // 
            StudentAssingmentEditorComment.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorComment.Location = new Point(286, 261);
            StudentAssingmentEditorComment.Name = "StudentAssingmentEditorComment";
            StudentAssingmentEditorComment.PlaceholderText = "New Comment";
            StudentAssingmentEditorComment.Size = new Size(477, 31);
            StudentAssingmentEditorComment.TabIndex = 7;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Location = new Point(286, 98);
            label13.Name = "label13";
            label13.Size = new Size(99, 25);
            label13.TabIndex = 6;
            label13.Text = "Comments";
            // 
            // StudentAssingmentEditorComments
            // 
            StudentAssingmentEditorComments.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorComments.FormattingEnabled = true;
            StudentAssingmentEditorComments.ItemHeight = 25;
            StudentAssingmentEditorComments.Location = new Point(285, 126);
            StudentAssingmentEditorComments.Name = "StudentAssingmentEditorComments";
            StudentAssingmentEditorComments.Size = new Size(478, 129);
            StudentAssingmentEditorComments.TabIndex = 5;
            // 
            // StudentAssingmentEditorTotalPoints
            // 
            StudentAssingmentEditorTotalPoints.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorTotalPoints.Location = new Point(643, 49);
            StudentAssingmentEditorTotalPoints.Name = "StudentAssingmentEditorTotalPoints";
            StudentAssingmentEditorTotalPoints.ReadOnly = true;
            StudentAssingmentEditorTotalPoints.Size = new Size(150, 31);
            StudentAssingmentEditorTotalPoints.TabIndex = 4;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(531, 49);
            label12.Name = "label12";
            label12.Size = new Size(106, 25);
            label12.TabIndex = 3;
            label12.Text = "Total Points:";
            // 
            // StudentAssingmentEditorPointsScored
            // 
            StudentAssingmentEditorPointsScored.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorPointsScored.Location = new Point(368, 49);
            StudentAssingmentEditorPointsScored.Name = "StudentAssingmentEditorPointsScored";
            StudentAssingmentEditorPointsScored.ReadOnly = true;
            StudentAssingmentEditorPointsScored.Size = new Size(150, 31);
            StudentAssingmentEditorPointsScored.TabIndex = 2;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(244, 49);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 1;
            label11.Text = "Points scored:";
            // 
            // StudentAssingmentEditorCourseName
            // 
            StudentAssingmentEditorCourseName.Anchor = AnchorStyles.Top;
            StudentAssingmentEditorCourseName.AutoSize = true;
            StudentAssingmentEditorCourseName.Location = new Point(433, 16);
            StudentAssingmentEditorCourseName.Name = "StudentAssingmentEditorCourseName";
            StudentAssingmentEditorCourseName.Size = new Size(176, 25);
            StudentAssingmentEditorCourseName.TabIndex = 0;
            StudentAssingmentEditorCourseName.Text = "<assingment name>";
            // 
            // TeacherAssignmentEditor
            // 
            TeacherAssignmentEditor.Controls.Add(AddCoursePanel);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorSave);
            TeacherAssignmentEditor.Controls.Add(TeacherAssingmentEditorNewComment);
            TeacherAssignmentEditor.Controls.Add(TeacherAssingmentEditorComments);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorTotalPoints);
            TeacherAssignmentEditor.Controls.Add(label9);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorPointsScored);
            TeacherAssignmentEditor.Controls.Add(label8);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorAssignmentName);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorStudentName);
            TeacherAssignmentEditor.Dock = DockStyle.Fill;
            TeacherAssignmentEditor.Location = new Point(0, 0);
            TeacherAssignmentEditor.Name = "TeacherAssignmentEditor";
            TeacherAssignmentEditor.Size = new Size(1091, 667);
            TeacherAssignmentEditor.TabIndex = 1;
            // 
            // TeacherAssignmentEditorSave
            // 
            TeacherAssignmentEditorSave.Anchor = AnchorStyles.Top;
            TeacherAssignmentEditorSave.Location = new Point(429, 317);
            TeacherAssignmentEditorSave.Name = "TeacherAssignmentEditorSave";
            TeacherAssignmentEditorSave.Size = new Size(155, 34);
            TeacherAssignmentEditorSave.TabIndex = 8;
            TeacherAssignmentEditorSave.Text = "Save and Back";
            TeacherAssignmentEditorSave.UseVisualStyleBackColor = true;
            TeacherAssignmentEditorSave.Click += TeacherAssignmentEditorSave_Click;
            // 
            // TeacherAssingmentEditorNewComment
            // 
            TeacherAssingmentEditorNewComment.Anchor = AnchorStyles.Top;
            TeacherAssingmentEditorNewComment.Location = new Point(285, 257);
            TeacherAssingmentEditorNewComment.Name = "TeacherAssingmentEditorNewComment";
            TeacherAssingmentEditorNewComment.PlaceholderText = "New comment";
            TeacherAssingmentEditorNewComment.Size = new Size(491, 31);
            TeacherAssingmentEditorNewComment.TabIndex = 7;
            // 
            // TeacherAssingmentEditorComments
            // 
            TeacherAssingmentEditorComments.Anchor = AnchorStyles.Top;
            TeacherAssingmentEditorComments.FormattingEnabled = true;
            TeacherAssingmentEditorComments.ItemHeight = 25;
            TeacherAssingmentEditorComments.Location = new Point(285, 138);
            TeacherAssingmentEditorComments.Name = "TeacherAssingmentEditorComments";
            TeacherAssingmentEditorComments.Size = new Size(491, 104);
            TeacherAssingmentEditorComments.TabIndex = 6;
            // 
            // TeacherAssignmentEditorTotalPoints
            // 
            TeacherAssignmentEditorTotalPoints.Anchor = AnchorStyles.Top;
            TeacherAssignmentEditorTotalPoints.Location = new Point(664, 78);
            TeacherAssignmentEditorTotalPoints.Name = "TeacherAssignmentEditorTotalPoints";
            TeacherAssignmentEditorTotalPoints.Size = new Size(150, 31);
            TeacherAssignmentEditorTotalPoints.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(551, 78);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 4;
            label9.Text = "Total Points";
            // 
            // TeacherAssignmentEditorPointsScored
            // 
            TeacherAssignmentEditorPointsScored.Anchor = AnchorStyles.Top;
            TeacherAssignmentEditorPointsScored.Location = new Point(386, 75);
            TeacherAssignmentEditorPointsScored.Name = "TeacherAssignmentEditorPointsScored";
            TeacherAssignmentEditorPointsScored.Size = new Size(150, 31);
            TeacherAssignmentEditorPointsScored.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(256, 75);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 2;
            label8.Text = "Points Scored:";
            // 
            // TeacherAssignmentEditorAssignmentName
            // 
            TeacherAssignmentEditorAssignmentName.Anchor = AnchorStyles.Top;
            TeacherAssignmentEditorAssignmentName.AutoSize = true;
            TeacherAssignmentEditorAssignmentName.Location = new Point(519, 16);
            TeacherAssignmentEditorAssignmentName.Name = "TeacherAssignmentEditorAssignmentName";
            TeacherAssignmentEditorAssignmentName.Size = new Size(176, 25);
            TeacherAssignmentEditorAssignmentName.TabIndex = 1;
            TeacherAssignmentEditorAssignmentName.Text = "<assignment name>";
            // 
            // TeacherAssignmentEditorStudentName
            // 
            TeacherAssignmentEditorStudentName.Anchor = AnchorStyles.Top;
            TeacherAssignmentEditorStudentName.AutoSize = true;
            TeacherAssignmentEditorStudentName.Location = new Point(261, 16);
            TeacherAssignmentEditorStudentName.Name = "TeacherAssignmentEditorStudentName";
            TeacherAssignmentEditorStudentName.Size = new Size(149, 25);
            TeacherAssignmentEditorStudentName.TabIndex = 0;
            TeacherAssignmentEditorStudentName.Text = "<Student Name>";
            // 
            // courseList
            // 
            courseList.Controls.Add(CreateCourseButton);
            courseList.Controls.Add(CourseListBackButton);
            courseList.Controls.Add(CourselistBox);
            courseList.Controls.Add(label3);
            courseList.Controls.Add(TeacherAssignmentEditor);
            courseList.Controls.Add(StudentAssingmentEditor);
            courseList.Dock = DockStyle.Fill;
            courseList.Location = new Point(0, 0);
            courseList.Name = "courseList";
            courseList.Size = new Size(1091, 667);
            courseList.TabIndex = 1;
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Anchor = AnchorStyles.Top;
            CreateCourseButton.Location = new Point(489, 294);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(135, 34);
            CreateCourseButton.TabIndex = 4;
            CreateCourseButton.Text = "Create Course";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // CourseListBackButton
            // 
            CourseListBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CourseListBackButton.Location = new Point(967, 7);
            CourseListBackButton.Name = "CourseListBackButton";
            CourseListBackButton.Size = new Size(112, 34);
            CourseListBackButton.TabIndex = 3;
            CourseListBackButton.Text = "Back";
            CourseListBackButton.UseVisualStyleBackColor = true;
            CourseListBackButton.Click += CourseListBackButton_Click;
            // 
            // CourselistBox
            // 
            CourselistBox.Anchor = AnchorStyles.Top;
            CourselistBox.FormattingEnabled = true;
            CourselistBox.ItemHeight = 25;
            CourselistBox.Location = new Point(324, 59);
            CourselistBox.Name = "CourselistBox";
            CourselistBox.Size = new Size(470, 229);
            CourselistBox.TabIndex = 1;
            CourselistBox.SelectedIndexChanged += CourselistBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(528, 12);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 0;
            label3.Text = "Courses";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 667);
            Controls.Add(courseList);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Login.ResumeLayout(false);
            Login.PerformLayout();
            CourseDisplay.ResumeLayout(false);
            CourseDisplay.PerformLayout();
            CreateAssignmentPanel.ResumeLayout(false);
            CreateAssignmentPanel.PerformLayout();
            CreateAccountpanel.ResumeLayout(false);
            CreateAccountpanel.PerformLayout();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            StudentCourseDisplay.ResumeLayout(false);
            StudentCourseDisplay.PerformLayout();
            TeacherViewOfStudent.ResumeLayout(false);
            TeacherViewOfStudent.PerformLayout();
            AddCoursePanel.ResumeLayout(false);
            AddCoursePanel.PerformLayout();
            StudentAssingmentEditor.ResumeLayout(false);
            StudentAssingmentEditor.PerformLayout();
            TeacherAssignmentEditor.ResumeLayout(false);
            TeacherAssignmentEditor.PerformLayout();
            courseList.ResumeLayout(false);
            courseList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Login;
        private TextBox Username;
        private Label label1;
        private TextBox Password;
        private Panel Menu;
        private Button courses;
        private Label label2;
        private Button Loginbutton;
        private Panel courseList;
        private Label label3;
        private Label LoginError;
        private ListBox CourselistBox;
        private Panel CourseDisplay;
        private Label CourseNameLabel;
        private ListBox StudentListBox;
        private Label label5;
        private ListBox AssignmentList;
        private Label AssignCourse;
        private Button TeacherCourseDetailsBackButton;
        private Button CourseListBackButton;
        private Button MenuBackButton;
        private Panel StudentCourseDisplay;
        private Label CourseNameLableStudent;
        private Button StudentCourseDisplayBackButton;
        private Label label6;
        private ListBox AssignmentListBoxStudent;
        private Panel TeacherViewOfStudent;
        private Label label7;
        private ListBox TeacherViewStudentAssignmentsList;
        private Label StudentNameLabel;
        private Button TeacherViewOfStudentBackButton;
        private Panel TeacherAssignmentEditor;
        private Label TeacherAssignmentEditorAssignmentName;
        private Label TeacherAssignmentEditorStudentName;
        private TextBox TeacherAssignmentEditorTotalPoints;
        private Label label9;
        private TextBox TeacherAssignmentEditorPointsScored;
        private Label label8;
        private Button TeacherAssignmentEditorSave;
        private TextBox TeacherAssingmentEditorNewComment;
        private ListBox TeacherAssingmentEditorComments;
        private Panel StudentAssingmentEditor;
        private Label label11;
        private Label StudentAssingmentEditorCourseName;
        private TextBox StudentAssingmentEditorPointsScored;
        private ListBox StudentAssingmentEditorComments;
        private TextBox StudentAssingmentEditorTotalPoints;
        private Label label12;
        private Button StudentAssingmentEditorBack;
        private TextBox StudentAssingmentEditorComment;
        private Label label13;
        private Button CreateAccountBuuton;
        private Panel CreateAccountpanel;
        private TextBox CreateAccountPassword;
        private TextBox CreateAccountUserName;
        private Button CreateAccountCreate;
        private ComboBox UserTypeDropDown;
        private Button CreateCourseButton;
        private Panel AddCoursePanel;
        private Button AddCourseButton;
        private TextBox NewCourseNameTextBox;
        private ComboBox StudentSelectDropDown;
        private Button AddSelectedStudentButton;
        private Button CreateAssignmentSitchButton;
        private Panel CreateAssignmentPanel;
        private Button CreateAssignmentButton;
        private TextBox MaxPointsTextBox;
        private TextBox AssignmentTitleTextBox;
        private Label label4;
        private TextBox CourseGradeTextBox;
        private Label label10;
        private TextBox GPATextBox;
    }
}