🛒 C# .NET + SQL Server E-Commerce Management System

A full-stack ASP.NET Core MVC web application designed to manage users, products, orders, and inventory with a secure admin dashboard and SQL Server backend.

This project demonstrates enterprise-level architecture, clean MVC separation, and real-world e-commerce workflows.

🚀 Features
👤 User Management

Register / Login / Logout

Email-based accounts

Enable / Disable users

View all users in admin panel

🛍️ Product Management

Add / Edit / Delete products

Product categories & brands

Stock quantity control

Product images upload

Product listing with pagination

📦 Order Management

Create orders

Order status workflow:

Pending

Processing

Shipped

Delivered

Cancelled

Tax & shipping fee calculation

Order history

🔐 Security

Password hashing

Session authentication

Role-based admin access

SQL injection protection

📊 Admin Dashboard

Total users, products, orders

Revenue overview

Low stock alerts

🧰 Technologies Used
Technology	Description
ASP.NET Core MVC	Backend web framework
C#	Server-side language
SQL Server	Relational database
Entity Framework Core	ORM
Bootstrap 5	UI styling
HTML/CSS/JS	Frontend
Visual Studio 2022+	IDE
📦 Project Structure
/Controllers
/Models
/Views
/Data
/wwwroot
/appsettings.json

⚙️ Setup Instructions
1️⃣ Clone Repository
git clone https://github.com/yourusername/your-repo-name.git
cd your-repo-name

2️⃣ Configure SQL Server

Create a new database in SQL Server:

CREATE DATABASE EcommerceDB;


Open appsettings.json and update:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=EcommerceDB;Trusted_Connection=True;TrustServerCertificate=True"
}

3️⃣ Run Database Migrations
Add-Migration InitialCreate
Update-Database

4️⃣ Run the Application
dotnet run


or press F5 in Visual Studio.

Then open:

https://localhost:5001

🧪 Testing
Feature	How to Test
Register	Create new user account
Login	Login with created account
Admin panel	Login as admin
Products	Add / edit / delete
Orders	Place orders & change status
Users	Enable / disable accounts

🧑‍💻 Author

Sang Do
IT Lecturer / Full-Stack .NET Developer