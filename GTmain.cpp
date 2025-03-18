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


}