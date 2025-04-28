using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Text.Json;
using System.IO;

namespace GradeTracker_Test
{
    public partial class Form1 : Form
    {
        Dictionary<string, User> userDictionary = new Dictionary<string, User>(); // All users of the app, username as key.
        User currentUser; // The user that logged in.
        Course currentCourse; // The course that was selected.
        User studentForGrading; // The student that the teacher is changing the assignments of.
        Assignment studentAssignmentRef; // The assingment in student that holds there grade for the assingment.
        Wrapper program = new Wrapper();

        /// <summary>
        /// Runs when form opens.
        /// </summary>
        public Form1()
        {
            this.LoadTracker(); // load the state of program from "data base" .json file.

            init_panels();


            program.initTeachers(userDictionary); // create sample accounts for demo.

            // Create courses and assignments fro demo.
            List<Student> testStudents = new List<Student>();
            testStudents.Add((Student)userDictionary["jace"]);
            testStudents.Add((Student)userDictionary["stockton"]);

            //test assignments
            Assignment check1 = new Assignment("Final", 100);
            Assignment check2 = new Assignment("Midterm", 50);


            List<Assignment> testAssignments = new List<Assignment>();
            List<Assignment> testAssignments2 = new List<Assignment> { new Assignment("Draw", 10), new Assignment("Paint", 20) };
            testAssignments.Add((Assignment)check1);
            testAssignments.Add((Assignment)check2);
            Course test1 = new Course("math", testStudents, testAssignments);
            Course test2 = new Course("art", testStudents, testAssignments2);


            userDictionary["elliott"].Courses["math"] = test1;
            userDictionary["elliott"].Courses["art"] = test2;



        }

        /// <summary>
        /// Save the state of the program to the "Data base" .json file.
        /// </summary>
        private void SaveTracker()
        {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(exePath, "Users.json");
            string json = JsonSerializer.Serialize(userDictionary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Load from the "data base" .json file.
        /// </summary>
        private void LoadTracker()
        {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(exePath, "Users.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                this.userDictionary = JsonSerializer.Deserialize<Dictionary<string, User>>(json);
            }
            else
            {
                this.userDictionary = new Dictionary<string, User>();
            }
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
            this.Controls.Add(this.AddCoursePanel);
            AddCoursePanel.Visible = false;
            this.Controls.Add(this.CreateAssignmentPanel);
            CreateAssignmentPanel.Visible = false;

            // Init the users type select dropdown.
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

        /// <summary>
        /// When user selects course switch to the correct page depending on the user type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourselistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourselistBox.SelectedIndex != -1)
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
                    PopulateStudentSelectDropDown();

                    // Populate list box of students in course.
                    StudentListBox.Items.Clear();
                    StudentListBox.Items.AddRange(currentCourse.Students.Keys.ToArray());

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
                    CourseGradeTextBox.Text = ((Student)currentUser).CalculateGrade(currentCourse).ToString("F2");
                    GPATextBox.Text = ((Student)currentUser).CalculateGPA().ToString("F3");

                    // Display course name.
                    CourseNameLableStudent.Text = currentCourse.CourseName;

                    // Populate List box.
                    AssignmentListBoxStudent.Items.Clear();
                    AssignmentListBoxStudent.Items.AddRange(currentCourse.Assignments.Keys.ToArray());
                }
            }
            


        }

        private void AssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Back button.
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
            if (StudentListBox.SelectedIndex != -1)
            {
                studentForGrading = userDictionary[StudentListBox.SelectedItem.ToString()];

                //Switch panel
                CourseDisplay.Visible = false;
                TeacherViewOfStudent.Visible = true;

                StudentNameLabel.Text = studentForGrading.Username;

                TeacherViewStudentAssignmentsList.Items.Clear();
                TeacherViewStudentAssignmentsList.Items.AddRange(currentCourse.Assignments.Keys.ToArray());
            }
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
            PopulateStudentSelectDropDown();
        }

        /// <summary>
        /// Teacher grade a students's assingment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherViewStudentAssignmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeacherViewStudentAssignmentsList.SelectedIndex != -1)
            {
                //temparary get student's assingment copy for editing.
                string courseTitle = TeacherViewStudentAssignmentsList.SelectedItem.ToString();

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
            if (AssignmentListBoxStudent.SelectedIndex != -1)
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
            PopulateStudentSelectDropDown();
        }

