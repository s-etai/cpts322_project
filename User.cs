using System;       
using System.Collections.Generic; 

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Course> CourseList { get; set; }
    public List<Assignment> AssignmentList { get; set; }

    public User()
    {
        Username = string.Empty;
        Password = string.Empty;
        CourseList = new List<Course>();
        AssignmentList = new List<Assignment>();
    }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        CourseList = new List<Course>();
        AssignmentList = new List<Assignment>();
    }
}

public class Teacher : User
{
    public Teacher(string username, string password) : base(username, password) {}

    public void CreateAssignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName)
    {
        AssignmentList.Add(new Assignment(courseID, day, month, maxPoints, description, assignmentName));
        Console.WriteLine("Assignment created!");
    }
}

public class Student : User
{
    public List<Grade> GradeList { get; set; }

    public Student(string username, string password) : base(username, password)
    {
        GradeList = new List<Grade>();
    }

    public void DisplayGPA()
    {
        Console.WriteLine("Displaying GPA...");
    }

    public void DisplayAssignments(int status)
    {
        Console.WriteLine("Displaying assignments with status " + status);
    }
}