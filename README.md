# 🏥 Hospital Management System (ASP.NET Core 8 Web API)

[![.NET](https://img.shields.io/badge/.NET-8-blue)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-9.0-blue)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-blue)](https://www.microsoft.com/en-us/sql-server)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

A **Hospital Management System** built with **ASP.NET Core 8**, designed with a clean layered architecture.  
It provides **authentication, role-based access, doctor & patient management, scheduling**, and more.

---

## 🚀 Features

- 🔐 **Authentication & Authorization** using JWT Tokens  
- 🔁 **Refresh Token** mechanism  
- 👩‍⚕️ **Role-based access** (Admin, Doctor, Patient)  
- 🧑‍💻 Admin seeding during migration  
- 🔒 Secure password hashing (ASP.NET Identity)  
- 📧 Email confirmation & password reset  
- 📧 **Automatic email notifications to doctors** with credentials  
- 🗂️ **Bulk doctor creation via Excel upload**  
- 🏥 **Services management** (create, assign to branches)  
- 🏥 **Specializations management** (create, assign to branches)  
- 📅 **Scheduling system**  
  - Assign doctors to **shifts**  
  - Patients can register for **appointments in specific doctor shifts**  
- 🧩 **Clean layered architecture** (API / Application / Infrastructure / Domain)  

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

- Handles **registration, login, refresh tokens, password reset, and email sending**.  
- JWT tokens include **UserId, Role, DoctorId / PatientId** depending on the role.  
- Doctors automatically receive **email notifications with login credentials**.  
- Supports **role-based access** for Admin, Doctor, and Patient.

---

## 🏥 Doctor Module

- Doctors can be added **individually** or **bulk via Excel upload**.  
- Excel upload format:  
- Each doctor is assigned **specializations** and **branches**.  
- Doctors can be assigned **shifts**, and patients can book appointments in those shifts.

---

## 🏷️ Services & Specializations

- Admin can **create services** and **assign them to branches**.  
- Admin can **create specializations** and **assign them to branches**.  

---

## 📅 Scheduling System

- Doctors are assigned to **specific shifts**.  
- Patients can **register for appointments** only in available shifts.  
- Supports **shift management**, ensuring no conflicts in scheduling.

---

## 📌 Additional Notes

- JWT tokens allow decoding to extract user role, userId, doctorId, or patientId.  
- All passwords are **hashed securely** using ASP.NET Identity.  
- EPPlus library version ≤ 4.5.3.3 is recommended for **Excel upload** to avoid licensing issues.  
- The system supports **bulk operations** to save admin time and maintain data consistency.

---

## 📦 How to Run

1. Clone the repository:  
```bash
git clone <your-repo-url>
