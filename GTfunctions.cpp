#include "GTheader.hpp"


/*Constructor for assginments with 6 variables
@param courseID ID for course assignment is listed under
@param day day of due date
@param month month of due date
@param maxPoints maximum number of points for assignment
@param description description of assignment
@param assignmentName Name of the assignment
*/
Assignment::Assignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName){
    this->courseID = courseID;
    this->day = day;
    this->month = month;
    this->maxPoints = maxPoints;
    this->description = description;
    this->assignmentName = assignmentName;
    this->assignmentID = 0;
}

/*Function adds assignment at the end of assignment vector
@param courseID ID for course assignment is listed under
@param day day of due date
@param month month of due date
@param maxPoints maximum number of points for assignment
@param description description of assignment
@param assignmentName Name of the assignment
*/
void Teacher::createAssignment(int courseID, int day, int month, int maxPoints, string description, string assignmentName){
    //vector<Assignment>* assignmentList = this->getAssignmentList();
    this->assignmentList.push_back(new Assignment(courseID, day, month, maxPoints, description, assignmentName));
    cout << "Assignment created!";
    return;
}

void printMainMenu()
{
  cout<<"1. Pick course"<<endl;
  cout<<"2. Add course"<<endl;
  cout<<"3. View calender"<<endl;
  cout<<"4. Nodification"<<endl;
  cout<<"5. Exit"<<endl;
}


void login(){

    system("clear");

    fstream users;
    users.open("users.csv");
    vector<User*> userList;

    /*
    string tempStr, tempName, tempPswd;
    char delim1, delim2, tempType;
    User* tempUser();

    while(!users.eof()) {

        //reading and sorting line to user values
        getline(users, tempStr);
        while (tempStr[delim1] != ',') delim1++;
        tempName = tempStr.substr(0, delim1);
        tempStr = tempStr.substr(delim1 + 1);
        delim2 = delim1 + 1;
        while (tempStr[delim2] != ',') delim2++;
        tempPswd = tempStr.substr(delim1 + 1, delim2);
        tempType = tempStr[delim2 + 1];


        if (tempType == 's'){
            tempUser = new Student(tempName, tempPswd);
        }
        else tempUser = new Teacher(tempName, tempPswd);
        
        userList.push_back(tempUser);
    }
    */
    User* tempUser = new User("Eli", "1234");
    userList.push_back(tempUser);
    tempUser = new User("Elliot", "5623");
    userList.push_back(tempUser);
    tempUser = new User("Jace", "1893");
    userList.push_back(tempUser);
    tempUser = new User("Stockton", "9897");
    userList.push_back(tempUser);

    string username, password;
    cout << "LOGIN" << endl << "Enter username: ";
    cin >> username;
    cout << "Enter password: ";
    cin >> password;

    int valid = 0, i = 0, length = userList.size();

    while(i < length){
        if (username == userList[i]->getUsername()){
            if(password == userList[i]->getPassword()){
                valid = 1;
                break;
            }
        }
        i++;
    }

    while (!valid){
        system("clear");
        cout << "Incorrect username or password" << endl << endl
        << "LOGIN" << endl << "Enter username: ";
        cin >> username;
        cout << "Enter password: ";
        cin >> password;

        i = 0;
        while(i < length){
            if (username == userList[i]->getUsername()){
                if(password == userList[i]->getPassword()){
                    valid = 1;
                    break;
                }
            }
            i++;
        }
    }

    users.close();

    cout << "Login Successful" << endl;
    return;
}

