# Pierres-Treats

#### Latest version date 2020/08/14

#### By Erich Richter

## Description
This application uses MySQL and Entity to create a webpage that allows Pierre to market his sweet and savory treats. unlogged-in users can view treats and flavors, logged-in users can edit create and delete treats and flavors.

## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to view Treats or view Flavors.
* **Input Example:** "view Treats " or "view Flavors"
* **Output Example:** / or / 

2. **Behavior:** The logged-in user can add a new treat with their name and date of hire.
* **Input Example:** "add treat"
* **Output Example:** //

3. **Behavior:** The logged-in user can add a new flavor with the flavor name and flavor number.
* **Input Example:** "Add new flavor"
* **Output Example:** //

4. **Behavior:** The user can assign treats to a flavor (a single treat can have many flavors and a single flavor can have many treats).
* **Input Example:** "Add treat to flavor"
* **Output Example:** ///{}

5. **Behavior:** The program will allow the logged-in user to delete a flavor.
* **Input Example:** "Delete flavor"
* **Output Example:** ///{}

5. **Behavior:** The program will allow the logged-in user to delete an treat.
* **Input Example:** "Delete treat"
* **Output Example:** ///{}

4. **Behavior:** The logged-in user can edit existing flavors and treat information
* **Input Example:** "Edit flavorInfo" or "Edit treat Info"
* **Output Example:** ///{}

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.
3. Run a command in the root directory of the project that looks like this: > `dotnet ef migrations add Initial`.
4. Then run the following command: > `dotnet ef database update`.


## MySQL Installation and Setup

1. Download the MySQL Web Installer from the [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. Follow along with the installer:
* Click "Yes" if prompted to update.
* Accept license terms.
* Choose Custom setup type.
* When prompted to Select Products and Features, choose the following:
  * MySQL Server 8.0.19 (This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0")
  * MySQL Workbench 8.0.19 (This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0")
* Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)
* Advance through Configuration as follows:
  * High Availability set to "Standalone".
  * "Defaults are OK" under Type and Networking.
  * Authentication Method set to Use Legacy Authentication Method.
  * Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  * Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.
* Complete Installation process.

## Setup/Installation Requirements

**Requirements:**
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
* [MySQL Server 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* [MySQL Workbench 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* Entity Framework

**To use this program:**

1. Open your preferred browser.
2. Navigate to https://github.com/RichterBros/PierresTreats.Solution
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console, VS Code Bash terminal, or the MacOS Terminal and use the ``cd [YOUR DOWNLOAD FILEPATH]/PierresTreats.Solution/Bakery`` command to navigate to the Factory subdirectory.
5. Use the ``dotnet restore`` command to install the necessary packages on your computer.
6. Use the ``dotnet run`` command to run the program.
7. Use the web interface to add engineers and machines and keep track of Dr. Sneuss's factory.
8. Ensure that the following code is present in your *appsettings.json* file:

    ```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=erich_richter;uid=root;pwd=epicodus;"
      }
    }
    ```

9. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

To recreate the database using MySQL and Entity Framework Core:

_**Note**: These instructions assume that you have installed and set up your MySQL Server according to Epicodus's guidelines, as well as Entity Framework Core. For more information, see [Installing and Configuring MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) and [Configuration for Entity Framework Core](https://www.learnhowtoprogram.com/c-and-net/database-basics-c2449db9-5bd8-4303-af8d-7ed7259f79a7/configuration-for-entity-framework-core)._

1. Open Windows PowerShell, the MacOS Terminal, or your VS Code terminal and use the command ``cd [YOUR DOWNLOAD FILEPATH]/DrSneussFactory.Solution``.
2. Ensure that the Migrations folder is included in your cloned repository.
3. Use the ``dotnet ef database update`` command to apply the latest database migration.
4. Use MySQL Workbench or your preferred terminal to verify the database schema.

**To contribute to this project:**

1. Open your preferred browser.
2. Navigate to https://github.com/RichterBros/DrSneussFactory.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/[YOUR-USER-NAME-HERE]/DrSneussFactory.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ``Factory.Models`` namespace. **Note**: the Factory.csproj file is a C# project file and should not be edited.
7. Use the ``dotnet ef migrations add [YOUR MIGRATION NAME HERE]`` to add a new database migration. 

    You can also export your database schema from MySQL Workbench by using the **Data Export** option on the **Administration** tab of your database, select the schema you want to export, select the **Dump Structure and Data** option from the dropdown menu, and click the **Start Export** button. Make sure to name the file _erich_richter.sql_ and add the file to your repository in the top-level directory.
8. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
9. Push your changes to your forked repository.





```

4. Once the following code has been added to the window click "Execute the selected portion of the script or everything, if there is no selection" (it is the lightning bolt icon).

## Bugs

No bugs

## Tech used

* C#
* .NET Core
* Entity Framework
* MySQL

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Erich Richter