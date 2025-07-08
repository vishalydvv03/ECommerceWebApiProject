# E-Commerce Web API (Beginner Level)

This is a simple and easy-to-understand **E-Commerce Web API** project built using **ASP.NET Core**. It helps you manage users, products, categories, and orders. You can register users, log in, create and manage products, and place orders using API endpoints.

---

##  What This Project Can Do

* Register and login users with **JWT tokens**
*  Assign users as **Admin** or regular **User**
* Create, view, update, and delete **product categories**
* Create, view, update, and delete **products**
* Place and manage **orders**
* **Soft delete**: instead of removing data from the database, it just marks it as deleted

---

## Tools & Technologies Used

* ASP.NET Core Web API
* C# Language
* Entity Framework Core (for database)
* SQL Server (for storing data)
* JWT (JSON Web Token) for login security

---

## Folder Structure

```
ECommerceWebApi/
│
├── Controllers/      → API endpoints (where HTTP requests are handled)
├── Models/           → C# classes for User, Product, Order, etc.
│   ├── DTO/          → Data Transfer Objects (used to send/receive data)
│   └── Data/         → Database setup and configuration
├── Services/         → Business logic (interfaces and classes)
├── appsettings.json  → Project settings (like DB connection, JWT key)
└── Program.cs        → Starting point of the app
```

---

## 🚀 How to Run the Project

### ✅ Step 1: Requirements

* .NET 7 SDK or higher
* SQL Server or LocalDB installed
* Visual Studio or VS Code
* Postman or Swagger (for testing)

---

### ⚙️ Step 2: Setup

1. **Clone the project**

```bash
git clone https://github.com/vishalydvv03/ECommerceWebApiProject.git
cd ECommerceWebApiProject
```

2. **Set up the database connection**

Open `appsettings.json` and find this section:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EcommerceDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

> Make sure your SQL Server or LocalDB is running.

3. **Create the database**

Open a terminal in the project folder and run:

```bash
dotnet ef database update
```

---

### Step 3: Run the App

```bash
dotnet run
```

Once it starts, open your browser and go to:

```
https://localhost:<port>/swagger
```

You will see all the API endpoints you can test.

---

## 🔐 Authentication (Login System)

### Register a new user

* **Endpoint:** `POST /api/auth/register`
* **Example Request:**

```json
{
  "username": "john",
  "email": "john@example.com",
  "password": "password123"
}
```

### Login to get a JWT token

* **Endpoint:** `POST /api/auth/login`
* **Example Request:**

```json
{
  "username": "john",
  "password": "password123"
}
```

> Copy the returned token and add it to **Authorization** header using **Bearer Token** in Postman or Swagger.

---

## 📡 API Endpoints (Beginner Friendly Table)

| Function        | Endpoint                  | Who Can Use     |
| --------------- | ------------------------- | --------------- |
| Register        | POST `/api/auth/register` | Anyone          |
| Login           | POST `/api/auth/login`    | Anyone          |
| Get Users       | GET `/api/users`          | Admin only      |
| Get Categories  | GET `/api/categories`     | Admin, User     |
| Create Category | POST `/api/categories`    | Admin only      |
| Get Products    | GET `/api/products`       | Admin, User     |
| Create Product  | POST `/api/products`      | Admin only      |
| Place Order     | POST `/api/orders`        | Logged-in Users |

> You can test all of this using **Postman** or **Swagger UI**.

---



---

## 📃 License

This project is open-source under the [MIT License](https://opensource.org/licenses/MIT).
