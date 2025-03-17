#include <iostream>
using namespace std;


/*

NOTE: CURRENT FUNCTIONS DEFINTIONS MAYBE WRONG, IMPLEMENT HOWEVER YOU THINK MAKES SESNE

*/



//forward declarations
class Teacher;
class Student;


class Assignment {

private:
    Assignment* next;
    int id;
    int month;
    int day;
    int grade;
    string description;

public:

};

class Course {

private:
    Assignment* head;
    Student* studentList[50];
    Teacher* courseTeacher;
    int id;

public:


};

//base class from which teachers and students inherit from
class User {
    
private:
    int username;
    int password;
    Course* courseList[6];

public:

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
    
public:

    void displayGPA();
    void displayAssignments(int status);

};

int menu();
void displayLogin();
int validate(string username, string password);