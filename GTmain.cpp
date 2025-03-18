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
	for (auto &course : courses) {
		cout << "Course Name: " << course.getName() << ", Course ID: " << course.getID() << endl;
	}
}


int main(){
	vector<Course> courses;
	initCourses(courses);
	viewCourses(courses);

	cout << endl << endl << endl;

	int menuSelection = -1;

    do
	{
        printMainMenu();
        do
        {
            cin>>menuSelection;
        } while (menuSelection < 0 || menuSelection > 5);

        switch (menuSelection)
        {
            case 1:
                cout << "not implemented yet, (print list of courses)\n";
                break;
            case 2:
                cout << "not implemented yet, (Add course)\n";
                break;
            case 3:
                cout << "not implemented yet, (display calender)\n";
                break;
            case 4:
                cout << "not implemented yet, (show notifications)\n";
                break;
        }

    } while (menuSelection != 5);

}