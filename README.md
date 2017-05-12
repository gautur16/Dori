# Dóri
&copy; 2017 Hópur 30

A modern and sleek web program that allows you to share and write code with others.



### Features

* Create an account to the website to access it's functionality.
* Add, Edit and Delete Files.
* See when files where last modified.
* Adding links to Files to Folders.
* Store Files in different Folders.
* Code Files in different languages.
* Syntax highlighting while coding.
* Share files with another user.
* Be able to see what another user is coding in a shared file at real time.



### Login Window
If you already own an account, you login to your account with your email and password by filling in the textboxes. If you are a new user, you can create an account by clicking on "Register". If you have forgot the password to your account, than you can click on the "Forgot your Password?" link.
e
![login](https://cloud.githubusercontent.com/assets/24224545/26003229/a098a724-3721-11e7-8131-91a01a9e58fa.JPG)


#### Register
To create a new account, you need to fill out your information in the textboxes and then click the "Register" when finished.

![register](https://cloud.githubusercontent.com/assets/24224545/26003274/bfbf2c9a-3721-11e7-81de-9fe09259d96d.JPG)


#### Forgot Password
To recieve a new password, you need to enter your email in the textbox and then click the "Email Link" button when finished.

![forgotpassword](https://cloud.githubusercontent.com/assets/24224545/26003218/97c06c40-3721-11e7-82c8-d6b6e1a1517e.JPG)



### Overview
Here are all folders and files that you created displayed. To add a folder, click on the "Create Folder" button. To add a filde, click on the "Create File" button. To view files that another user shared with you, click on the "View Shared Files". To edit, share or delete a file, click on the "edit", "share", or "delete" buttons.
There are few actions in the banner. If you click on "Dóri", you will always be redirected to the overview page. If you click on "Hello <the users's email>!", you will be redirected to a page another page. If you click on "Log off", you will be logged off from your account and redirected to the login page.

![overviewwithfile](https://cloud.githubusercontent.com/assets/24224545/26003270/b8d69ad0-3721-11e7-8c4e-c0c433818971.JPG)


#### Your Profile
Some information about your profile. You can also change your password by clicking on "Change your password" link.

![myprofile](https://cloud.githubusercontent.com/assets/24224545/26003796/43b209f4-3723-11e7-8231-a5600efc1ac7.JPG)


#### Change password
To change your password you need fill out the textboxes and then click on the "Confirm password"". If you wish to cancel, click on the "Cancel" button and you will be redirected to the overview page.

![image](https://cloud.githubusercontent.com/assets/23433215/26008263/83c79724-3733-11e7-9b63-82d6cf2b6be4.png)


#### Create New Folder
Fill out the textbox to name the folder and then click the "Create" button. You can not create a folder that has the same name as another folder that already exists in the database. If you wish to cancel, click on the "Cancel" button and you will be redirected to the overview page.

![newfolder](https://cloud.githubusercontent.com/assets/24224545/26003253/af3916b0-3721-11e7-8434-28da15b8fa74.JPG)


#### Create New File
To create a new file, you need to fill out the textbox to name the file, choose the language to code in and in which folder you want to store the file. Then you click on the "Create" button and then redirected to a text editor.  You can not create a folder that has the same name as another folder that already exists in the database. If you wish to cancel, click on the "Cancel" button and you will be redirected to the overview page.

![newfile](https://cloud.githubusercontent.com/assets/24224545/26003241/a8cba8ec-3721-11e7-847a-1554e767fcaf.JPG)


#### Edit File
A text editor where you can write your code. To save your work, you click on the "Save Code" button. To go back to the overview, you can click on the "Back To Overview" button.

![editor](https://cloud.githubusercontent.com/assets/24224545/26003206/8dfd9a7a-3721-11e7-83ad-7cdf8a9e2f1e.JPG)


#### Share File
Enter the email of the user you want to share with. Then click on the "Share" button. If you wish to cancel, click on the "Cancel" button and you will be redirected to the overview page.
![share](https://cloud.githubusercontent.com/assets/24224545/26003280/c56d5ff4-3721-11e7-9422-2a3b08b98b35.JPG)


#### Delete File
Confirm the deletion of your file by clicking on the "Delete" button. If you wish to cancel, click on the "Cancel" button and you will be redirected to the overview page.

![delete](https://cloud.githubusercontent.com/assets/24224545/26003173/7b6e903a-3721-11e7-9ce7-396306f47c5a.JPG)


#### View Shared Files
Here you can view files that other users have shared with you. You can not share or delete files that another user shared with you. Click on the "Edit" button if you wish to edit the file.

![image](https://cloud.githubusercontent.com/assets/23433215/26005566/fa309196-3728-11e7-961d-c79955a0fc5c.png)



### Other stuff


#### User manual
To run the program, you need to do the following:
* You need to have Visual Studio installed with the ASP:NET MVC 5 package.
* You need to set up a local database. You do this by creating a folder in the C drive.
* Open Visual Studio, go to the Tools tab, hover the mouse over the NuGet Package Manager and select Package Manager Console.
* In the console enter "update-database". This will create local database files.
* Finally, to use the program's functionality, you will need to create an account.


#### Layer Architecture
* UI
	* User interface.
		* Window layout for the user.
		* Handles user input and validation.
*	Services
	* Folder/File/User Services.
	* Models
		* Folder/File/User classes.
		* Folder/File/User helper Classes.
*	Repositories
	* Folder/File/User Repositories.
	* Handles fetching and persisting data in SQL database.


#### Coding standards and tools

* Allman braces indent style.
* Microsoft C# style guide in other regards.
* Microsoft Visual Studio 2015, ASP.NET MVC 5 
* Git and Github for version control and issue tracking.
* Tested on macOS 10 and Windows 10.


#### Members of Hópur 30

* Benedikt Þorri Þórarinsson ([benediktt16@ru.is](mailto:benediktt16@ru.is))
* Gautur Arnar Guðjónsson ([gautur16@ru.is](mailto:gautur16@ru.is))
* Grétar Ingi Guðmundsson ([gretarg16@ru.is](mailto:gretarg16@ru.is))
* Hinrik Helgason ([hinrikhel16@ru.is](mailto:hinrikhel16@ru.is))
* Kristján Ingólfsson ([kristjani16@ru.is](mailto:kristjani16@ru.is))
