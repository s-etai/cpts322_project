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
    Course(const string &course_name, int id)
        : courseName(course_name), ID(id){}
    string courseName;
    int ID;
private:
    //array of pointers to each student
    //vector<Student> studentList;
    vector<Assignment> assignmentList;
    //pointer to the course teacher
    Teacher* courseTeacher;

};



//base class from which teachers and students inherit from
class User {
    
private:
    string username;
    string password;
    vector<Course> courseList;

public:
    User();
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

void printMainMenu();
void login();
