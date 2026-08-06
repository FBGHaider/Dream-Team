# Together Culture — Dream Team

> A community platform built in C# — one of my first major team projects and the beginning of my journey as a software developer.

Together Culture — Dream Team is a Windows desktop community platform designed to bring members together through events, skill sharing, memberships, community discussions, time banking, and a community shop.

This project holds a special place in my development journey. It was one of the first projects where I truly began writing C#, and one of my first substantial experiences developing software as part of a team.

Looking back at the project today, I can see both how far I have come and where my journey began.

---

## About

Together Culture is a community-management platform with two primary user types:

- **Members** — participate in the community and use its services.
- **Administrators** — manage users, events, memberships, and community content.

The platform brings several community services together into one Windows desktop application.

### Members can

- Browse and book events
- Participate in skill sharing
- Manage memberships
- Purchase items through the community shop
- Exchange services through time banking
- Create and interact with community posts
- Manage profiles and interests
- Leave feedback on events

### Administrators can

- Search and manage users
- Create, edit, and delete events
- Moderate community content
- Approve skill-sharing posts
- Manage membership tiers
- View payments and orders
- Perform administrative searches and operations

---

## Technology Stack

| Component | Technology |
|---|---|
| Language | C# |
| Framework | .NET 8 |
| UI | Windows Forms |
| Database | SQL Server 2019 / LocalDB |
| Database Language | T-SQL |
| UI Components | Guna.UI2.WinForms |
| Database Driver | System.Data.SqlClient |
| Testing | MSTest / NUnit |
| Mocking | Moq |
| IDE | Visual Studio 2022 |

---

## Architecture

The original application follows a desktop-oriented structure separating the front-end screens, supporting back-end utilities, database resources, and tests.

```text
Together Culture (Dream Team)
│
├── Together Culture (Dream Team)
│   ├── Back-End
│   │   ├── Main
│   │   │   └── Program.cs
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
```

---

# Features

## Events & Ticketing

Members can browse upcoming events and workshops.

The event system includes:

- Event listings
- Dates and times
- Locations
- Ticket prices
- Maximum occupancy
- Event bookings
- Individual ticket records
- Different attendee types
- Booking statuses

### Booking flow

```text
Browse Events
      ↓
Select Event
      ↓
Book Tickets
      ↓
Payment
      ↓
Booking Confirmation
```

## Memberships

The platform supports multiple membership types and tracks:

- Membership tiers
- Pricing
- Duration
- Discount rates
- Access levels
- Subscription start and end dates

## Community Shop

The shop supports:

- Product listings
- Product descriptions
- Pricing
- Stock levels
- Customer orders
- Order line items
- Shipping information
- Order statuses

## Skill Sharing

Members can offer or request skills from other members.

Each listing can contain:

- Service title
- Description
- Offering or requesting status
- Estimated time required

## Time Banking

The platform includes a time-banking concept where members exchange their time and skills.

Members can record:

- Time offered
- Time requested
- Time balance

## Community Board

Members can interact through community posts and comments.

The system includes:

- Posts
- Comments
- Likes
- Community discussions
- Administrative moderation

## Event Feedback

Members can provide feedback on events through:

- Ratings from 0–5
- Written comments

---

# Database

The project uses SQL Server LocalDB with a relational database containing 14 tables.

The main areas of the database are:

```text
Users
├── Memberships
├── Events
│   ├── Event Orders
│   └── Tickets
├── Shop
│   ├── Orders
│   └── Order Items
├── Skill Sharing
├── Time Banking
├── Community Board
│   └── Comments
├── Feedback
├── Interests
└── Documents
```

The database includes:

- Primary keys
- Foreign keys
- Unique constraints
- Check constraints
- Referential integrity rules
- Seed data

---

# Testing

A separate test project was created for core application functionality.

### Testing technologies

- MSTest
- NUnit
- Moq
- Coverlet

### Existing coverage includes

- Database connection behaviour
- Database operations
- User searches
- Event searches
- Administrative functionality

This project was an early introduction to testing software behaviour independently from the application itself.

---

# Security & Data Integrity

The original project included several security and data-integrity practices.

### Parameterized SQL

Parameterized queries are used in areas such as event searching to reduce SQL injection risks.

### Database Constraints

The database uses constraints to enforce valid data, including:

- Unique usernames
- Unique email addresses
- Valid user types
- Valid payment methods
- Valid booking statuses

