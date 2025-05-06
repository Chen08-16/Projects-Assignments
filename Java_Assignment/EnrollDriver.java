import java.util.Scanner;

public class EnrollDriver{

	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		final int size = 10;
		String name = "";
		String ic = "";
		String subject = "";
		String email = "";
		int id = 0;
		int id2 = 0;
		Enrollment menu = new Enrollment();
		Enrollment record[] = new Enrollment[size];
		for(int x=0; x<size; x++){  // a for loop to declare each record
			record[x] = new Enrollment();

		}
		int option = 0;
		int option2 = -1;
        int counter = 0;
		do{
			menu.displayMenu();//show user the menu
			option = menu.getOption("Enter an option: ");
			System.out.println();

			switch(option){// switch case is used to let the user to make option
				case 1:
					do{
						if(id == size){
						System.out.println("Sorry! There is no more space for you to register.");
						System.out.println();
						break;
						}

					record[counter].setName(name);
					record[counter].setIc(ic);
					record[counter].setEmail(email);
					menu.displaySubject();
					record[counter].setSubject(subject);
					System.out.println();

					id++;
					record[counter].setEnrollmentId(id);
					System.out.println("Your Enrollment ID is EID" + id);//System will provide the student ID for the student automatically
					System.out.println();
					counter++;
					System.out.println("Please enter any number key to continue and 0 to exit.");//Ask user to continue register another student data or exit the registration
					option2 = input.nextInt();

					}while(option2 != 0);

					break;
				case 2:
					System.out.print("Enter your ID: EID");//Prompt user to insert the ID that provided by the system
					id2 = input.nextInt();
					while(id2 > size || id2 < 0){//To ensure the ID insert by the user is correct.
						System.out.println("Please enter the correct ID.");//The error message is display out to the user when the user insert error ID
						System.out.print("Enter your ID: EID");//Prompt the user to insert the correct ID
						id2 = input.nextInt();
					}
					id2--;
					menu.displaySubject();
					System.out.println("Your previous chosen subject are: " + record[id2].getSubject());
					record[id2].setSubject(subject);

					System.out.println();

					break;
				case 3:
					System.out.print("Enter your ID: EID");//Prompt user to insert the ID that provided by the system
					id2 = input.nextInt();
					while(id2 > size || id2 < 0){//To ensure the ID insert by the user is correct.
						System.out.println("Please enter the correct ID.");//The error message is display out to the user when the user insert error ID
						System.out.print("Enter your ID: EID");//Prompt the user to insert the correct ID
						id2 = input.nextInt();
					}
					id2--;
					record[id2] = new Enrollment();
					System.out.println("Data of EID" + (id2+1) + " successfully removed from the system.");
					System.out.println();


					break;
				case 4:
					System.out.print("Enter your ID: EID");//Prompt user to insert the ID that provided by the system
					id2 = input.nextInt();
					while(id2 > size || id2 < 0){//To ensure the ID insert by the user is correct.
						System.out.println("Please enter the correct ID.");//The error message is display out to the user when the user insert error ID
						System.out.print("Enter your ID: EID");//Prompt the user to insert the correct ID
						id2 = input.nextInt();
					}
					id2--;
					System.out.println(record[id2].toString());

					break;
				case 5:
						for(int i=0; i<size; i++){
						System.out.println(record[i].toString());
					}

					break;
				case 6:
					System.out.println("Thank you for using the system!");//The system send a message to the user before end of the program
						break;
				default:
					System.out.println("Invalid Option! Please enter the option in the range 1-6.");//if the user insert the wrong range of option, the error message will display
					   break;

			}

		}while(option != 6);

	}
}