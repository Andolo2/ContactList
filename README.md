console application - address book

You will make a console application based on .NET 6 or .NET 7. In this application it should be possible to do the following things.

You will make a console application based on .NET 6 or .NET 7. In this application it should be possible to do the following things.


The main menu

When you start the program, you should get to some kind of menu that prints the following information on the screen. This information should appear the first time a user starts the program and then after it has completed one of the options. So it must be looped somehow:


Welcome to the Address Book

1. Create a contact

2. View all contacts

3. View a specific contact

4. Delete a specific contact

Choose one of the options above:

Create a contact

When the user selects this option, it should bring up a blank screen which will then list information that needs to be keyed in. It can be information such as first name, last name, e-mail address, phone number, street address, zip code and city. When the user has entered all the information, this information must be saved in a list. This list should then be saved to a json file so that the information remains even if you close the application.


Show all contacts

When the user selects this option, the user should get a blank screen that then lists all the contacts that are entered in the list. Each contact should be printed on its own line and formatted in a neat way. Only first name, last name and email address should be printed. The user must then press any key to return to the main menu.


View a specific contact

When the user selects this option, the user should get a blank screen that then lists a specific contact and its information. The information must be printed so that the following format is seen:


First name: xxxx

Surname: xxxx

Email address: xxxx@domain.com

Telephone number: 073-123 xx xx

Address: xxxx 1, 123 45 Stockholm


The user must then press any key to return to the main menu.


Delete a specific contact

When the user selects this option, the user will be presented with an empty screen on which the user must specify which contact person they want to remove. The user will then be asked if they are sure they want to delete the contact. If the user types y, the contact must be removed from the list and the json file must also be updated with the correct information. The user should then return to the main menu. If the user answers n, the user should return to the main menu without any contact being removed.

-------------------------------------------------------------------------------------------------------------------------------------------------------------

WPF Application - Address Book

You will make a WPF application based on .NET 6 or .NET 7. In this application it should be possible to do the following things.


Main page - show contacts and detailed information

When you start the program, you should come to a page divided into two columns, where all contact persons are listed in a list on the left column and the detailed information in the right column and this information should be exchanged if you choose to press a another contact. When you press a contact in the list, detailed information should appear and be displayed. There should also be a button that says delete and a button that says change.


Delete a specific contact

When you press the delete button, you should get a dialog box asking if the user really wants to delete the contact. If the user answers yes, the contact must be removed from the list. The json file must then also be updated with the correct information. The user should then return to the main page. If the user answers n, the user should return to the main page without any contact being removed.


Change a specific contact

When you press the change button, you should get to a new page where there are fields that contain all the data available about a user. Here the user should be able to update the fields and then press the save or cancel button.


If you press save, the json file must also be updated with the correct information and then you must return to the main page and the same contact person must be shown with the updated information. If you press the cancel button, no information should be updated, but instead you should return to the main page and see detailed information about the contact person that you intended to change.


Create a contact

It must be possible to create a new contact person in the application. This is done on a separate page. The user must then press a button to navigate to this page. On the page there must be a form where you must enter information such as first name, last name, e-mail address, phone number, street address, zip code and city. When the user has entered all the information, this information must be saved in a list. This list should then be saved to a json file so that the information remains even if you close the application. After that, the user should come back to the main page which lists all contacts.

-------------------------------------------------------------------------------------------------------------------------------------------------------------


Grading criteria

To pass, the following is required:

    - You must have created an address book using a console application with the functionality specified above.
    - Version control code using Git and GitHub.
    - You must do a simple unit test that checks whether you have added a contact person to the list using one of the following xUnit/nUnit/MSTest (a new           project in the same solution).


The following is required for successful approval:

    - You must have done what is specified under the requirements for passing.
    - You must have made an address book using a WPF application with the functionality specified above (a new project in the same solution).
    - You must also do a simple unit test that tests some functionality in your program using one of the following xUnit/nUnit/MSTest (a new project in the         same solution).

