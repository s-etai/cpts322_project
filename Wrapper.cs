public class Wrapper
{
    public static void Run()
    {
        if (Login())
        {
            Menu();
        }
        Teacher teachtest = new Teacher("test", "password");
        teachtest.CreateAssignment(1234, 17, 3, 10, "Test Assignment to test the create assignment function", "Test Assignment");
    }
        public static void InitCourses(List<Course> courses)
    {
        using (StreamReader courseFile = new StreamReader("Courses.txt"))
        {
            string line;
            while ((line = courseFile.ReadLine()) != null)
            {
                var courseDetails = line.Split(',');
                string courseName = courseDetails[0];
                int courseID = int.Parse(courseDetails[1]);
                courses.Add(new Course(courseName, courseID));
            }
        }
    }

    public static void ViewCourses(List<Course> courses)
    {
        foreach (var course in courses)
        {
            Console.WriteLine($"Course Name: {course.GetName()}, Course ID: {course.GetID()}");
        }
    }

    public static void PrintMainMenu()
    {
        Console.WriteLine("1. Pick course");
        Console.WriteLine("2. Add course");
        Console.WriteLine("3. View calendar");
        Console.WriteLine("4. Notifications");
        Console.WriteLine("5. Exit");
    }

    public static bool Login()
    {
        Console.Clear();
        List<User> userList = new List<User>
        {
            new User("Eli", "1234"),
            new User("Elliot", "5623"),
            new User("Jace", "1893"),
            new User("Stockton", "9897")
        };

        string username, password;
        Console.WriteLine("LOGIN");
        Console.Write("Enter username: ");
        username = Console.ReadLine();
        Console.Write("Enter password: ");
        password = Console.ReadLine();

        bool valid = false;
        int i = 0;
        int length = userList.Count;

        while (i < length)
        {
            if (username == userList[i].Username && password == userList[i].Password)
            {
                valid = true;
                break;
            }
            i++;
        }

        while (!valid)
        {
            Console.Clear();
            Console.WriteLine("Incorrect username or password");
            Console.WriteLine("\nLOGIN");
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            i = 0;
            while (i < length)
            {
                if (username == userList[i].Username && password == userList[i].Password)
                {
                    valid = true;
                    break;
                }
                i++;
            }
        }

        Console.WriteLine("Login Successful");
        return true;
    }

    public static void Menu()
    {
        int menuSelection = -1;

        while (menuSelection != 5)
        {
            PrintMainMenu();
            menuSelection = int.Parse(Console.ReadLine());

            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine("Not implemented yet, (print list of courses)");
                    break;
                case 2:
                    Console.WriteLine("Not implemented yet, (Add course)");
                    break;
                case 3:
                    Console.WriteLine("Not implemented yet, (display calendar)");
                    break;
                case 4:
                    Console.WriteLine("Not implemented yet, (show notifications)");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

        Console.WriteLine();
    }
}