        // Switch to create account page.
        private void CreateAccountBuuton_Click(object sender, EventArgs e)
        {
            this.Login.Visible = false;
            this.CreateAccountpanel.Visible = true;
        }

        /// <summary>
        /// Create acount with inputs from create account page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAccountCreate_Click(object sender, EventArgs e)
        {
            // Get input.
            string newUsername = this.CreateAccountUserName.Text;
            string newPassword = this.CreateAccountPassword.Text;

            // Add new student or teacher to dict depending on dropdown.
            if (this.UserTypeDropDown.SelectedItem.ToString() == "Student")
            {
                if (!userDictionary.ContainsKey(newUsername))
                {
                    userDictionary[newUsername] = new Student(newUsername, newPassword);

                    // Switch page.
                    CreateAccountpanel.Visible = false;
                    Login.Visible = true;
                }
            }
            else
            {
                if (!userDictionary.ContainsKey(newUsername))
                {
                    userDictionary[newUsername] = new Teacher(newUsername, newPassword);

                    // Switch page.
                    CreateAccountpanel.Visible = false;
                    Login.Visible = true;
                }
            }

        }

        /// <summary>
        /// Switch to create course page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            // Go to the create account interface only if the current user is a teacher.
            if (currentUser.GetType() == typeof(Teacher))
            {
                this.courseList.Visible = false;
                this.AddCoursePanel.Visible = true;
            }
        }

        /// <summary>
        /// Add course to teacher's dict of courses.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            // Get input.
            string newName = NewCourseNameTextBox.Text;

            // Add the course and update ui to match new course dictionary.
            if (!currentUser.Courses.ContainsKey(newName))
            {
                currentUser.Courses[newName] = new Course(newName, new List<Student>(), new List<Assignment>()); // add course.
                this.courseList.Visible = true; // switch page.
                this.AddCoursePanel.Visible = false;
                CourselistBox.Items.Clear(); // update ui.
                CourselistBox.Items.AddRange(currentUser.Courses.Keys.ToArray());
            }
        }

        // Put all the students accounts that exist into the dropdown to select witch student to add.
        public void PopulateStudentSelectDropDown()
        {
            this.StudentSelectDropDown.Items.Clear();
            foreach (var user in userDictionary.Values)
            {
                if (user.GetType() == typeof(Student))
                {
                    this.StudentSelectDropDown.Items.Add(user.Username);
                }
            }
        }

        // Add the student selected in the selection dropdown to the course.
        private void AddSelectedStudentButton_Click(object sender, EventArgs e)
        {
            if (this.StudentSelectDropDown.SelectedItem != null)
            {
                Student student = (Student)userDictionary[this.StudentSelectDropDown.SelectedItem.ToString()];
                currentCourse.addStudent(student);
                StudentListBox.Items.Clear(); // Update ui to match new dict of students.
                StudentListBox.Items.AddRange(currentCourse.Students.Keys.ToArray());
            }
        }

        private void CreateAssignmentSitchButton_Click(object sender, EventArgs e)
        {
            this.CourseDisplay.Visible = false;
            this.CreateAssignmentPanel.Visible = true;
        }

        // Add assignment to the current course from the user input course info.
        private void CreateAssignmentButton_Click(object sender, EventArgs e)
        {
            // Get course info from ui.
            string newTitle = this.AssignmentTitleTextBox.Text;
            string newMaxPoints = this.MaxPointsTextBox.Text;

            // Add to course.
            if (!this.currentCourse.Assignments.ContainsKey(newTitle) && double.TryParse(newMaxPoints, out double Maxpoints))
            {
                currentCourse.addAssignment(new Assignment(newTitle, Maxpoints));
                //switch page.
                this.CourseDisplay.Visible = true;
                this.CreateAssignmentPanel.Visible = false;
                // Populate list box of assingments in course (update).
                AssignmentList.Items.Clear();
                AssignmentList.Items.AddRange(currentCourse.Assignments.Keys.ToArray());
            }
        }

        // Save the state of the program when the form is closed.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveTracker();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}