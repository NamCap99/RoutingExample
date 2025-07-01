# RoutingExample 🚦

A minimal ASP.NET Core Web API project that demonstrates conventional routing, area routing, custom middleware endpoints, and full CRUD functionality using in-memory data.

---

## 📌 Overview

This project is designed for learning and demonstrating how routing works in ASP.NET Core using:

- ✅ Controller-based routing (`[controller]/[action]/{id?}`)
- ✅ Area-based routing (`/Admin/Dashboard`)
- ✅ Middleware-based custom endpoints (`/health`)
- ✅ In-memory CRUD operations using RESTful conventions

---

## 🔧 Technologies Used

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- ASP.NET Core MVC
- Swagger (Swashbuckle)
- In-memory data (no database)
- Visual Studio 2022 or VS Code

---

## ▶️ Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/NamCap99/RoutingExample.git
cd RoutingExample

2. Run the Project
dotnet run

📂 Project Structure
RoutingExample/
│
├── Controllers/
│   └── AccountController.cs     # CRUD logic here
│
├── Models/
│   └── AccountInfo.cs           # Domain model
│
├── Program.cs                   # Middleware + routing setup
├── launchSettings.json
└── README.md

Swagger UI

🧪 Example Request (POST)
http

POST /account-details
Content-Type: application/json
{
  "accountHolderName": "M N WILLIAM",
  "currentBalance": 800000000
}
Response:
json
{
  "id": 1002,
  "accountHolderName": "M N WILLIAM",
  "currentBalance": 800000000
}

🛡️ License
This project is open-source and available under the MIT License.

🙋‍♂️ Author
William (Nam Cap)
🔗 LinkedIn https://www.linkedin.com/in/williamcap99/
🐙 GitHub
---

Let me know if you'd like to:
- Automatically generate the `swagger.png` screenshot
- Add Docker support
- Or include database setup (EF Core) in future versions.
