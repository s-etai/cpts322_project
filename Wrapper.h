//
// Created by Jace Dunn on 4/2/25.
//

#ifndef WRAPPER_H
#define WRAPPER_H
#include "GTheader.hpp"

class Wrapper {
public:
	void run()
	{
		if(login())
		{
			menu();
		}
		vector<Course> courses;
		initCourses(courses);
		viewCourses(courses);

		Teacher *teachtest = new Teacher();
		teachtest->createAssignment(1234, 17, 3, 10, "Test Assignment to test the create assignment function", "Test Assignment");
	}
};



#endif //WRAPPER_H
