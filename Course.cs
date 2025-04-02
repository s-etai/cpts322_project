public class Course
{
    public string CourseName { get; set; }
    public int ID { get; set; }
    public Teacher CourseTeacher { get; set; }

    public Course(string courseName, int id)
    {
        CourseName = courseName;
        ID = id;
    }

    public string GetName()
    {
        return CourseName;
    }

    public int GetID()
    {
        return ID;
    }
}

public class Assignment
{
    public int CourseID { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int MaxPoints { get; set; }
    public string Description { get; set; }
    public string AssignmentName { get; set; }
    public int AssignmentID { get; set; }

    public Assignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName)
    {
        CourseID = courseID;
        Day = day;
        Month = month;
        MaxPoints = maxPoints;
        Description = description;
        AssignmentName = assignmentName;
        AssignmentID = 0;
    }
}

public class Grade
{
    public Assignment Homework { get; set; }
    public int Score { get; set; }
}

