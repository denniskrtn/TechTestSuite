# TechTestSuite #

**TechTestSuite** ist eine modulare Test- und Simulationssoftware entwickelt mit **C# / .NET 9 / WPF**.
Das Projekt simuliert technische Tests (z.B. Strom-, Spannungs- und Kommunikationstests) und visualisiert die Ergebnisse in einer modernen GUI.


---

## Features

- Moderne **WPF-Oberfläche** mit DataGrid und ProgressBar
- **Modulares Testsystem**: Testmodule sind leicht erweiterbar
- **Asynchrone Testausführung** mit Live-Fortschrittsanzeige
- Ergebnisse werden in einer **ObservableCollection** angezeigt
- **MVVM-Architektur** mit sauberer Trennung von UI und Logik


---

## Screenshots
![TechTestSuite UI](TechTestSuite/Assets/screenshot.png)

---

## Projektstruktur
```text
TechTestSuite.UI.WPF/
├── App.xaml
├── MainWindow.xaml
├── ViewModels/
│ ├── MainViewModel.cs
│ └── RelayCommand.cs
Core/
├── Interfaces/ITestModule.cs
├── Models/TestResult.cs
└── Services/TestRunner.cs
Tests/
├── CurrentTest.cs
├── VoltageTest.cs
└── CommunicationTest.cs
```
---

## Technologien

- **.NET 9**  
- **WPF**  
- **C# 13**  
- **MVVM-Architektur**  
- Asynchrone Programmierung (`async/await`)  
- Clean Code Prinzipien  

---

## Installation

1. **Repository klonen**:
```bash
git clone https://github.com/denniskrtn/TechTestSuite.git
```
2. In Visual Studio öffnen
- Projekt TechTestSuite.UI.WPF als Startprojekt wählen
- .NET 9 SDK erforderlich

3. Build & Run

---
## Nutzung

- Klicke auf **Start Tests**
- Die Ergebnisse erscheinen im DataGrid
- Fortschritt wird live in der ProgressBar visualisiert

---
## Erweiterung

- Neue Testmodule können leicht implementiert werden, indem dass ITestModule Interface implementiert wird
- Ergebnisse werden automatisch in der UI angezeigt

---
## Lizenz
MIT License


