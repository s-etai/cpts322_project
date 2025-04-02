#include <iostream>
#include <chrono>
#include <fstream>
#include <vector>

using namespace std;


//forward declarations
class Teacher;
class Student;

class Assignment {
public:
    Assignment();
    Assignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName);
private:
    //assignment details
    
    int courseID;
    int month;
    int day;
    int maxPoints;
    string description;
    string assignmentName;
    int assignmentID;
};


//node for a singly linked list
struct Grade {
    Assignment* homework;
    int score;
};

class Course {
public:

    Course(string course_name, int id)
        : courseName(course_name), ID(id){}
  
    string getName(){
        return courseName;
    }
    int getID(){
        return ID;
    }
    
    //array of pointers to each student
    //vector<Student> studentList;
    //vector<Assignment> assignmentList;
    //pointer to the course teacher
    Teacher* courseTeacher;
private:
    string courseName;
    int ID;
};



//base class from which teachers and students inherit from
class User {
    
protected:
    string username;
    string password;
    //array of pointers to each course //max 18 courses
    vector<Course> courseList;
    vector<Assignment*> assignmentList;

public:
    User(){
        username = "";
        password = "";
    }
    User(string new_username, string new_password){
        username = new_username;
        password = new_password;
    }

    string getUsername(){
        return username;
    }
    string getPassword(){
        return password;
    }

    // vector<Assignment>* getAssignmentList(){
    //     return &assignmentList;
    // }
};

//derived class from user
class Teacher : public User {

public:

    int editAssignment(int assignmentID);
    void gradeAssignment(int assignmentID);
    int addStudent(int courseID);
    int removeStudent(int courseID);
    void createAssignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName);
    void createCourse();
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

void printMainMenu();
bool login();
void menu();
void initCourses(vector<Course> &courses);
void viewCourses(vector<Course> &courses);
