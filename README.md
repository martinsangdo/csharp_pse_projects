**🛒 C# .NET + SQL Server E-Commerce Management System**\
A full-stack ASP.NET Core MVC web application designed to manage users, products, orders, and sales report with a secure admin dashboard and SQL Server backend.\
This project demonstrates enterprise-level architecture, clean MVC separation, and real-world e-commerce workflows.


**🚀 Screenshots**
<p align="center">
  <img src="FashionShop/wwwroot/screenshots/home.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/about.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/contact.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/categories.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/product-1.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/product-2.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/cart.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/checkout.png" width="480"/>

  <img src="FashionShop/wwwroot/screenshots/admin/dashboard.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/admin/products.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/admin/orders.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/admin/users.png" width="480"/>
  <img src="FashionShop/wwwroot/screenshots/admin/categories.png" width="480"/>
</p>


**📊 Admin Dashboard**\
Total users, products, orders\
Revenue overview


**🧰 Technologies Used**\
ASP.NET Core MVC\
C#	Server-side language\
SQL Server	Relational database\
Entity Framework Core	ORM\
Bootstrap 5	UI styling\
HTML/CSS/JS	Frontend\
Visual Studio Code IDE


**📦 Project Structure**\
/Controllers\
/Models\
/Views\
/Data\
/wwwroot\
/appsettings.json


**⚙️ Setup Instructions**\
1️⃣ Clone Repository\
2️⃣ Configure SQL Server\
Create a new database in SQL Server:\
CREATE DATABASE malefashion;\
Open appsettings.json and update:\
"ConnectionStrings": {\
  "MyDatabase": "Server=.;Database=malefashion;User Id=xxx;Password=xxxx;Trusted_Connection=True;TrustServerCertificate=True"\
}


**3️⃣ Run Sample SQL to create tables and data**\
1. /Data/create_tables.sql
2. /Data/insert_data.sql


**4️⃣ Run the Application**\
dotnet run


**🧑‍💻 Author**\
Sang Do\
IT Lecturer
