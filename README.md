Together Culture — Dream Team

A community platform built in C# — one of my first major team projects and the beginning of my journey as a software developer.

Together Culture — Dream Team is a Windows desktop community platform designed to bring members together through events, skill sharing, memberships, community discussions, time banking, and a community shop.

This project holds a special place in my development journey. It was one of the first projects where I truly began writing C#, and one of my first substantial experiences developing software as part of a team.

Looking back at the project today, I can see both how far I have come and where my journey began.

Table of Contents
About the Project
Technology Stack
Project Structure
Features
Database
Testing
Security and Data Integrity
Known Limitations
Future Modernisation
Running the Project
What This Project Taught Me
Why This Repository Matters
Project Journey
Project Status
About the Project

Together Culture is a community-management platform with two primary types of users:

Members — people who participate in the community.
Administrators — users responsible for managing and moderating the platform.

The application brings several community services together into one desktop application.

Members can:

Discover and book events
Participate in skill sharing
Manage their membership
Purchase items through the community shop
Exchange services through time banking
Create and interact with community posts
Manage their interests and profile
Leave feedback on events

Administrators can:

Manage users
Manage events
Moderate community content
Approve skill-sharing posts
Manage membership tiers
View payments and orders
Perform administrative searches and operations
Technology Stack
Area	Technology
Language	C#
Framework	.NET 8
Desktop UI	Windows Forms
Database	SQL Server 2019 / LocalDB
Database Language	T-SQL
UI Components	Guna.UI2.WinForms
Database Driver	System.Data.SqlClient
Testing	MSTest / NUnit
Mocking	Moq
IDE	Visual Studio 2022

The majority of the project is written in C#, with T-SQL used for the database schema and seed data.

Project Structure
Together Culture (Dream Team)
│
├── Together Culture (Dream Team)
│   │
│   ├── Back-End
│   │   ├── Main
│   │   │   └── Program.cs
│   │   │
│   │   └── ToolBoxItems
│   │       ├── DatabaseConnect.cs
│   │       └── RoundedPanel.cs
│   │
│   ├── Front-End
│   │   ├── Screens
│   │   │   ├── Welcome.cs
│   │   │   ├── MemberAreaOnly.cs
│   │   │   ├── Payment.cs
│   │   │   ├── Interests.cs
│   │   │   ├── Admin Forms
│   │   │   ├── Events Forms
│   │   │   ├── Profile Forms
│   │   │   ├── Skill Share Forms
│   │   │   └── Landing Page Form
│   │   │
│   │   └── User Controls
│   │
│   ├── Database
│   │   ├── SQLQueryCreateDB.sql
│   │   ├── SQLQueryInsert.sql
│   │   ├── db_TogetherCulture.mdf
│   │   └── db_TogetherCultureRun.*
│   │
│   ├── Resources
│   └── Properties
│
├── TogetherCultureTests
│   ├── DatabaseTests.cs
│   ├── SearchEventsAdminTests.cs
│   ├── SearchUsersTests.cs
│   └── TogetherCultureTests.csproj
│
└── Together Culture (Dream Team).sln
Features
User Management

The application supports different user types and provides separate experiences for members and administrators.

Members can manage:

Accounts
Profiles
Interests
Memberships

Administrators have additional tools for searching and managing users.

Events and Ticketing

Members can browse upcoming events and workshops through the application.

The event system supports:

Event listings
Event dates and times
Locations
Ticket prices
Maximum occupancy
Event bookings
Individual ticket records
Different attendee types
Booking statuses

Example booking flow:

Browse Events
      |
      v
Select Event
      |
      v
Book Tickets
      |
      v
Payment
      |
      v
Booking Confirmation
Community Shop

The platform includes a community shop with support for:

Products
Product descriptions
Pricing
Stock levels
Customer orders
Order line items
Shipping information
Order statuses
Skill Sharing

Members can offer or request skills from other members.

A skill listing can contain:

Service title
Description
Whether the user is offering or requesting
Estimated time required

This forms part of the wider community and time-banking system.

Time Banking

The application includes a time-banking concept where members can exchange their time and skills.

Members can record:

Time offered
Time requested
Current time balance

The goal is to allow members to contribute skills and receive help from others without relying solely on monetary transactions.

Community Board

The community board provides a place for members to interact.

Supported concepts include:

Posts
Comments
Likes
Community discussions

Administrators can also moderate community content.

Event Feedback

Members can provide feedback on events through:

Ratings
Comments

Ratings are represented on a 0–5 scale.

Database

The project uses SQL Server LocalDB with a relational database containing 14 tables.

The main areas of the database include:

Users
 |
 +-- Memberships
 |
 +-- Events
 |    +-- Event Orders
 |         +-- Tickets
 |
 +-- Shop
 |    +-- Orders
 |         +-- Order Items
 |
 +-- Skill Sharing
 |
 +-- Time Banking
 |
 +-- Community Board
 |    +-- Comments
 |
 +-- Feedback
 |
 +-- Interests
 |
 +-- Documents