### Foreign Keys

Relationships between entities are enforced using foreign-key constraints, including cascading and null-setting behaviour where appropriate.

---

# Known Limitations

This project was created early in my C# development journey, so the architecture reflects what I knew at the time.

Known limitations include:

- Database logic partially coupled to UI forms
- No dependency injection
- Synchronous database operations
- Hardcoded database connection configuration
- Passwords require proper hashing and security hardening
- Limited input validation
- Payment functionality remains incomplete
- Some community functionality remains unfinished
- Time-banking calculations require further implementation
- Email notifications are not implemented

These limitations are not being hidden. They are part of the project's history and provide opportunities for future modernisation.

---

# Future Modernisation

One of the reasons I am keeping this project is to potentially return to it using the knowledge and experience I have gained since its original development.

Potential improvements include:

```text
Original WinForms Application
            │
            ▼
     Modernised Architecture
            │
      ┌─────┼──────────────┐
      ▼     ▼              ▼
  Services Repositories  EF Core
      │     │              │
      └─────┼──────────────┘
            ▼
    Dependency Injection
            │
            ▼
       Async/Await
            │
            ▼
 Configuration & Validation
            │
            ▼
 Secure Authentication
            │
            ▼
 Improved Testing & Logging
```

The goal would not simply be to rewrite the application.

Instead, the project can serve as a practical way to demonstrate how my understanding of software engineering has evolved.

---

# Running the Project

## Prerequisites

- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server LocalDB
- Windows

## 1. Clone the repository

```bash
git clone <repository-url>
```

## 2. Open the solution

Open:

```text
Together Culture (Dream Team).sln
```

in Visual Studio.

## 3. Configure the database

The original application uses a local `.mdf` SQL Server database.

The connection configuration in:

```text
Back-End/ToolBoxItems/DatabaseConnect.cs
```

may need to be updated for your local environment.

## 4. Create and seed the database

The repository contains:

```text
Database/
├── SQLQueryCreateDB.sql
└── SQLQueryInsert.sql
```

Run the database creation script followed by the seed-data script.

## 5. Build

```bash
dotnet build
```

## 6. Run

```bash
dotnet run
```

Alternatively, run the application directly through Visual Studio using **F5**.

## 7. Run tests

```bash
dotnet test
```

---

# What This Project Taught Me

Although this project was created early in my C# journey, it introduced me to many concepts that became fundamental to my later development.

Among them:

- C# application development
- Object-oriented programming
- Windows desktop development
- Relational database design
- SQL and T-SQL
- CRUD operations
- Authentication and authorization concepts
- User roles
- Database relationships
- Foreign keys and constraints
- Parameterized queries
- Unit testing
- Mocking
- Team-based development
- Git and collaborative development
- Application architecture

More importantly, it taught me something that cannot easily be learned from a tutorial:

> **How much there is to learn when you try to build something real.**

---

# Why This Repository Matters

This isn't the most advanced project on my GitHub.

It isn't supposed to be.

**This is where I started.**

Together Culture was one of my first serious encounters with C#. I was still learning how programming languages, databases, user interfaces, testing, and software architecture fit together.

Looking at the project today, I can see plenty of things I would implement differently.

And that's exactly why I want to keep it.

It gives me a snapshot of the developer I was when I started — and a reference point for the developer I am becoming.

The project started as a university team project, but looking back, it feels like something more:

> **The beginning of something much bigger.**

---

# Project Journey

```text
First C# Code
      │
      ▼
Together Culture
      │
      ▼
First Team Development Experience
      │
      ▼
Databases • SQL • Testing • Git
      │
      ▼
More Projects
      │
      ▼
More Advanced Architecture
      │
      ▼
Modern .NET Development
      │
      ▼
Something Bigger
```

> **Every developer has a first project.**
>
> **This one was mine.**

---

# Project Status

| Item | Status |
|---|---|
| Original Project | Completed / Archived |
| Current Purpose | Historical reference + potential modernisation |
| Platform | Windows |
| Language | C# |
| Framework | .NET 8 |
| Database | SQL Server LocalDB |
| Development | Team Project |

---

## Final Note

I am keeping the original implementation because I don't want to erase where I came from.

The code may eventually change. The architecture may change. The technologies may change.

But this repository will always represent the point where I first started turning ideas into software.

**Together Culture — Dream Team.**

*The first step.*
