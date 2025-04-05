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
            TeacherViewOfStudent = new Panel();
            TeacherViewOfStudentBackButton = new Button();
            label7 = new Label();
            TeacherViewStudentAssignmentsList = new ListBox();
            StudentNameLabel = new Label();
            LoginError = new Label();
            CourseDisplay = new Panel();
            TeacherCourseDetailsBackButton = new Button();
            AssignCourse = new Label();
            AssignmentList = new ListBox();
            label5 = new Label();
            StudentListBox = new ListBox();
            CourseNameLabel = new Label();
            Menu = new Panel();
            StudentCourseDisplay = new Panel();
            StudentCourseDisplayBackButton = new Button();
            label6 = new Label();
            AssignmentListBoxStudent = new ListBox();
            CourseNameLableStudent = new Label();
            MenuBackButton = new Button();
            courseList = new Panel();
            CourseListBackButton = new Button();
            label4 = new Label();
            CourselistBox = new ListBox();
            label3 = new Label();
            courses = new Button();
            label2 = new Label();
            Loginbutton = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            TeacherAssignmentEditor = new Panel();
            TeacherAssignmentEditorSave = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            TeacherAssignmentEditorTotalPoints = new TextBox();
            label9 = new Label();
            TeacherAssignmentEditorPointsScored = new TextBox();
            label8 = new Label();
            TeacherAssignmentEditorAssignmentName = new Label();
            TeacherAssignmentEditorStudentName = new Label();
            Login.SuspendLayout();
            TeacherViewOfStudent.SuspendLayout();
            CourseDisplay.SuspendLayout();
            Menu.SuspendLayout();
            StudentCourseDisplay.SuspendLayout();
            courseList.SuspendLayout();
            TeacherAssignmentEditor.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Controls.Add(TeacherViewOfStudent);
            Login.Controls.Add(LoginError);
            Login.Controls.Add(CourseDisplay);
            Login.Controls.Add(Menu);
            Login.Controls.Add(Loginbutton);
            Login.Controls.Add(Password);
            Login.Controls.Add(Username);
            Login.Controls.Add(label1);
            Login.Location = new Point(1, 2);
            Login.Name = "Login";
            Login.Size = new Size(651, 357);
            Login.TabIndex = 0;
            // 
            // TeacherViewOfStudent
            // 
            TeacherViewOfStudent.Controls.Add(TeacherViewOfStudentBackButton);
            TeacherViewOfStudent.Controls.Add(label7);
            TeacherViewOfStudent.Controls.Add(TeacherViewStudentAssignmentsList);
            TeacherViewOfStudent.Controls.Add(StudentNameLabel);
            TeacherViewOfStudent.Location = new Point(11, 3);
            TeacherViewOfStudent.Name = "TeacherViewOfStudent";
            TeacherViewOfStudent.Size = new Size(657, 349);
            TeacherViewOfStudent.TabIndex = 1;
            // 
            // TeacherViewOfStudentBackButton
            // 
            TeacherViewOfStudentBackButton.Location = new Point(511, 42);
            TeacherViewOfStudentBackButton.Name = "TeacherViewOfStudentBackButton";
            TeacherViewOfStudentBackButton.Size = new Size(112, 34);
            TeacherViewOfStudentBackButton.TabIndex = 3;
            TeacherViewOfStudentBackButton.Text = "Back";
            TeacherViewOfStudentBackButton.UseVisualStyleBackColor = true;
            TeacherViewOfStudentBackButton.Click += TeacherViewOfStudentBackButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 64);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 2;
            label7.Text = "Assignments";
            // 
            // TeacherViewStudentAssignmentsList
            // 
            TeacherViewStudentAssignmentsList.FormattingEnabled = true;
            TeacherViewStudentAssignmentsList.ItemHeight = 25;
            TeacherViewStudentAssignmentsList.Location = new Point(83, 92);
            TeacherViewStudentAssignmentsList.Name = "TeacherViewStudentAssignmentsList";
            TeacherViewStudentAssignmentsList.Size = new Size(478, 254);
            TeacherViewStudentAssignmentsList.TabIndex = 1;
            TeacherViewStudentAssignmentsList.SelectedIndexChanged += TeacherViewStudentAssignmentsList_SelectedIndexChanged;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(50, 20);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(146, 25);
            StudentNameLabel.TabIndex = 0;
            StudentNameLabel.Text = "<Student name>";
            StudentNameLabel.Click += StudentNameLabel_Click;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.Location = new Point(289, 147);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 25);
            LoginError.TabIndex = 4;
            // 
            // CourseDisplay
            // 
            CourseDisplay.Controls.Add(TeacherCourseDetailsBackButton);
            CourseDisplay.Controls.Add(AssignCourse);
            CourseDisplay.Controls.Add(AssignmentList);
            CourseDisplay.Controls.Add(label5);
            CourseDisplay.Controls.Add(StudentListBox);
            CourseDisplay.Controls.Add(CourseNameLabel);
            CourseDisplay.Location = new Point(11, 3);
            CourseDisplay.Name = "CourseDisplay";
            CourseDisplay.Size = new Size(663, 383);
            CourseDisplay.TabIndex = 1;
            // 
            // TeacherCourseDetailsBackButton
            // 
            TeacherCourseDetailsBackButton.Location = new Point(499, 24);
            TeacherCourseDetailsBackButton.Name = "TeacherCourseDetailsBackButton";
            TeacherCourseDetailsBackButton.Size = new Size(112, 34);
            TeacherCourseDetailsBackButton.TabIndex = 5;
            TeacherCourseDetailsBackButton.Text = "Back";
            TeacherCourseDetailsBackButton.UseVisualStyleBackColor = true;
            TeacherCourseDetailsBackButton.Click += TeacherCourseDetailsBackButton_Click;
            // 
            // AssignCourse
            // 
            AssignCourse.AutoSize = true;
            AssignCourse.Location = new Point(96, 193);
            AssignCourse.Margin = new Padding(4, 0, 4, 0);
            AssignCourse.Name = "AssignCourse";
            AssignCourse.Size = new Size(193, 25);
            AssignCourse.TabIndex = 4;
            AssignCourse.Text = "Assignments in Course";
            // 
            // AssignmentList
            // 
            AssignmentList.FormattingEnabled = true;
            AssignmentList.ItemHeight = 25;
            AssignmentList.Location = new Point(86, 232);
            AssignmentList.Margin = new Padding(4, 5, 4, 5);
            AssignmentList.Name = "AssignmentList";
            AssignmentList.Size = new Size(455, 154);
            AssignmentList.TabIndex = 3;
            AssignmentList.SelectedIndexChanged += AssignmentList_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 33);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 2;
            label5.Text = "Students in Course";
            // 
            // StudentListBox
            // 
            StudentListBox.FormattingEnabled = true;
            StudentListBox.ItemHeight = 25;
            StudentListBox.Location = new Point(86, 70);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(455, 104);
            StudentListBox.TabIndex = 1;
            StudentListBox.SelectedIndexChanged += StudentListBox_SelectedIndexChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Location = new Point(34, 8);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(137, 25);
            CourseNameLabel.TabIndex = 0;
            CourseNameLabel.Text = "<course name>";
            // 
            // Menu
            // 
            Menu.Controls.Add(StudentCourseDisplay);
            Menu.Controls.Add(MenuBackButton);
            Menu.Controls.Add(courseList);
            Menu.Controls.Add(courses);
            Menu.Controls.Add(label2);
            Menu.Location = new Point(3, 7);
            Menu.Name = "Menu";
            Menu.Size = new Size(649, 353);
            Menu.TabIndex = 1;
            // 
            // StudentCourseDisplay
            // 
            StudentCourseDisplay.Controls.Add(StudentCourseDisplayBackButton);
            StudentCourseDisplay.Controls.Add(label6);
            StudentCourseDisplay.Controls.Add(AssignmentListBoxStudent);
            StudentCourseDisplay.Controls.Add(CourseNameLableStudent);
            StudentCourseDisplay.Location = new Point(5, 0);
            StudentCourseDisplay.Name = "StudentCourseDisplay";
            StudentCourseDisplay.Size = new Size(644, 393);
            StudentCourseDisplay.TabIndex = 1;
            // 
            // StudentCourseDisplayBackButton
            // 
            StudentCourseDisplayBackButton.Location = new Point(490, 44);
            StudentCourseDisplayBackButton.Name = "StudentCourseDisplayBackButton";
            StudentCourseDisplayBackButton.Size = new Size(112, 34);
            StudentCourseDisplayBackButton.TabIndex = 3;
            StudentCourseDisplayBackButton.Text = "Back";
            StudentCourseDisplayBackButton.UseVisualStyleBackColor = true;
            StudentCourseDisplayBackButton.Click += StudentCourseDisplayBackButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 73);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 2;
            label6.Text = "Assignments";
            // 
            // AssignmentListBoxStudent
            // 
            AssignmentListBoxStudent.FormattingEnabled = true;
            AssignmentListBoxStudent.ItemHeight = 25;
            AssignmentListBoxStudent.Location = new Point(89, 109);
            AssignmentListBoxStudent.Name = "AssignmentListBoxStudent";
            AssignmentListBoxStudent.Size = new Size(455, 204);
            AssignmentListBoxStudent.TabIndex = 1;
            // 
            // CourseNameLableStudent
            // 
            CourseNameLableStudent.AutoSize = true;
            CourseNameLableStudent.Location = new Point(37, 28);
            CourseNameLableStudent.Name = "CourseNameLableStudent";
            CourseNameLableStudent.Size = new Size(143, 25);
            CourseNameLableStudent.TabIndex = 0;
            CourseNameLableStudent.Text = "<Course Name>";
            // 
            // MenuBackButton
            // 
            MenuBackButton.Location = new Point(533, 12);
            MenuBackButton.Name = "MenuBackButton";
            MenuBackButton.Size = new Size(112, 34);
            MenuBackButton.TabIndex = 2;
            MenuBackButton.Text = "Back";
            MenuBackButton.UseVisualStyleBackColor = true;
            MenuBackButton.Click += MenuBackButton_Click;
            // 
            // courseList
            // 
            courseList.Controls.Add(CourseListBackButton);
            courseList.Controls.Add(label4);
            courseList.Controls.Add(CourselistBox);
            courseList.Controls.Add(label3);
            courseList.Location = new Point(5, 3);
            courseList.Name = "courseList";
            courseList.Size = new Size(643, 353);
            courseList.TabIndex = 1;
            // 
            // CourseListBackButton
            // 
            CourseListBackButton.Location = new Point(512, 12);
            CourseListBackButton.Name = "CourseListBackButton";
            CourseListBackButton.Size = new Size(112, 34);
            CourseListBackButton.TabIndex = 3;
            CourseListBackButton.Text = "Back";
            CourseListBackButton.UseVisualStyleBackColor = true;
            CourseListBackButton.Click += CourseListBackButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 293);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // CourselistBox
            // 
            CourselistBox.FormattingEnabled = true;
            CourselistBox.ItemHeight = 25;
            CourselistBox.Location = new Point(101, 52);
            CourselistBox.Name = "CourselistBox";
            CourselistBox.Size = new Size(470, 229);
            CourselistBox.TabIndex = 1;
            CourselistBox.SelectedIndexChanged += CourselistBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 12);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 0;
            label3.Text = "Courses";
            // 
            // courses
            // 
            courses.Location = new Point(266, 48);
            courses.Name = "courses";
            courses.Size = new Size(111, 33);
            courses.TabIndex = 1;
            courses.Text = "Courses";
            courses.UseVisualStyleBackColor = true;
            courses.Click += courses_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            // 
            // Loginbutton
            // 
            Loginbutton.Location = new Point(264, 175);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(111, 33);
            Loginbutton.TabIndex = 3;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Password
            // 
            Password.Location = new Point(249, 98);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(150, 31);
            Password.TabIndex = 2;
            // 
            // Username
            // 
            Username.Location = new Point(249, 47);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(150, 31);
            Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 7);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // TeacherAssignmentEditor
            // 
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorSave);
            TeacherAssignmentEditor.Controls.Add(textBox1);
            TeacherAssignmentEditor.Controls.Add(listBox1);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorTotalPoints);
            TeacherAssignmentEditor.Controls.Add(label9);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorPointsScored);
            TeacherAssignmentEditor.Controls.Add(label8);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorAssignmentName);
            TeacherAssignmentEditor.Controls.Add(TeacherAssignmentEditorStudentName);
            TeacherAssignmentEditor.Location = new Point(12, 371);
            TeacherAssignmentEditor.Name = "TeacherAssignmentEditor";
            TeacherAssignmentEditor.Size = new Size(660, 371);
            TeacherAssignmentEditor.TabIndex = 1;
            // 
            // TeacherAssignmentEditorSave
            // 
            TeacherAssignmentEditorSave.Location = new Point(214, 317);
            TeacherAssignmentEditorSave.Name = "TeacherAssignmentEditorSave";
            TeacherAssignmentEditorSave.Size = new Size(155, 34);
            TeacherAssignmentEditorSave.TabIndex = 8;
            TeacherAssignmentEditorSave.Text = "Save and Back";
            TeacherAssignmentEditorSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 257);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "New comment";
            textBox1.Size = new Size(491, 31);
            textBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(70, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(491, 104);
            listBox1.TabIndex = 6;
            // 
            // TeacherAssignmentEditorTotalPoints
            // 
            TeacherAssignmentEditorTotalPoints.Location = new Point(449, 78);
            TeacherAssignmentEditorTotalPoints.Name = "TeacherAssignmentEditorTotalPoints";
            TeacherAssignmentEditorTotalPoints.Size = new Size(150, 31);
            TeacherAssignmentEditorTotalPoints.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 78);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 4;
            label9.Text = "Total Points";
            // 
            // TeacherAssignmentEditorPointsScored
            // 
            TeacherAssignmentEditorPointsScored.Location = new Point(171, 75);
            TeacherAssignmentEditorPointsScored.Name = "TeacherAssignmentEditorPointsScored";
            TeacherAssignmentEditorPointsScored.Size = new Size(150, 31);
            TeacherAssignmentEditorPointsScored.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 75);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 2;
            label8.Text = "Points Scored:";
            // 
            // TeacherAssignmentEditorAssignmentName
            // 
            TeacherAssignmentEditorAssignmentName.AutoSize = true;
            TeacherAssignmentEditorAssignmentName.Location = new Point(304, 16);
            TeacherAssignmentEditorAssignmentName.Name = "TeacherAssignmentEditorAssignmentName";
            TeacherAssignmentEditorAssignmentName.Size = new Size(176, 25);
            TeacherAssignmentEditorAssignmentName.TabIndex = 1;
            TeacherAssignmentEditorAssignmentName.Text = "<assignment name>";
            // 
            // TeacherAssignmentEditorStudentName
            // 
            TeacherAssignmentEditorStudentName.AutoSize = true;
            TeacherAssignmentEditorStudentName.Location = new Point(46, 16);
            TeacherAssignmentEditorStudentName.Name = "TeacherAssignmentEditorStudentName";
            TeacherAssignmentEditorStudentName.Size = new Size(149, 25);
            TeacherAssignmentEditorStudentName.TabIndex = 0;
            TeacherAssignmentEditorStudentName.Text = "<Student Name>";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 885);
            Controls.Add(TeacherAssignmentEditor);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            TeacherViewOfStudent.ResumeLayout(false);
            TeacherViewOfStudent.PerformLayout();
            CourseDisplay.ResumeLayout(false);
            CourseDisplay.PerformLayout();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            StudentCourseDisplay.ResumeLayout(false);
            StudentCourseDisplay.PerformLayout();
            courseList.ResumeLayout(false);
            courseList.PerformLayout();
            TeacherAssignmentEditor.ResumeLayout(false);
            TeacherAssignmentEditor.PerformLayout();
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
        private Label label4;
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
        private TextBox textBox1;
        private ListBox listBox1;
    }
}