# 3-Tier Architecture Project with C# WinForms

<div align="center">
  
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078d4?style=for-the-badge&logo=windows&logoColor=white)

</div>

## 📋 Table of Contents

- [Overview](#overview)
- [3-Tier Architecture Explained](#3-tier-architecture-explained)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)

##  Overview

This project demonstrates the implementation of a **3-Tier Architecture** using C# and Windows Forms. It's designed as a practice project to showcase the separation of concerns principle, maintainability, and scalability in software development.

The application follows industry best practices by separating the user interface, business logic, and data access into distinct layers, making the code more organized, testable, and maintainable.

## 🏗️ 3-Tier Architecture Explained

The **3-Tier Architecture** is a client-server software architecture pattern that separates an application into three interconnected but distinct layers:

###  Presentation Layer (UI Layer)
- **Technology**: Windows Forms (WinForms)
- **Responsibility**: User interface and user experience
- **Contains**: Forms, controls, user input validation, data display
- **Purpose**: Handles all user interactions and presents data in a user-friendly format

**Key Characteristics:**
- Direct interaction with end users
- Minimal business logic (only UI-related logic)
- Calls Business Logic Layer for data operations
- Displays results from business operations

###  Business Logic Layer (BLL)
- **Technology**: C# Classes and Methods
- **Responsibility**: Application's core functionality and business rules
- **Contains**: Business entities, validation rules, calculations, workflows
- **Purpose**: Processes data according to business requirements

**Key Characteristics:**
- Contains all business rules and logic
- Independent of user interface and data storage
- Validates data before processing
- Acts as an intermediary between Presentation and Data Access layers

### 🗄️ Data Access Layer (DAL)
- **Technology**: ADO.NET, SQL Server Connection
- **Responsibility**: Data persistence and retrieval
- **Contains**: Database connections, SQL queries, stored procedures, data models
- **Purpose**: Manages all database operations (CRUD operations)

**Key Characteristics:**
- Direct communication with the database
- Handles connection management
- Executes SQL commands and stored procedures
- Returns data to Business Logic Layer

## 📁 Project Structure

```
📦 3TierArchitectureProject
 ┣ 📂 PresentationLayer (WinForms)
 ┃ ┣ 📜 MainForm.cs
 ┃ ┗ 📜 FrmAddEditeContacts.cs
 ┣ 📂 BusinessLogicLayer
 ┃ ┣ 📜 Contact.cs
 ┃ ┗ 📜 Country.cs
 ┣ 📂 DataAccessLayer
 ┃ ┣ 📜 Country_DataAcces.cs
 ┃ ┣ 📜 Contact_DataAcces.cs
 ┃ ┗ 📜 clsDataAcces_helper.cs
 ┗ 
```

## 💻 Technologies Used

- **Frontend**: Windows Forms (.NET Framework)
- **Backend**: C# Programming Language
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio
- **Framework**: .NET Framework
- **Data Access**: ADO.NET

## 🛠 Features

- ✅ Clean separation of concerns
- ✅ Scalable and maintainable code structure
- ✅ Database connectivity with SQL Server
- ✅ User-friendly Windows Forms interface
- ✅ CRUD operations implementation
- ✅ Error handling and validation
- ✅ Modular design for easy testing
- ✅ Configurable database connections

## 🚀 Installation

### Prerequisites

- Visual Studio 2022 or later
- .NET Framework 4.7.2 
- SQL Server Management Studio (optional)

### Setup Steps

1. **Clone the repository**
   ```bash
   https://github.com/aboubakr-jelloulat/3-Ttier-Architecture-WinForm-APP.git
   cd 3-Ttier-Architecture-WinForm-APP
   ```

2. **Open in Visual Studio**
   - Launch Visual Studio
   - Open the `.sln` solution file

3. **Configure Database Connection**
   - Update connection string in `App.config`
   ```xml
   <connectionStrings>
     <add name="DefaultConnection" 
          connectionString="Data Source=localhost;Initial Catalog=YourDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

## 🗃️ Database Setup

1. **Create Database**
   ```sql
   RESTORE DATABASE (see Data bases Folder);
   ```

2. **Verify Connection**
   - Test the database connection from the application
   - Ensure all tables are created properly


## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


<div align="center">
  <p><strong>⭐ If you found this project helpful, please give it a star! ⭐</strong></p>
</div>
