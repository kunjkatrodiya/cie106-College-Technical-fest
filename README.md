# 🎓 AMTICS Technical Fest Registration System

A web-based **College Technical Fest Registration System** developed using **ASP.NET Core MVC**.

This application allows students to register for technical fest events, view registered participants, and check their registration details and fee category.

---

## 📌 Project Information

**Project Name:** AMTICS Technical Fest Registration System  
**Framework:** ASP.NET Core MVC  
**Language:** C#  
**Frontend:** HTML, CSS, Bootstrap, Razor  
**IDE:** Visual Studio Code  
**.NET Version:** .NET 8  
**Storage:** Temporary In-Memory List  

---

## 🎯 Problem Statement

Develop an ASP.NET Core MVC web application to manage student registrations for an AMTICS Technical Fest.

The system should allow students to:

- Register for technical fest events
- Enter participant information
- Select department and year
- Select an event
- Specify whether the event is a team event
- View all registered participants
- View complete participant details
- Display registration status
- Display registration fee and fee category

---

## ✨ Features

### 📝 Student Registration

Students can register by providing:

- Participant Name
- Email
- Department
- Year
- Event Name
- Team Event Status

Registration form includes validation using ASP.NET Core Model Validation and Tag Helpers.

---

### 👥 Participant Management

The participant list displays:

- Participant ID
- Participant Name
- Email
- Department
- Year
- Event
- Registration Status
- Registration Fee
- Details Action

---

### 💰 Registration Fee

Registration fees are automatically assigned based on the selected event.

The candidate does not manually enter the registration fee.

The system categorizes fees into:

- 🆓 Free Event
- 💵 Standard Event
- 💎 Premium Event

---

### ✅ Registration Status

The application uses an extension method to determine registration status.

- **Confirmed** → Registration completed
- **Pending** → Registration not completed

Bootstrap alerts are displayed according to the registration status.

---


### 🔧 Extension Methods

The project contains:

`ParticipantExtensions.cs`

It provides:


```csharp
GetRegistrationStatus()
