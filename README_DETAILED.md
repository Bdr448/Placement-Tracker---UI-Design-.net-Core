# Placement Tracker - Real-Time Placement Management System

A comprehensive ASP.NET Core Blazor-based placement tracking system with real-time data, user authentication, company management, and student application tracking.

## Features

### ✅ Implemented Features

#### 1. **Authentication System**
- Secure login for both Students and Admins
- Registration with role selection
- Password hashing and validation
- Session management with Auth State

#### 2. **Admin Features**
- **Admin Dashboard**: Overview of placements, applications, and statistics
- **Company Management**: 
  - Add new recruiting companies
  - Edit company details (name, industry, contact, package, positions, etc.)
  - Delete companies
  - Search and filter companies
  - View all registered companies

- **Application Management**:
  - View all student applications
  - Track application status
  - Schedule interviews
  - Send notifications

#### 3. **Student Features**
- **Student Dashboard**: Personalized dashboard with key metrics
- **Browse Companies**: 
  - View all active recruiting companies
  - See company details and job descriptions
  - View average salary packages
  
- **Apply for Positions**:
  - Apply for company job openings
  - Track application status
  - View scheduled interviews
  - Receive notifications

#### 4. **Real-Time Notifications**
- Application status updates
- Interview scheduling notifications
- General placement updates
- Real-time notification count

#### 5. **Modern UI Design**
- Clean, professional interface
- Gradient backgrounds (purple to violet theme)
- Responsive grid layouts
- Professional color scheme
- Icons and badges for status
- Mobile-friendly design

## Project Structure

```
MyProject/
├── src/
│   ├── BusinessLogic/
│   │   ├── Models/
│   │   │   ├── User.cs
│   │   │   ├── Student.cs
│   │   │   ├── Company.cs
│   │   │   ├── Application.cs
│   │   │   └── Notification.cs
│   │   └── Services/
│   │       ├── AuthenticationService.cs
│   │       ├── CompanyService.cs
│   │       ├── ApplicationService.cs
│   │       └── NotificationService.cs
│   ├── MainApp/
│   ├── Portal.UI/
│   │   ├── Components/
│   │   │   ├── Pages/
│   │   │   │   ├── Home.razor
│   │   │   │   ├── Login.razor
│   │   │   │   ├── Register.razor
│   │   │   │   ├── Dashboard.razor
│   │   │   │   ├── ManageCompanies.razor
│   │   │   │   └── StudentDashboard.razor
│   │   │   └── Layout/
│   │   │       └── NavMenu.razor
│   │   └── Services/
│   │       └── AuthState.cs
│   └── ...
└── MyProject.sln
```

## Demo Credentials

### Admin Login
- **Email**: admin@placement.com
- **Password**: admin123

### Student Logins
1. **Student 1**
   - Email: student1@placement.com
   - Password: student123

2. **Student 2**
   - Email: student2@placement.com
   - Password: student123

## How to Run

### Prerequisites
- .NET 10 SDK or later
- Visual Studio Code / Visual Studio

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/Bdr448/Placement-Tracker---UI-Design-.net-Core.git
   cd MyProject
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   cd src/Portal.UI
   dotnet run
   ```

5. **Access the application**
   - Open browser and navigate to: `http://localhost:5095`

## User Workflows

### Admin Workflow
1. Login with admin credentials
2. Access Admin Dashboard with statistics
3. Manage Companies:
   - View all companies
   - Add new recruiting companies
   - Edit company details
   - Delete companies
4. View student applications
5. Schedule interviews with students
6. Send notifications

### Student Workflow
1. Register as a new student or login
2. Access Student Dashboard
3. Browse available companies
4. Apply for positions
5. Track application status
6. View interview notifications
7. Accept interview invitations

## Data Models

### User
- Id, Email, PasswordHash, FullName, Phone
- Role (Admin/Student), CreatedAt, IsActive

### Student
- Id, UserId, RollNumber, Department
- CGPA, Batch, Skills, Resume

### Company
- Id, Name, Industry, Email, Phone
- ContactPerson, Location, Website
- AveragePackage, OpenPositions
- JobDescription, Requirements

### Application
- Id, StudentId, CompanyId, Status
- AppliedAt, InterviewDate, InterviewLink
- InterviewNotes

### Notification
- Id, UserId, Title, Message
- Type (ApplicationStatus/InterviewScheduled), IsRead, CreatedAt

## Application Status Flow

```
Applied → Shortlisted → InterviewScheduled → Accepted/Rejected → Completed
```

## Technology Stack

- **Framework**: ASP.NET Core Blazor
- **Language**: C# 12
- **.NET Version**: 10.0
- **UI Framework**: Bootstrap 5
- **State Management**: Custom Auth State
- **Data Storage**: In-memory (can be extended to database)

## Features Highlights

✨ **Real-Time Updates**
- Dynamic notification system
- Live application status tracking
- Instant data refresh

🔐 **Security**
- Password hashing (SHA256)
- User authentication
- Role-based access control
- Session management

📊 **Admin Controls**
- Complete company management
- Application tracking
- Interview scheduling
- Student management

👨‍🎓 **Student Interface**
- Browse companies
- Apply online
- Track applications
- Receive notifications
- View interview details

## Future Enhancements

- Database integration (SQL Server/PostgreSQL)
- Email notifications
- File upload for resumes
- Interview video conferencing
- Analytics and reporting
- Salary negotiation module
- Alumni network
- Mobile app

## Browser Support

- Chrome (latest)
- Firefox (latest)
- Edge (latest)
- Safari (latest)

## Troubleshooting

### Port Already in Use
If port 5095 is already in use, modify `launchSettings.json`:
```json
"applicationUrl": "https://localhost:5096;http://localhost:5096"
```

### Build Errors
- Clear bin/obj folders: `dotnet clean`
- Restore packages: `dotnet restore`
- Rebuild: `dotnet build`

## License

This project is open source and available for educational purposes.

## Repository

GitHub: [Placement-Tracker---UI-Design-.net-Core](https://github.com/Bdr448/Placement-Tracker---UI-Design-.net-Core)

---

**Version**: 1.0.0  
**Last Updated**: January 30, 2026  
**Status**: Active Development
