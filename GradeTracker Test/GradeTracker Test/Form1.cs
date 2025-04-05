using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GradeTracker_Test
{
    public partial class Form1 : Form
    {
        Dictionary<string, User> userList = new Dictionary<string, User>();
        User currentUser;
        Course currentCourse;
        Wrapper program = new Wrapper();

        public Form1()
        {

            init_panels();

            ///test teachers
            program.initTeachers(userList);

            List<Student> testStudents = new List<Student>();
            testStudents.Add((Student)userList["jace"]);
            testStudents.Add((Student)userList["stockton"]);

            //test assignments
            Assignment check1 = new Assignment("GradeTracker", 100);
            Assignment check2 = new Assignment("Sprint2", 50);


            List<Assignment> testAssignments = new List<Assignment>();
            testAssignments.Add((Assignment)check1);
            testAssignments.Add((Assignment)check2);
            Course test1 = new Course("math", testStudents, testAssignments);
            Course test2 = new Course("art", testStudents, testAssignments);


            userList["elliott"].Courses["math"] = test1;
            userList["elliott"].Courses["art"] = test2;



        }



        private void courses_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            courseList.Visible = true;
        }



        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //Login verification. switch to menu.
            bool userFound = false;
            foreach (var user in userList)
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CourseSelection()
        {

            CourselistBox.Items.Clear();
            CourselistBox.Items.AddRange(currentUser.Courses.Keys.ToArray());

        }

        private void CourselistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCourse = currentUser.Courses[CourselistBox.SelectedItem.ToString()];
            courseList.Visible = false;
            CourseDisplay.Visible = true;
            CourseNameLabel.Text = currentCourse.CourseName;

            StudentListBox.Items.Clear();
            StudentListBox.Items.AddRange(currentCourse.Students.Select(student => student.Username).ToArray());

            AssignmentList.Items.Clear();
            AssignmentList.Items.AddRange(currentCourse.Assignments.Select(assignment => assignment.Title).ToArray());
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
    }
}