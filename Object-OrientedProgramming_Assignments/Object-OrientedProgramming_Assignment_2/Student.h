#include <iostream>
#include <iomanip>
#include <string>
#include "Person.h"

using namespace std;

#ifndef _STUDENT_
#define _STUDENT_
class Student : public Person {
	private:
		int studentNumber;
		string program;
		double cgpa;
	public:
		Student (){
			studentNumber = 0;
			program = "N/A";
			cgpa = 0.0;
		}
		Student (int sN, double c, string p){
			studentNumber = sN;
			cgpa = c;
			program = p;
		}
		
		//These are getters
		int getStudentNumber() const {return studentNumber;} 
		double getCgpa()       const {return cgpa;}
		string getProgram()    const {return program;}
		
		//These are setters
		void setStudentNumber(int sN){       
			studentNumber = sN;
		}
		
		void setCgpa(double c){
			cgpa = c;
		}
		
		void setProgram(string p){
			program = p;
		}
		
		//print student details
		//override the print method
		void print() const {
			Person::print(); // call parent print method
			cout << fixed << showpoint << setprecision(1);//set the cgpa to one decimal point
			cout << "StudentNumber  : A" << studentNumber << endl;
			cout << "Student Program: "  << program       << endl;
			cout << "Student CGPA   : "  << cgpa          << endl;
		}
		
};
#endif
