#include "GTheader.hpp"

void initCourses(vector<Course> &courses)
{
	Course Calc1("Calculus 1", 171);
	Course Calc2("Calculus 2", 172);
	Course Calc3("Calculus 3", 273);
	Course DiffEq("Differential Equations", 315);
	Course Linear("Linear Algebra", 220);
	Course Cpts322("Software Engineering l", 322);
	courses.push_back(Calc1);
	courses.push_back(Calc2);
	courses.push_back(Calc3);
	courses.push_back(DiffEq);
	courses.push_back(Linear);
	courses.push_back(Cpts322);
}

void viewCourses(vector<Course> &courses)
{
	for (const auto &course : courses) {
		cout << "Course Name: " << course.courseName << ", Course ID: " << course.ID << endl;
	}
}


int main(){
	vector<Course> courses;
	initCourses(courses);
	viewCourses(courses);

}