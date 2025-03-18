#include <iostream>
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
    //next assignment in linked list
    Assignment* next;

    //previous asssingment in linked list
    Assignment* prev;

    //assignment details
    int courseID;
    int month;
    int day;
    int fullPoints;
    string description;
};

//doubly linked list
class AssnList {
    Assignment *head;
    Assignment *tail;
};

//node for a singly linked list
struct Grade {
    Grade* next;
    Assignment* homework;
    int score;
};

class Course {

private:
    //linked list of assignments
    AssnList homework;

    //array of pointers to each student
    Student* studentList[50];

    //pointer to the course teacher
    Teacher* courseTeacher;

public:
    //course id
    int ID;


};

//base class from which teachers and students inherit from
class User {
    
private:
    string username;
    string password;

    //array of pointers to each course //max 18 courses
    Course* courseList[18];

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
    Grade* list[18];

public:

    void displayGPA();
    void displayAssignments(int status);

};

void login();
int menu();
int validate(string username, string password, fstream& userFile);