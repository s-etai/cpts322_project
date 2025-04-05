using GradeTracker_Test;

public class Wrapper
{
    public void initTeachers(Dictionary<string, User> userList)
    {
        userList["eli"] = new Teacher("eli", "123");
        userList["elliott"] = (new Teacher("elliott", "456"));
        userList["jace"] = new Student("jace", "123");
        userList["stockton"] = new Student("stockton", "123"); 
    }

}