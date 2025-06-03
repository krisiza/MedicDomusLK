# MedicDomusLK


MedicDomusLK is a web application that enables patients to create profiles, book appointments with doctors for a variety of services, and download invoices as PDFs. Meanwhile, doctors can manage their own profiles, cancel appointments, and issue invoices.

Features

👤 Patient Portal
Register and manage a personal profile
Browse available doctors and medical services
Book appointments with doctors based on service and availability
Cancel previously scheduled appointments
View billing history
Download invoices as PDF
🩺 Doctor Portal
Register as a doctor and manage a professional profile (including specialty, experience, description, and profile image)
View upcoming appointments with patients
Cancel appointments if needed
Create and assign invoices to patients
View patient treatment and billing history
🧾 Billing System
Doctors can create and manage invoices for services rendered
Invoices are associated with specific services and patients
Patients can view their invoices and download them in PDF format
Payment status is tracked (Paid / Unpaid)
Tech Stack

ASP.NET Core with Entity Framework Core
Identity for user authentication and role management
SQL Server (via EF migrations)
Razor Pages / Blazor Components (under MedicDomusLK.Components.Account.Pages.Manage namespace)
Database Models

Key models include:

ApplicationUser: Extended Identity user for both patients and doctors
DoctorInfo: Extended profile details for doctors
Service: Types of medical services offered
DoctorPatientService: Appointment relation between doctors and patients
Bill & BillService: Invoicing system with line-item services
Seeding (Sample Data)

On database creation, the system seeds:

Doctors and their specialties (Orthopedist, Dermatologist, Pediatrician, Cardiologist)
Patients with personal details
Towns (e.g. Regensburg, Cham, Neumarkt)
Services (e.g. Ultrasound, EKG, Vaccination)
Appointments and Bills with service breakdown
Doctor Profile Access

To simulate or test the application as a Doctor, you can log in with one of the seeded accounts:

Username: doctor1@example.com
Password: Password123!
Other seeded doctor accounts include:

doctor2@example.com
doctor3@example.com
doctor4@example.com
Each profile comes with realistic experience details, description, and associated services.

Getting Started

Clone the repository:
git clone https://github.com/your-username/MedicDomusLK.git
cd MedicDomusLK
Update connection string in appsettings.json for your local SQL Server.
Apply migrations:
dotnet ef database update
Run the application:
dotnet run