The database also contains:

Primary keys
Foreign keys
Unique constraints
Check constraints
Referential integrity rules
Seed data
Testing

A separate test project was created for testing core application functionality.

Testing technologies used include:

MSTest
NUnit
Moq
Coverlet

Existing tests cover areas such as:

Database connection behaviour
Database operations
User searches
Event searches
Administrative functionality

The project therefore introduced testing as part of the development process rather than treating testing as an afterthought.

Security and Data Integrity

The original project already included several security and database-integrity practices.

Parameterized SQL

Database queries use parameters in areas such as event searching, helping reduce SQL injection risks.

Database Constraints

The database uses constraints to enforce valid data.

Examples include:

Unique usernames
Unique email addresses
Valid user types
Valid payment methods
Valid booking statuses
Foreign Keys

Relationships between entities are enforced through foreign-key constraints, including cascading and null-setting behaviour where appropriate.

Known Limitations

This project was created early in my C# development journey, and the architecture reflects what I knew at the time.

Some known limitations include:

Database logic is partially coupled to UI forms
No dependency injection
Synchronous database operations
Hardcoded database connection configuration
Passwords require proper hashing and security hardening
Limited input validation
Payment functionality remains incomplete
Some community functionality remains unfinished
Time-banking calculations require further implementation
Email notifications are not implemented

These limitations are part of the project's history and also provide opportunities for future modernisation.

Future Modernisation

One of the reasons I am keeping this project is to potentially return to it with the knowledge and experience I have gained since its original development.

The original application provides a useful starting point for applying modern software engineering practices.

Potential improvements include:

Original WinForms Application
          |
          v
Better Architecture
          |
          +-- Service Layer
          +-- Repository Layer
          +-- Dependency Injection
          +-- EF Core
          +-- Async/Await
          +-- Configuration Management
          +-- Secure Authentication
          +-- Input Validation
          +-- Improved Testing
          +-- Logging

The goal would not simply be to rewrite the application, but to use it as a way of demonstrating how my understanding of software engineering has evolved.

Running the Project
Prerequisites

You will need:

Visual Studio 2022 or later
.NET 8 SDK
SQL Server LocalDB
Windows
1. Clone the Repository
git clone <repository-url>
2. Open the Solution

Open:

Together Culture (Dream Team).sln

in Visual Studio.

3. Configure the Database

The original application uses a local .mdf SQL Server database.

The database connection configuration in:

Back-End/ToolBoxItems/DatabaseConnect.cs

may need to be updated to match your local environment.

4. Create the Database

The repository contains:

Database/
├── SQLQueryCreateDB.sql
└── SQLQueryInsert.sql

Run the creation script followed by the seed-data script in SQL Server or Visual Studio.

5. Build
dotnet build
6. Run
dotnet run

Alternatively, run the application directly through Visual Studio using F5.

7. Run Tests
dotnet test
What This Project Taught Me

Although this project was created early in my C# journey, it introduced me to many concepts that would become fundamental to my later development.

Among them:

C# application development
Object-oriented programming
Windows desktop development
Relational database design
SQL and T-SQL
CRUD operations
Authentication and authorization concepts
User roles
Database relationships
Foreign keys and constraints
Parameterized queries
Unit testing
Mocking
Team-based development
Git and collaborative development
Application architecture

More importantly, it taught me something that cannot easily be learned from a tutorial:

How much there is to learn when you try to build something real.

Why This Repository Matters

This isn't the most advanced project on my GitHub.

It isn't supposed to be.

This is where I started.

Together Culture was one of my first serious encounters with C#. I was still learning how programming languages, databases, user interfaces, testing, and software architecture fit together.

Looking at the project today, I can see plenty of things I would implement differently.

And that's exactly why I want to keep it.

It gives me a snapshot of the developer I was when I started — and a reference point for the developer I am becoming.

The project started as a university team project, but looking back, it feels like something more:

the beginning of something much bigger.

Project Journey
First C# Code
     |
     v
Together Culture
     |
     v
First Team Development Experience
     |
     v
Databases • SQL • Testing • Git
     |
     v
More Projects
     |
     v
More Advanced Architecture
     |
     v
Modern .NET Development
     |
     v
        ?
  Something Bigger

Every developer has a first project.

This one was mine.

Project Status
Item	Status
Original Project	Completed / Archived
Current Purpose	Historical reference + potential modernisation
Platform	Windows
Language	C#
Framework	.NET 8
Database	SQL Server LocalDB
Development	Team Project
Final Note

I am keeping the original implementation because I don't want to erase where I came from.

The code may eventually change. The architecture may change. The technologies may change.

But this repository will always represent the point where I first started turning ideas into software.

Together Culture — Dream Team.

The first step.
