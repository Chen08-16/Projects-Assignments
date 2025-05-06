import java.util.Scanner;

public class Enrollment{
	private String name;
	private String icNumber;
	private String email;
	private String subject;
	private int enrollmentId;
	//default constructor
	public Enrollment(){
		name = "N/A";
		icNumber = "N/A";
		email = "N/A";
		subject = "N/A";
		enrollmentId = -1;

	}
	//overloaded constructor
	public Enrollment(String n, String ic, String e, String s, int id){
		this.name = n;
		this.icNumber = ic;
		this.email = e;
		this.subject = s;
		this.enrollmentId = id;
	}
	//accessor or getter
	public String getName() {return name;}
	public String getIc()   {return icNumber;}
	public String getEmail(){return email;}
	public String getSubject(){return subject;}
	public int getEnrollmentId(){return enrollmentId;}

	//mutator or setter
	public void setName(String n){
		System.out.print("Enter your name: ");//prompt user to insert name
		name = input.nextLine();
	}
	public void setIc(String ic){
		System.out.print("Enter your IC: ");//prompt user to insert IC number
		icNumber = input.nextLine();
	}
	public void setEmail(String e){
		System.out.print("Enter your email: ");//prompt user to insert email
		email = input.nextLine();
	}
	public void setSubject(String s){
		System.out.println("Enter the subject chosen(Please use the words in the brackets and use , to separate the subjects): ");
		subject = input.nextLine();
	}

	public void setEnrollmentId(int id){
		enrollmentId = id;
	}

	public int getOption(String text){
		int option = 0;
		System.out.print(text);
		option = input.nextInt();

		return option;
	}
	public void displayMenu(){	//display the menu to the user
		System.out.println("Enrollment System" +
			   "\n--------------------------------------" +
	 		   "\nPress 1->Register student data        " +//Insert the student details such as name, IC, contact number and email
	           "\nPress 2->Update student subject       " +//Change the subject that enrolled by the student
	           "\nPress 3->Delete student data          " +//Delete the student detail and the enrolled subjects
	           "\nPress 4->Show only 1 student data     " +//Show only 1 specific student detail and subject enrolled by insert the student ID that provided by the system
               "\nPress 5->Show all student data        " +//Show all the student data and the subject enrolled
	           "\nPress 6->Exit                         " +//Exit the program
 	           "\n--------------------------------------") ;
	}
	public void displaySubject(){ //display the subject list to the user
		System.out.println("Subject list" +
			   "\n--------------------------------------" +
	 		   "\nBahasa Melayu(BM)" +
	 		   "\nBahasa Cina(BC)" +
	 		   "\nBahasa Inggeris(BI)" +
	 		   "\nPendidikan Moral(PM)" +
	 		   "\nSejarah(SEJ)" +
	 		   "\nMathematics(MATH)" +
	 		   "\nAdditional Mathematics(ADDMATH)" +
	 		   "\nScience(SC)" +
	 		   "\nPhysics(PHY)" +
	 		   "\nChemistry(CHEM)" +
	 		   "\nBiology(BIO)" +
	 		   "\nPrinsip Perakuanan(PP)" +
	 		   "\nEkonomi(EKO)" +
	 		   "\nKesusasteraan Cina(KC)" +
	 		   "\nPendidikan Seni Visual(PSV)"+
	 		   "\nKomputer Sains (KS)"+
 	           "\n--------------------------------------") ;
	}


	public String toString(){

		return "Name:" + name + "\nIC Number: " + icNumber + "\nEmail: " + email + "\nSubject: " + subject + "\nEnrollment ID: EID" + enrollmentId + "\n";
	}


	Scanner input = new Scanner(System.in);
	public static void main(String[] args){






	}
}