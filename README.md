# 📱 FinTrack – Cross-Platform Personal Finance Application  

A modern **.NET MAUI** application that empowers individuals to track income, manage expenses, set budgets, and visualize spending patterns — all in one seamless cross-platform experience.  

---

## 🌟 Features  

- 📲 **Cross-Platform:** Built with **.NET MAUI & C#**, works on Android, iOS, and Windows.  
- 💾 **Offline-First:** Uses **SQLite** for fast and reliable local storage.  
- 🔗 **Cloud Sync:** Sync data securely across devices using **REST APIs**.  
- 📊 **Reports & Insights:** Interactive charts for income/expense trends.  
- 🗂️ **Smart Categorization:** Manage categories and budgets with ease.  
- 🔒 **Secure Access:** Optional user authentication and data encryption.  

---

## 🏗️ Project Structure  

```

FinTrackApp/
├── MyFinanceApp/                  # .NET MAUI Mobile Application
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── Program.cs
│   ├── Models/                     # Data models (Transaction, Category, Budget, User)
│   ├── ViewModels/                  # MVVM bindings
│   ├── Views/                        # Pages (Dashboard, Transactions, Reports)
│   ├── Services/                     # SQLite, API, Sync, Auth
│   ├── Helpers/                      # Constants, Converters, Validators
│   ├── Resources/                    # Fonts, Images, Styles
│   └── Tests/                         # Unit & UI tests
│
└── MyFinanceApi/                     # ASP.NET Core Web API
├── Controllers/                   # Transactions, Categories, Auth
├── Models/                         # Shared backend models
├── Data/                           # EF Core DbContext & migrations
├── Services/                        # Business logic layer
└── appsettings.json

````

---

## 🛠️ Tech Stack  

| Layer                | Technology                           |
|----------------------|---------------------------------------|
| **Frontend (App)**   | .NET MAUI, XAML, MVVM Pattern         |
| **Backend (API)**    | ASP.NET Core 8, EF Core, REST APIs    |
| **Local Storage**    | SQLite (Offline)                      |
| **Cloud Database**   | SQL Server / PostgreSQL               |
| **Charts & Reports** | Microcharts / Syncfusion              |
| **Sync & Auth**      | Background Sync, JWT Authentication   |

---

## 🚀 Getting Started  

### ✅ Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [.NET MAUI Workload](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation)
- Android/iOS Emulator or Device
- EF Core CLI Tools:  
```bash
dotnet tool install --global dotnet-ef
````

---

### 📦 Installation & Setup

#### 1. Clone the Repository

```bash
git clone https://github.com/hq969/FinTrack.git
cd FinTrack
```

#### 2. Set Up the API

```bash
cd MyFinanceApi
dotnet restore
dotnet ef database update
dotnet run
```

API runs at: `https://localhost:5001`

#### 3. Run the Mobile App

```bash
cd ../MyFinanceApp
dotnet restore
dotnet build
dotnet maui run
```

---

## 📊 Core Models

### Transaction

```csharp
public class Transaction
{
    public int Id { get; set; }
    public string Type { get; set; } // Income / Expense
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }
}
```

---

## 📈 Roadmap

* [ ] Add recurring transactions
* [ ] Improve UI/UX with animations and charts
* [ ] Enable multi-language support
* [ ] Implement push notifications
* [ ] Integrate AI-based spending insights

---

## 🤝 Contributing

We welcome contributions!

1. Fork the repo
2. Create a new branch (`feature/awesome-feature`)
3. Commit changes and push
4. Open a pull request

---

## 📜 License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Harsh Sonkar**
AWS Engineer • Data Science Enthusiast • Full-Stack Developer

📫 Connect with me on [LinkedIn](https://www.linkedin.com/in/harsh-sonkar-232573250/)


---
