#include "GTheader.hpp"



int main(){
	cout << "TESTING VIEW COURSES:" << endl << endl;
	vector<Course> courses;
	initCourses(courses);
	viewCourses(courses);

	cout << endl << endl <<
	"TESTING MENU:" << endl << endl;
	menu();

	cout << "TESTING LOGIN:" << endl << endl;
	login();

	cout << "TESTING ASSIGNMENT CREATION" << endl << endl;

	Teacher *teachtest = new Teacher();

	teachtest->createAssignment(1234, 17, 3, 10, "Test Assignment to test the create assignment function", "Test Assignment");


}