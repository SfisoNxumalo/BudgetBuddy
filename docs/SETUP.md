> *This document serves as a template for you to write **setup** instructions for your project.* 

> Depending on the scale/complexity of your project, it may prove beneficial to have a **Python/Batch/Bash** script in the `scripts/` directory which *automatically sets-up* the project.

# Setup Instructions

Follow the steps below to set up and run the project. (Example)

---

## 📦 Requirements
``` c
.NET 8 SDK
Node.js (LTS) + npm
SQL Server (Developer or Express)
SQL Server Management Studio (SSMS)(optional)
Git
A Google Cloud project with Gemini API enabled + API key (docs
)
---

## ⚙️ Installation
``` bash
# Clone the repository
git clone <[repo-url](https://github.com/SfisoNxumalo/BudgetBuddy)>
cd BudgetBuddyApp/src/BudgetBuddyApp/BudgetBuddyApp.Server

# Install dependencies
dotnet restore

Configure SQL Server Connection Update appsettings.json with your SQL Server connection string:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=MyDb;Trusted_Connection=True;"
}
Apply Migrations (if using Entity Framework Core)

bash
dotnet ef database update
Configure Gemini API Add your Gemini API key to appsettings.json or use environment variables:

json
"Gemini": {
  "ApiKey": "YOUR_GEMINI_API_KEY",
  "Endpoint": "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent"
}

Run the Backend Press F5 in Visual Studio or run:
bash
dotnet run

Frontend Setup (React + TypeScript)
Navigate to ClientApp

bash
cd ClientApp
Install Dependencies

bash
npm install
Start the Frontend Dev Server

bash
npm run dev
This will launch the React app;
```
