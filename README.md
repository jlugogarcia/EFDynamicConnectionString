# Entity Framework Dynamic Connection String
A template on setting dynamic connection string for Entity Framework data access projects.

### Instructions for getting started:

Next, it is presented the steps for getting the solution to work.

1- Restore a backup of WideWorldImporters-Full.bak on your local SQL Server machine. See: 
 *https://github.com/Microsoft/sql-server-samples/releases/tag/wide-world-importers-v1.0*

2-	Create a new ASP.NET web application project.

3-	Right click on top of the created project, Add-> New Item.

4-	Select “Data” from the left corner of the dialog.

5-	Click on “ADO.NET Entity Data Model”.

6-  Specify a name and click “Add”. This will prompt the next window.

7-	As the model we want to map already exists in database, select the first option “EF Designer from database”, and click “Next”. A screen prompting for establishing a new connection pops up. Click on New Connection, complete the parameters as you usually do to establish a connection to a database.

8-	Once the connection is established, click “OK”. This will bring you back to the previous screen and should looking like this.

9-	Set a name for saving the connection settings in Web.config file. Make sure writing down well this name since we will use it later as reference to change the connection string property dynamically. Click “Next”.

10-	Select the objects from the database you want to be present in your entity framework model. Once you select them all, specify a Model Namespace name and click on “Finish”. Read all dialogs during the creation of the EF model and accept them properly.

11-	At this point, you must be able to see at the designer, all the selected objects mapped, except the stored procedures (if selected any). This is fine, stored procedures won’t show up here but you must be able to see them by clicking on “Model Browser” tab.

12- If you go back to the Solution Explorer tab and click over any empty space onto the created mapped EF designer, you will be able to see the corresponding properties.

13- Notice the name for Entity Container* is the same one that we used to save the connection settings name in Step 9.
* The Entity Container is the public class created by Entity Framework to call all the objects mapped into its designer (tables, stored procedures, etc.)*

14-	Go to Web.config file. You will notice how EF have created a corresponding node for the connection string resulting from the earlier configuration wizard.

15- Since we do not want to read that sensitive data from this file, but from another source dynamically, delete that entry from the Web.config.

16-	Right click on the project node, Add-> New Class.

17-	Provide for the new class the same name as the one showed for the Entity Container resulting from Step 13.

18- Since it is not advisable making changes to Entity Framework auto-generated classes, we are going to create a new class that extends from DbContext and implements a constructor for passing the connection string as the parameter. For doing that it is built a new class with a code similar to the one shown under EFDynamicConnectionString/WideWorldImportersEntities.vb

19-	Now you can use the EF dynamic connection string solution as shown on the sample project at https://github.com/jlugogarcia/EFDynamicConnectionString
