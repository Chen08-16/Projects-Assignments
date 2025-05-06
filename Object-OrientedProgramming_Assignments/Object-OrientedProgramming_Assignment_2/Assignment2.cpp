#include <iostream>
#include <iomanip>
#include <string>
#include "Student.h"
#include "Person.h"

using namespace std;

const int SIZE = 50;

//These are function prototypes
void displayMenu();
int getOption(string);

int main () {
	Student record[SIZE];//Declare a record object array
	int id = 0;
	int id2 = 0;
	double cgpa = 0.0;
	int option = 0;
	int option2 = 0;
	string name = "";
	string email = "";
	string icNumber = "";
	string program = "";
	
	cout << fixed << showpoint << setprecision(1);//set the cgpa to one decimal point
	
	
	
	do{
		displayMenu();//show user the menu	
		option = getOption("\nPlease enter your option: ");//prompt user to enter an option

		switch (option){
		case 1:
			
			//prompt user to enter their name and cgpa
		for(int i=0;i<SIZE; i++){
			cin.ignore();//To remove enter key
		
			cout << "Enter Student Name: ";
			getline(cin,name);
		
			cout << "Enter Student's IC Number(e.g. xxxxxx-xx-xxxx): ";                
			cin >>  icNumber;
			
			cin.ignore();//To remove enter key
		
			cout << "Enter Student Email: ";
			getline(cin,email);
			
			cout << "Enter Student Program: ";
			getline(cin,program);
			
			cout << "Enter Student's CGPA: "; 
			cin >> cgpa;
			cout << endl;
	
		while(cgpa<0 || cgpa>4){
			cout << "Invalid CGPA! The CGPA must be in range 0.0 to 4.0." << endl;
			cout << "Enter Student's CGPA: "; 
			cin >> cgpa;
			cout << endl;
		}
	
			record[i].setName(name);//set student name
			record[i].setIcNumber(icNumber);//set student IC number
			record[i].setEmail(email);//set student email
			record[i].setProgram(program);//set student program
			record[i].setCgpa(cgpa);// set student CGPA
		
			cin.ignore();//To remove the enter key
		
			id = i + 1;
			cout << "Your Student Number is A" << id << endl;//Show user their student number
		
			record[i].setStudentNumber(id);
			cout << "Press any number keys to continue and 0 to exit." << endl; 
			cin >> option2;
		
			if(option2 == 0){
				break;
			}
		}
			break;
		case 2:
			cout << "Enter Student Number: A" ;
			cin >> id2;
			id2 = id2-1;
			cout << endl;
	
		while (id2<0 || id2>SIZE){
			cout << "Wrong ID!Please try again!" << endl;
			
			cout << "Enter Student Number: A" ;
			cin >> id2;
			id2 = id2-1;		
		}
			cout << "Student Name     : "  << record[id2].getName()          << endl;
			cout << "Student Program  : "  << record[id2].getProgram()       << endl;
			cout << "Student Old CGPA : "  << record[id2].getCgpa() << endl;
			cout << "Enter new CGPA   : ";
			cin >> cgpa;
			cout << endl;
			
		while(cgpa<0 || cgpa>4){
			cout << "Invalid CGPA! The CGPA must be in range 0.0 to 4.0." << endl;
			cout << "Enter new CGPA   : "; 
			cin >> cgpa;
			cout << endl;
		}
			record[id2].setCgpa(cgpa);// set student new CGPA  
			break;
		case 3:
			cout << "Enter Student Number: A" ;
			cin >> id2;
			id2 = id2-1;
			cout << endl;
	
		while (id2<0 || id2>SIZE){
			cout << "Wrong ID!Please try again!" << endl;
		
			cout << "Enter Student Number: A" ;
			cin >> id2;
			id2 = id2-1;		
		}
	
			cout << "Student Number   : A" << record[id2].getStudentNumber() << endl;
			cout << "Student Name     : "  << record[id2].getName()          << endl;
			cout << "Student Program  : "  << record[id2].getProgram()       << endl;
			cout << "Student IC Number: "  << record[id2].getIcNumber()      << endl;
			cout << "Student Email    : "  << record[id2].getEmail()         << endl;
			cout << "Student CGPA     : "  << record[id2].getCgpa()          << endl << endl;
			break;
		case 4:
			
		//To display all student record details
		for (int i=0; i<SIZE; i++){
			record[i].print();
			cout  << endl;
		}
			break;
		case 5:
			cout << "Thank you for using Student Record System" << endl;
			exit(0);//terminate program
			break;
		default:
			cout << "Invalid option!" << endl;
			cout << "Please enter the option value in range 1 to 5" << endl;
			
	}//end switch
    }while (option != 5);
    
	
	

	return 0;
}
int getOption (string text) {
	int option=0;
	
	cout << text;
	cin >> option;
	
	return option;
}
void displayMenu () {
	cout << "Student Record System                " << endl;
	cout << "-------------------------------------" << endl;
	cout << "Press 1->Register student detail     " << endl;
	cout << "Press 2->Set new CGPA                " << endl;
	cout << "Press 3->Show student detail         " << endl;
	cout << "Press 4->Show all student details    " << endl;
	cout << "Press 5->Exit                        " << endl;
 	cout << "-------------------------------------" << endl;
}
