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
            LoginError = new Label();
            Menu = new Panel();
            courseList = new Panel();
            CourseDisplay = new Panel();
            label5 = new Label();
            StudentListBox = new ListBox();
            CourseNameLabel = new Label();
            label4 = new Label();
            CourselistBox = new ListBox();
            label3 = new Label();
            courses = new Button();
            label2 = new Label();
            Loginbutton = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label1 = new Label();
            AssignmentList = new ListBox();
            AssignCourse = new Label();
            Login.SuspendLayout();
            Menu.SuspendLayout();
            courseList.SuspendLayout();
            CourseDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Controls.Add(LoginError);
            Login.Controls.Add(Menu);
            Login.Controls.Add(Loginbutton);
            Login.Controls.Add(Password);
            Login.Controls.Add(Username);
            Login.Controls.Add(label1);
            Login.Location = new Point(1, 1);
            Login.Margin = new Padding(2, 2, 2, 2);
            Login.Name = "Login";
            Login.Size = new Size(456, 214);
            Login.TabIndex = 0;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.Location = new Point(202, 88);
            LoginError.Margin = new Padding(2, 0, 2, 0);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(0, 15);
            LoginError.TabIndex = 4;
            // 
            // Menu
            // 
            Menu.Controls.Add(courseList);
            Menu.Controls.Add(courses);
            Menu.Controls.Add(label2);
            Menu.Location = new Point(2, 4);
            Menu.Margin = new Padding(2, 2, 2, 2);
            Menu.Name = "Menu";
            Menu.Size = new Size(454, 212);
            Menu.TabIndex = 1;
            // 
            // courseList
            // 
            courseList.Controls.Add(CourseDisplay);
            courseList.Controls.Add(label4);
            courseList.Controls.Add(CourselistBox);
            courseList.Controls.Add(label3);
            courseList.Location = new Point(4, 7);
            courseList.Margin = new Padding(2, 2, 2, 2);
            courseList.Name = "courseList";
            courseList.Size = new Size(450, 212);
            courseList.TabIndex = 1;
            // 
            // CourseDisplay
            // 
            CourseDisplay.Controls.Add(AssignCourse);
            CourseDisplay.Controls.Add(AssignmentList);
            CourseDisplay.Controls.Add(label5);
            CourseDisplay.Controls.Add(StudentListBox);
            CourseDisplay.Controls.Add(CourseNameLabel);
            CourseDisplay.Location = new Point(2, 2);
            CourseDisplay.Margin = new Padding(2, 2, 2, 2);
            CourseDisplay.Name = "CourseDisplay";
            CourseDisplay.Size = new Size(464, 230);
            CourseDisplay.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 2;
            label5.Text = "Students in Course";
            // 
            // StudentListBox
            // 
            StudentListBox.FormattingEnabled = true;
            StudentListBox.ItemHeight = 15;
            StudentListBox.Location = new Point(60, 42);
            StudentListBox.Margin = new Padding(2, 2, 2, 2);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(320, 64);
            StudentListBox.TabIndex = 1;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Location = new Point(24, 5);
            CourseNameLabel.Margin = new Padding(2, 0, 2, 0);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(91, 15);
            CourseNameLabel.TabIndex = 0;
            CourseNameLabel.Text = "<course name>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // CourselistBox
            // 
            CourselistBox.FormattingEnabled = true;
            CourselistBox.ItemHeight = 15;
            CourselistBox.Location = new Point(71, 31);
            CourselistBox.Margin = new Padding(2, 2, 2, 2);
            CourselistBox.Name = "CourselistBox";
            CourselistBox.Size = new Size(330, 139);
            CourselistBox.TabIndex = 1;
            CourselistBox.SelectedIndexChanged += CourselistBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 0;
            label3.Text = "Courses";
            // 
            // courses
            // 
            courses.Location = new Point(186, 29);
            courses.Margin = new Padding(2, 2, 2, 2);
            courses.Name = "courses";
            courses.Size = new Size(78, 20);
            courses.TabIndex = 1;
            courses.Text = "Courses";
            courses.UseVisualStyleBackColor = true;
            courses.Click += courses_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            // 
            // Loginbutton
            // 
            Loginbutton.Location = new Point(185, 105);
            Loginbutton.Margin = new Padding(2, 2, 2, 2);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(78, 20);
            Loginbutton.TabIndex = 3;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Password
            // 
            Password.Location = new Point(174, 59);
            Password.Margin = new Padding(2, 2, 2, 2);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(106, 23);
            Password.TabIndex = 2;
            // 
            // Username
            // 
            Username.Location = new Point(174, 28);
            Username.Margin = new Padding(2, 2, 2, 2);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(106, 23);
            Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // AssignmentList
            // 
            AssignmentList.FormattingEnabled = true;
            AssignmentList.ItemHeight = 15;
            AssignmentList.Location = new Point(60, 139);
            AssignmentList.Name = "AssignmentList";
            AssignmentList.Size = new Size(320, 94);
            AssignmentList.TabIndex = 3;
            AssignmentList.SelectedIndexChanged += AssignmentList_SelectedIndexChanged;
            // 
            // AssignCourse
            // 
            AssignCourse.AutoSize = true;
            AssignCourse.Location = new Point(67, 116);
            AssignCourse.Name = "AssignCourse";
            AssignCourse.Size = new Size(128, 15);
            AssignCourse.TabIndex = 4;
            AssignCourse.Text = "Assignments in Course";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 531);
            Controls.Add(Login);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            courseList.ResumeLayout(false);
            courseList.PerformLayout();
            CourseDisplay.ResumeLayout(false);
            CourseDisplay.PerformLayout();
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
    }
}