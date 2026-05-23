# EventEase - Blazor Event Management App

## Project Overview
EventEase is a Blazor web application designed to help users manage events, register participants, and track attendance. This project was developed with the assistance of Microsoft Copilot to demonstrate AI-assisted software development, debugging, and optimization.

The project combines concepts from component-based UI design, routing, form validation, state management, and performance optimization in Blazor.

---

## Features

### Event Card Component
- Displays event details such as:
  - Event Name
  - Date
  - Location
  - Description
- Uses reusable Blazor components
- Implements two-way data binding

### Routing and Navigation
- Multiple pages with Blazor routing
- Navigation between pages
- Debugged routing and navigation issues

### Registration Form
- User registration for events
- Form validation using Blazor validation components
- Required field and email validation

### Attendance Tracker
- Tracks registered attendees
- Displays attendance status
- Allows event participation monitoring

### State Management
- Stores user session information
- Maintains application state during navigation

### Performance Optimization
- Improved input validation
- Fixed routing issues
- Reduced unnecessary rendering
- Enhanced user experience

---

## Technologies Used

- Blazor
- C#
- ASP.NET Core
- Microsoft Copilot
- Visual Studio / Visual Studio Code
- GitHub

---

## Project Structure

```txt
EventEase/
│
├── Components/
│   └── EventCard.razor
│
├── Models/
│   └── Event.cs
│
├── Pages/
│   ├── Events.razor
│   ├── Register.razor
│   └── Attendance.razor
│
├── Services/
│   └── UserSessionService.cs
│
├── Program.cs
└── README.md
```

---

## How Microsoft Copilot Assisted Development

### 1. Component Generation
Microsoft Copilot helped generate the foundational Event Card component with reusable UI elements and two-way data binding.

### 2. Debugging
Copilot assisted in identifying and fixing routing issues, validation errors, and navigation problems.

### 3. Optimization
Copilot suggested improvements for:
- Input validation
- Component rendering
- Cleaner code structure
- Better routing practices

### 4. Advanced Features
Copilot helped implement:
- Registration forms
- Attendance tracking
- State management for user sessions

### 5. Code Suggestions
Copilot provided code completion, refactoring suggestions, and development guidance throughout the project.

---

## Installation and Setup

### Prerequisites
- .NET SDK
- Visual Studio or VS Code
- Git

### Steps

1. Clone the repository

```bash
git clone https://github.com/yourusername/EventEase.git
```

2. Navigate to the project folder

```bash
cd EventEase
```

3. Run the application

```bash
dotnet run
```

4. Open the browser and navigate to:

```txt
https://localhost:5001
```

---

## Screenshots

Add screenshots of:
- Event Card page
- Registration Form
- Attendance Tracker
- Navigation pages

---

## GitHub Repository

Repository Link:
```txt
https://github.com/yourusername/EventEase
```

---

## Author

Developed as part of a Blazor and Microsoft Copilot learning project.

---

## License

This project is for educational purposes.