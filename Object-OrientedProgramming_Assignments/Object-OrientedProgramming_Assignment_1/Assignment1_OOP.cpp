#include <iostream>
#include <iomanip>
using namespace std;

int main(){
	
	int studentID=0,exit=0;
	double mark1=0, mark2=0, mark3=0, mark4=0, score=0;
	
	cout << "Press 1 to continue and any other button to exit: ";
	cin >> exit;
	
	while (exit == 1) {
	
	cout << "Enter student ID: ";
	cin >> studentID;
	
	cout << "Enter student's marks for assignment 1: ";
	cin >> mark1;
	
	while (mark1<0 || mark1>100) {
		
		cout << "Invalid mark! The mark must be in range 0 to 100." << endl;
		
		cout << "Enter student's marks for assignment 1: ";
		cin >> mark1;
	
	}
	
	cout << "Enter student's marks for assignment 2: ";
	cin >> mark2;
	
	while (mark2<0 || mark2>100) {
		
		cout << "Invalid mark! The mark must be in range 0 to 100." << endl;
		
		cout << "Enter student's marks for assignment 2: ";
		cin >> mark2;
	
	}
	
	cout << "Enter student's marks for midterm examination: ";
	cin >> mark3;
	
	while (mark3<0 || mark3>100) {
		
		cout << "Invalid mark! The mark must be in range 0 to 100." << endl;
		
		cout << "Enter student's marks for midterm examination: ";
		cin >> mark3;
	
	}
	
	cout << "Enter student's marks for final examination: ";
	cin >> mark4;
	
	while (mark4<0 || mark4>100) {
		
		cout << "Invalid mark! The mark must be in range 0 to 100." << endl;
		
		cout << "Enter student's marks for final examination: ";
		cin >> mark4;
	
	}
	
	score = mark1*20/100 + mark2*20/100 + mark3*20/100 + mark4*40/100 ;
	
	cout << fixed << showpoint << setprecision(2);
	cout << "\n\n" << studentID << ",your final result is " << score << "%" << endl;
	
	if (score>=80)
		cout << "Congratulations! You got grade A!" << endl;
	else if (score>=70)
		cout <<	"Congratulations! You got grade B+!" << endl;
	else if (score>=65)
		cout <<	"Congratulations! You got grade B!" << endl;
	else if (score>=55)
		cout <<	"Congratulations! You got grade C+!" << endl;
	else if (score>=50)
		cout <<	"Congratulations! You got grade C!" << endl;
	else if (score>=40)
		cout <<	"Congratulations! You got grade D!" << endl;
	else 
		cout <<	"You got grade F!" << endl;
		
			
		cout << "\nPress 1 to continue and any other button to exit: ";
		cin >> exit;
	}
	
	return 0;
}
