#include <iostream>
#include <string>

using namespace std;

#ifndef _PERSON_
#define _PERSON_
class Person {
	protected:
		string name;
		string icNumber;
		string email;
	public:
		Person (){
			name = "No Name";
			icNumber = "N/A";
			email = "N/A";
		}
		Person (string n, string icN, string e){
			name = n;
			icNumber = icN;
			email = e;
		}
		
		//These are getters
		string getName()     const {return name;}
		string getIcNumber() const {return icNumber;} 
		string getEmail()    const {return email;}
		
		//These are setters
		void setName(string n){
			name = n;
		}
		
		void setIcNumber(string icN){       
			icNumber = icN;
		}
		
		void setEmail(string e){
			email = e;
		}
		
		void print() const {
			
			cout << "Name           : "  << name     << endl;
			cout << "IcNumber       : "  << icNumber << endl;
			cout << "Email          : "  << email    << endl; 
		}
	
};
#endif
