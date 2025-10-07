# FinanceSolution (Extended Sample)
This is an extended sample for the **MAUI Personal Finance** app plus a minimal ASP.NET Core API.
It is intended as a starter template with pre-built pages, sample data, and services.

## Requirements
- .NET 8 SDK
- .NET MAUI workload installed for your platform
- Android/iOS/Windows emulator (depending on target)
- (Optional) `dotnet ef` tools for migrations

## How to run the API
```bash
cd MyFinanceApi
dotnet restore
dotnet run
```

## How to run the MAUI app
Open `FinanceSolution.sln` or the `MyFinanceApp` project in Visual Studio 2022/2023 (with MAUI) and run on an emulator/device.
Or from CLI (platform-specific):
```bash
cd MyFinanceApp
dotnet build
dotnet maui run -f:net8.0-android
```

