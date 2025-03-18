#include <iostream>
#include <chrono>
using namespace std;


//forward declarations
class Teacher;
class Student;

class Assignment {
public:
    Assignment();
private:
    //assignment details
    int courseID;
    int month;
    int day;
    int fullPoints;
    string description;
};


//node for a singly linked list
struct Grade {
    Assignment* homework;
    int score;
};

class Course {
public:
    Course(int id, const string &course_name)
        : ID(id),courseName(course_name){}

private:
    Course(int courseID, string courseName);
private:
    //array of pointers to each student
    vector<Student> studentList;
    vector<Assignment> assignmentList;
    //pointer to the course teacher
    Teacher* courseTeacher;
public:
    //course id
    int ID;
    string courseName;
};



//base class from which teachers and students inherit from
class User {
    
private:
    int username;
    int password;

    //array of pointers to each course //max 18 courses
    vector<Course> courseList;

};

//derived class from user
class Teacher : public User {

public:

    int editAssignment(int assignmentID);
    void gradeAssignment(int assignmentID);
    int addStudent(int courseID);
    int removeStudent(int courseID);

};

//derived class from user
class Student : public User {

protected:
    // An array of linked lists for the grades
        // Each element corresponds to a linked list for a course
    vector<Grade> gradeList;
public:

    void displayGPA();
    void displayAssignments(int status);

};

int menu();
void displayLogin();
int validate(string username, string password);