# 🏥 Hospital Management System (ASP.NET Core 8 Web API)

This project is a **Hospital Management System** built using **ASP.NET Core 8**, following a clean layered architecture.  
It provides modules for user authentication, role-based authorization, and system management for doctors, patients, and admins.

---

## 🚀 Features

- 🔐 Authentication & Authorization using **JWT Tokens**
- 🔁 Refresh Token mechanism
- 👩‍⚕️ Role-based access (Admin, Doctor, Patient)
- 🧑‍💻 Admin seeding during migration
- 🔒 Secure password hashing (ASP.NET Identity)
- 📧 Email confirmation & password reset
- 🧩 Scalable, clean architecture (API / Application / Infrastructure / Domain)

---

## 🧩 Tech Stack

- **Backend:** ASP.NET Core 8 (Web API)
- **Database:** SQL Server  
- **ORM:** Entity Framework Core  
- **Security:** ASP.NET Identity + JWT  
- **Language:** C#  
- **Tools:** Visual Studio / Azure Data Studio / Postman

---

## 🧱 Project Architecture

Hospital/
├── Hospital.API/ → Controllers, Middleware, Program.cs
├── Hospital.Application/ → Interfaces, DTOs, Helpers, Services Interfaces
├── Hospital.Domain/ → Entities, Enums, Domain Models
├── Hospital.Infrastructure/ → Implementations, DbContext, Migrations, Seed Data
└── Hospital.sln


This architecture follows the **Clean Architecture Pattern** — keeping layers separated and maintainable.

---

## 🔐 Authentication Module

The authentication system handles registration, login, refresh tokens, password reset, and email sending.

