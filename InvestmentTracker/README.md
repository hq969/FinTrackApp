# 💰 InvestmentTracker – Smart Investment Management Module

### A cross-platform module built with **.NET MAUI, C#, SQLite, and REST APIs** for tracking, analyzing, and syncing investment data seamlessly.  
It is designed as a standalone yet integrable component of **FinTrackApp**, your personal finance management ecosystem.

---

## 🚀 Overview

The **InvestmentTracker** module empowers users to manage their investments efficiently by providing features such as:

- 📈 **Add & Track Investments** — Log new investments with categories like Stocks, Mutual Funds, Crypto, Gold, etc.  
- 💹 **Portfolio Overview** — View total invested amount, current value, profit/loss, and ROI.  
- 🌍 **Market Data Insights** — Fetch live market prices and trends via REST APIs.  
- ☁️ **Cloud Sync Support** — Ready for integration with Firebase / AWS / Azure for real-time sync.  
- 📊 **Local Storage** — Securely store user data using SQLite.

---

## 🧱 Tech Stack

| Layer | Technology Used |
|-------|------------------|
| **Frontend (UI)** | .NET MAUI (XAML, C#) |
| **Logic & Architecture** | MVVM (Model–View–ViewModel) |
| **Database** | SQLite via `sqlite-net-pcl` |
| **API Integration** | `HttpClient`, `Newtonsoft.Json` |
| **Reactive Commands & Bindings** | `CommunityToolkit.Mvvm` |
| **Supported Platforms** | Android, iOS, Windows |

---

## 📂 Project Structure

```
InvestmentTracker/
│
├── App.xaml                     # Application resources and theme
├── App.xaml.cs                  # Main entry point and navigation
│
├── Models/
│   ├── InvestmentModel.cs       # Defines investment data schema
│   ├── PortfolioModel.cs        # Calculates ROI and profit/loss
│   └── MarketDataModel.cs       # Market data fetched from APIs
│
├── ViewModels/
│   ├── AddInvestmentViewModel.cs
│   ├── PortfolioViewModel.cs
│   └── MarketTrendsViewModel.cs
│
├── Views/
│   ├── AddInvestmentPage.xaml
│   ├── PortfolioPage.xaml
│   └── MarketTrendsPage.xaml
│
├── Services/
│   ├── DatabaseService.cs       # SQLite data handling
│   ├── ApiService.cs            # REST API for market data
│   └── SyncService.cs           # Cloud synchronization handler
│
├── Resources/                   # App icons, fonts, and styles
│
├── Platforms/                   # Platform-specific setup (Android/iOS/Windows)
│
└── InvestmentTracker.csproj     # Project configuration file
```

---

## ⚙️ Setup & Installation

### 🪟 Step 1: Clone or Navigate
If part of FinTrackApp:
```bash
cd FinTrackApp/InvestmentTracker
```

Or clone standalone:
```bash
git clone https://github.com/yourusername/InvestmentTracker.git
```

---

### 🧩 Step 2: Restore Dependencies
```bash
dotnet restore
```

---

### 🧰 Step 3: Build & Run
For Android:
```bash
dotnet build -t:Run -f net8.0-android
```

For Windows:
```bash
dotnet build -t:Run -f net8.0-windows10.0.19041.0
```

---

### ⚡ Step 4: Add Database Path (if external use)
Ensure `DatabaseService` is initialized with a valid local DB path:
```csharp
string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "investments.db3");
DatabaseService = new DatabaseService(dbPath);
```

---

## 📱 App Flow

1. **PortfolioPage** → Displays all investments and portfolio summary.  
2. **AddInvestmentPage** → Add a new investment record to SQLite.  
3. **MarketTrendsPage** → Fetch and display real-time market data.  
4. **SyncService** → Optional cloud sync for multi-device usage.

---

## 🧮 Core Features

| Feature | Description |
|----------|--------------|
| **Add Investment** | Create and save investments with name, category, and amount. |
| **Portfolio Summary** | Automatically calculate total investment, current value, and ROI. |
| **Market Trends** | Fetch live prices using REST API integration. |
| **Local Storage** | Save and retrieve data offline via SQLite. |
| **Extensible Architecture** | Can be plugged into FinTrackApp or used standalone. |

---

## 🧩 Integration with FinTrackApp

To integrate into **FinTrackApp**, include the project reference:

In `FinTrackApp.csproj`:
```xml
<ItemGroup>
  <ProjectReference Include="InvestmentTracker\InvestmentTracker.csproj" />
</ItemGroup>
```

Then navigate via:
```csharp
await Navigation.PushAsync(new InvestmentTracker.Views.PortfolioPage());
```

---

## 🔒 Future Enhancements

- 🔗 Cloud sync using AWS DynamoDB or Firebase  
- 📊 Graphical portfolio analytics  
- 💬 Notifications for market changes  
- 🤖 AI-based investment recommendations

---

## 👨‍💻 Author

**Harsh Sonkar**  
- 💼 AWS Engineer | Data Analyst | Full Stack Developer  
- 🌐 [LinkedIn](https://linkedin.com/in/harsh-sonkar)  
- 🧠 Skilled in .NET, MAUI, Python, AWS, Data Science, and Machine Learning  
- ✉️ Email: harshsonkar.dev@gmail.com
