using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GradeTracker_Test
{
    public partial class Form1 : Form
    {
        Dictionary<string, User> userDictionary = new Dictionary<string, User>();
        User currentUser;
        Course currentCourse;
        User studentForGrading; // The student that the teacher is changing the assignments of.
        Assignment studentAssignmentRef; // The assingment in student that holds there grade for the assingment.
        Wrapper program = new Wrapper();

        public Form1()
        {

            init_panels();

            ///test teachers
            program.initTeachers(userDictionary);

            List<Student> testStudents = new List<Student>();
            testStudents.Add((Student)userDictionary["jace"]);
            testStudents.Add((Student)userDictionary["stockton"]);

            //test assignments
            Assignment check1 = new Assignment("GradeTracker", 100);
            Assignment check2 = new Assignment("Sprint2", 50);


            List<Assignment> testAssignments = new List<Assignment>();
            testAssignments.Add((Assignment)check1);
            testAssignments.Add((Assignment)check2);
            Course test1 = new Course("math", testStudents, testAssignments);
            Course test2 = new Course("art", testStudents, testAssignments);


            userDictionary["elliott"].Courses["math"] = test1;
            userDictionary["elliott"].Courses["art"] = test2;



        }


        /// <summary>
        /// Switch from menu to course list when course button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courses_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            courseList.Visible = true;
        }


        /// <summary>
        /// Check username and password and switch to menu if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //Login verification. switch to menu.
            bool userFound = false;
            foreach (var user in userDictionary)
            {
                if (user.Key == Username.Text)
                {


                    userFound = true;
                    if (user.Value.Password == Password.Text)
                    {
                        Menu.Visible = true;
                        Login.Visible = false;
                        currentUser = user.Value;
                        CourseSelection();
                        break;
                    }
                    else
                    {
                        LoginError.Text = "Incorrect password";
                        break;
                    }
                }
            }
            if (!userFound)
            {
                LoginError.Text = "No username exists";
            }

        }

        private void init_panels()
        {
            // Initialze ui panels
            InitializeComponent();
            this.Controls.Add(this.Login);
            Login.Visible = true;
            this.Controls.Add(this.Menu);
            Menu.Visible = false;
            this.Controls.Add(this.courseList);
            courseList.Visible = false;
            this.Controls.Add(this.CourseDisplay);
            CourseDisplay.Visible = false;
            this.Controls.Add(this.StudentCourseDisplay);
            StudentCourseDisplay.Visible = false;
            this.Controls.Add(this.TeacherViewOfStudent);
            TeacherViewOfStudent.Visible = false;
            this.Controls.Add(this.TeacherAssignmentEditor);
            TeacherAssignmentEditor.Visible = false;
            this.Controls.Add(this.StudentAssingmentEditor);
            StudentAssingmentEditor.Visible = false;
            this.Controls.Add(this.CreateAccountpanel);
            CreateAccountpanel.Visible = false;

            this.UserTypeDropDown.Items.Add("Student");
            this.UserTypeDropDown.Items.Add("Teacher");
            this.UserTypeDropDown.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populate course list box with course names.
        /// </summary>
        public void CourseSelection()
        {

            CourselistBox.Items.Clear();
            CourselistBox.Items.AddRange(currentUser.Courses.Keys.ToArray());

        }

        private void CourselistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set current course to the course selected with the course dictionary in the user object.
            currentCourse = currentUser.Courses[CourselistBox.SelectedItem.ToString()];

            // Differnt page shown depending on user type.
            // Probably should use polymorphism somehow.
            if (currentUser.GetType().Name == "Teacher")
            {
                //following is for teacher. 
                // Switch panels.
                courseList.Visible = false;
                CourseDisplay.Visible = true;
                CourseNameLabel.Text = currentCourse.CourseName;

                // Populate list box of students in course.
                StudentListBox.Items.Clear();
                StudentListBox.Items.AddRange(currentCourse.Students.Select(student => student.Username).ToArray());

                // Populate list box of assingments in course.
                AssignmentList.Items.Clear();
                AssignmentList.Items.AddRange(currentCourse.Assignments.Keys.ToArray());
            }
            else
            {
                // If the user is a student.
                // switch panels.
                courseList.Visible = false;
                StudentCourseDisplay.Visible = true;

                // Display course name.
                CourseNameLableStudent.Text = currentCourse.CourseName;

                // Populate List box.
                AssignmentListBoxStudent.Items.Clear();
                AssignmentListBoxStudent.Items.AddRange(currentCourse.Assignments.Keys.ToArray());
            }


        }

        private void AssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assignment.Visible = false;
            //AssignmentList.Visible = true;
            //CourseNameLabel.Text = currentCourse.CourseName;

            //StudentListBox.Items.Clear();
            //StudentListBox.Items.AddRange(currentCourse.Students.Select(student => student.Username).ToArray());
        }

        private void TeacherCourseDetailsBackButton_Click(object sender, EventArgs e)
        {
            CourseDisplay.Visible = false;
            courseList.Visible = true;
        }

        private void CourseListBackButton_Click(object sender, EventArgs e)
        {
            courseList.Visible = false;
            Menu.Visible = true;
        }

        private void MenuBackButton_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            Login.Visible = true;
        }

        private void StudentCourseDisplayBackButton_Click(object sender, EventArgs e)
        {
            StudentCourseDisplay.Visible = false;
            courseList.Visible = true;
        }

        /// <summary>
        /// When a teacher selects a student, switch to selecting the assingment page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentForGrading = userDictionary[StudentListBox.SelectedItem.ToString()];

            //Switch panel
            CourseDisplay.Visible = false;
            TeacherViewOfStudent.Visible = true;

            StudentNameLabel.Text = studentForGrading.Username;

            TeacherViewStudentAssignmentsList.Items.Clear();
            TeacherViewStudentAssignmentsList.Items.AddRange(currentCourse.Assignments.Keys.ToArray());

        }

        private void StudentNameLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Back from teacher looking at a student to the list of students in the course.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherViewOfStudentBackButton_Click(object sender, EventArgs e)
        {
            TeacherViewOfStudent.Visible = false;
            CourseDisplay.Visible = true;
        }

        /// <summary>
        /// Teacher grade a students's assingment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherViewStudentAssignmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //temparary get student's assingment copy for editing.
            string courseTitle = TeacherViewStudentAssignmentsList.SelectedItem.ToString();

            //Assignment courseAssignmentRef = new Assignment("test", 10); // test 10 never used.
            ////temp get course assignmet ref
            //foreach (var assignment in currentCourse.Assignments)
            //{
            //    if (assignment.Title == courseTitle)
            //    {
            //        courseAssignmentRef = assignment;
            //    }
            //}
            studentAssignmentRef = studentForGrading.GetAssignment(currentCourse.Assignments[courseTitle]);

            //Remove last comment
            TeacherAssingmentEditorNewComment.Text = string.Empty;

            //Display current grades and comments
            TeacherAssignmentEditorPointsScored.Text = studentAssignmentRef.pointsScored.ToString();
            TeacherAssignmentEditorTotalPoints.Text = studentAssignmentRef.FullPoints.ToString();
            TeacherAssignmentEditorAssignmentName.Text = studentAssignmentRef.Title;

            TeacherAssingmentEditorComments.Items.Clear();
            TeacherAssingmentEditorComments.Items.AddRange(studentAssignmentRef.comments.ToArray());


            //swithch panel
            TeacherViewOfStudent.Visible = false;
            TeacherAssignmentEditor.Visible = true;

            TeacherAssignmentEditorStudentName.Text = studentForGrading.Username;

        }

        /// <summary>
        /// Change the student assingment copy to the input values and go back a page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherAssignmentEditorSave_Click(object sender, EventArgs e)
        {
            // Change assignmet values if valid, if not leave them as they were.
            if (double.TryParse(TeacherAssignmentEditorPointsScored.Text, out double pointsScored) && double.TryParse(TeacherAssignmentEditorTotalPoints.Text, out double totalPoints))
            {
                studentAssignmentRef.pointsScored = pointsScored;
                studentAssignmentRef.FullPoints = totalPoints;
            }

            if (TeacherAssingmentEditorNewComment.Text != string.Empty)
            {
                studentAssignmentRef.comments.Add(currentUser.Username + ": " + TeacherAssingmentEditorNewComment.Text);
            }

            //Back
            TeacherAssignmentEditor.Visible = false;
            TeacherViewOfStudent.Visible = true;
        }

        /// <summary>
        /// When student selects a course, they view their grades and comments.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignmentListBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //temparary get student's assingment copy for editing.
            string courseTitle = AssignmentListBoxStudent.SelectedItem.ToString();

            studentAssignmentRef = currentUser.GetAssignment(currentCourse.Assignments[courseTitle]); //Current user is the student.

            // Switch panel
            StudentCourseDisplay.Visible = false;
            StudentAssingmentEditor.Visible = true;

            //Clear new comment input box.
            StudentAssingmentEditorComment.Text = string.Empty;

            //Display grade and comments
            StudentAssingmentEditorPointsScored.Text = studentAssignmentRef.pointsScored.ToString();
            StudentAssingmentEditorTotalPoints.Text = studentAssignmentRef.FullPoints.ToString();
            StudentAssingmentEditorCourseName.Text = studentAssignmentRef.Title;

            StudentAssingmentEditorComments.Items.Clear();
            StudentAssingmentEditorComments.Items.AddRange(studentAssignmentRef.comments.ToArray());

        }

        /// <summary>
        /// Save the student's comment and go back to course display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentAssingmentEditorBack_Click(object sender, EventArgs e)
        {
            // add the comment in the comment input box
            if (StudentAssingmentEditorComment.Text != string.Empty)
            {
                studentAssignmentRef.comments.Add(currentUser.Username + ": " + StudentAssingmentEditorComment.Text);
            }

            // switch back to course display.
            StudentAssingmentEditor.Visible = false;
            StudentCourseDisplay.Visible = true;
        }

        private void CreateAccountBuuton_Click(object sender, EventArgs e)
        {
            this.Login.Visible = false;
            this.CreateAccountpanel.Visible = true;
        }

        /// <summary>
        /// Create acount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAccountCreate_Click(object sender, EventArgs e)
        {
            string newUsername = this.CreateAccountUserName.Text;
            string newPassword = this.CreateAccountPassword.Text;

            // Add new student or teacher to dict depending on dropdown.
            if (this.UserTypeDropDown.SelectedItem.ToString() == "Student")
            {
                if(!userDictionary.ContainsKey(newUsername))
                {
                    userDictionary[newUsername] = new Student(newUsername, newPassword);

                    CreateAccountpanel.Visible = false;
                    Login.Visible = true;
                }
            }
            else
            {
                if (!userDictionary.ContainsKey(newUsername))
                {
                    userDictionary[newUsername] = new Teacher(newUsername, newPassword);

                    CreateAccountpanel.Visible = false;
                    Login.Visible = true;
                }
            }
        }
    }
}