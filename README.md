# Przykłady ze szkolenia WPF MVVM

## Wprowadzenie

Witaj w repozytorium z materiałami do szkolenia **Tworzenie aplikacji WPF MVVM**. Ten projekt zawiera kompleksowe przykłady i ćwiczenia demonstrujące kluczowe koncepcje tworzenia aplikacji Windows Presentation Foundation (WPF) z wykorzystaniem wzorca Model-View-ViewModel (MVVM).

### Cele szkolenia
- Poznanie podstaw XAML i tworzenia interfejsów użytkownika
- Zrozumienie wzorca MVVM i jego implementacji
- Praktyczne zastosowanie różnych layoutów WPF
- Tworzenie rzeczywistych aplikacji biznesowych

## Wymagania techniczne

Do rozpoczęcia tego kursu potrzebujesz następujących rzeczy:

1. [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
2. Visual Studio 2022 lub Visual Studio Code
3. Podstawowa znajomość C# i programowania obiektowego

## Struktura projektu

Projekt jest zorganizowany w dwóch głównych sekcjach:

```
vavatech-pgz-wpf-mvvm/
├── docs/                           # Dokumentacja szkolenia
│   ├── wpf-mvvm.bmpr              # Diagramy i schematy
│   └── wpf-mvvm.pdf               # Materiały szkoleniowe
├── src/                           # Kod źródłowy
│   ├── Fundamentals/              # Podstawowe koncepcje
│   └── RealWorld/                 # Praktyczne przykłady
└── README.md                      # Ten plik
```

## Sekcja Fundamentals

Sekcja `Fundamentals` zawiera stopniowe wprowadzenie do technologii WPF i wzorca MVVM, podzielone na moduły:

### 01_XAML - Podstawy XAML
**Lokalizacja:** `src/Fundamentals/01_XAML/WpfApp/`

**Opis:** Wprowadzenie do języka XAML (eXtensible Application Markup Language) - podstawowego narzędzia do definiowania interfejsów użytkownika w WPF.

**Kluczowe tematy:**
- Podstawowa składnia XAML
- Definicja zasobów (Resources)
- Pędzle (Brushes) - SolidColorBrush, LinearGradientBrush, RadialGradientBrush
- Binding do zasobów statycznych
- Struktura aplikacji WPF

**Główne pliki:**
- `MainWindow.xaml` - Główne okno z przykładami różnych pędzli i przycisków
- `App.xaml` - Konfiguracja aplikacji
- `WpfApp.csproj` - Konfiguracja projektu .NET 9

### 02_Views - Zarządzanie widokami
**Lokalizacja:** `src/Fundamentals/02_Views/`

**Opis:** Demonstracja różnych sposobów organizacji i nawigacji między widokami w aplikacji WPF.

**Zawiera dwa projekty:**
- **WpfApp** - Nowoczesna implementacja z wieloma widokami
- **WpfOldApp** - Tradycyjne podejście dla porównania

**Kluczowe tematy:**
- Tworzenie wielu widoków (Views)
- Nawigacja między widokami
- UserControl vs Window
- Organizacja struktury aplikacji
- ShellView jako główny kontener

**Główne widoki:**
- `ShellView.xaml` - Główny kontener aplikacji
- `FirstPageView.xaml` - Pierwsza strona
- `SecondPageView.xaml` - Druga strona  
- `UserControlView.xaml` - Przykład UserControl
- `MainView.xaml` - Główny widok

### 03_Layouts - Systemy układów
**Lokalizacja:** `src/Fundamentals/03_Layouts/WpfApp/`

**Opis:** Szczegółowe omówienie wszystkich głównych paneli układu dostępnych w WPF.

**Kluczowe tematy:**
- **StackPanel** - Układ pionowy/poziomy
- **Grid** - Tabelaryczny układ z wierszami i kolumnami
- **DockPanel** - Dokowanie elementów do krawędzi
- **Canvas** - Absolutne pozycjonowanie
- **WrapPanel** - Automatyczne zawijanie elementów
- **UniformGrid** - Jednolite siatki

**Główne pliki:**
- `StackPanelView.xaml` - Demonstracja StackPanel
- `GridView.xaml` - Zaawansowane użycie Grid
- `DockPanelView.xaml` - Przykłady dokowania
- `CanvasView.xaml` - Absolutne pozycjonowanie
- `WrapPanelView.xaml` - Automatyczne zawijanie
- `UniformGridView.xaml` - Jednolite siatki

## Sekcja RealWorld

**Lokalizacja:** `src/RealWorld/`

**Opis:** Praktyczny przykład kompletnej aplikacji biznesowej demonstrującej zastosowanie wszystkich poznanych koncepcji w rzeczywistym projekcie. Aplikacja implementuje zaawansowaną architekturę z podziałem na warstwy (Domain, Infrastructure, ViewModels, WpfApp).

### Architektura aplikacji
Aplikacja RealWorld wykorzystuje **Clean Architecture** z podziałem na warstwy:

```
RealWorld/
├── Domain/                     # Warstwa domenowa
├── Infrastructure/             # Warstwa infrastruktury  
├── ViewModels/                # Warstwa ViewModels
├── WpfApp/                    # Warstwa prezentacji
└── MyApp.sln                  # Solution file
```

### Domain - Warstwa domenowa
**Lokalizacja:** `src/RealWorld/Domain/`

**Opis:** Zawiera modele biznesowe i abstrakcje (interfejsy) aplikacji.

**Kluczowe komponenty:**
- **Modele biznesowe:**
  - `Customer.cs` - Model klienta z adresami
  - `Region.cs` - Model regionu
  - `Address.cs` - Model adresu
  - `BaseEntity.cs` - Klasa bazowa dla encji
- **Modele czujników:**
  - `Sensor.cs` - Klasa bazowa czujnika
  - `TemperatureSensor.cs` - Czujnik temperatury
  - `Gyroscope.cs` - Żyroskop
- **Abstrakcje:**
  - `ISensorService.cs` - Interfejs serwisu czujników
  - `IRegionService.cs` - Interfejs serwisu regionów

**Kluczowe cechy:**
- Czysta warstwa domenowa bez zależności
- Abstrakcje dla serwisów
- Hierarchia dziedziczenia dla czujników
- Wzorce projektowe (Base Entity, Repository)

### Infrastructure - Warstwa infrastruktury
**Lokalizacja:** `src/RealWorld/Infrastructure/`

**Opis:** Implementuje interfejsy z warstwy Domain, dostarczając konkretne implementacje serwisów.

**Kluczowe komponenty:**
- `FakeSensorService.cs` - Implementacja ISensorService z danymi testowymi
- `DbSensorService.cs` - Implementacja ISensorService dla bazy danych
- `FakeRegionService.cs` - Implementacja IRegionService z danymi testowymi

**Kluczowe cechy:**
- Implementacja wzorca Repository
- Dane testowe dla rozwoju
- Przygotowanie do integracji z bazą danych
- Dependency Injection ready

### ViewModels - Warstwa ViewModels
**Lokalizacja:** `src/RealWorld/ViewModels/`

**Opis:** Zawiera ViewModels implementujące wzorzec MVVM z logiką biznesową dla interfejsu użytkownika.

**Kluczowe komponenty:**
- `BaseViewModel.cs` - Klasa bazowa dla wszystkich ViewModels
- `ItemsViewModel<T>.cs` - Generyczny ViewModel dla kolekcji
- `CustomersViewModel.cs` - ViewModel dla zarządzania klientami
- `SensorsViewModel.cs` - ViewModel dla zarządzania czujnikami
- `RegionsViewModel.cs` - ViewModel dla zarządzania regionami

**Kluczowe cechy:**
- Generyczne ViewModels dla różnych typów danych
- Dependency Injection dla serwisów
- Implementacja wzorca MVVM
- Testowalna logika biznesowa

### WpfApp - Aplikacja biznesowa
**Lokalizacja:** `src/RealWorld/WpfApp/`

**Funkcjonalności:**
- Zarządzanie klientami (Customers)
- Zarządzanie czujnikami (Sensors) z wizualizacją na mapie
- Zarządzanie regionami (Regions) z czujnikami
- Nowoczesny interfejs użytkownika
- Wzorzec MVVM w praktyce
- Style i zasoby globalne
- Nawigacja między widokami
- Custom Controls

**Struktura aplikacji:**
```
WpfApp/
├── Views/
│   ├── ShellView.xaml          # Główny kontener aplikacji
│   ├── CustomersView.xaml      # Widok zarządzania klientami
│   ├── SensorsView.xaml        # Widok zarządzania czujnikami
│   ├── MapSensorsView.xaml     # Widok mapy czujników
│   └── RegionsView.xaml        # Widok zarządzania regionami
├── CustomControls/
│   └── MapSensors.xaml         # Custom Control do wizualizacji czujników
├── Resources/
│   ├── Colors.xaml             # Definicje kolorów
│   └── Styles.xaml             # Globalne style aplikacji
├── ViewModelLocator.cs         # Locator dla Dependency Injection
├── App.xaml                    # Konfiguracja aplikacji
└── WpfApp.csproj              # Konfiguracja projektu
```

**Funkcjonalności:**
- **Wizualizacja czujników na mapie** - Custom Control MapSensors
- **Zarządzanie pozycją czujników** - Slidery do ustawiania X/Y
- **Grupowanie czujników w regiony** - Hierarchiczna organizacja
- **Zaawansowane style** - Spójny design system
- **Dependency Injection** - Microsoft.Extensions.DependencyInjection

**Kluczowe cechy:**
- Wykorzystanie wzorca MVVM
- Separacja logiki biznesowej od interfejsu
- Testowalna architektura
- Nowoczesne style i UX
- Custom Controls
- Wizualizacja danych na mapie

## Przygotowanie środowiska

### 1. Sklonuj repozytorium
```bash
git clone https://github.com/sulmar/vavatech-pgz-wpf-mvvm
cd vavatech-pgz-wpf-mvvm
```

### 2. Zbuduj wszystkie projekty
```bash
cd src
dotnet build
```

### 3. Uruchom przykłady
```bash
# Podstawy XAML
cd Fundamentals/01_XAML/WpfApp
dotnet run

# Widoki
cd ../../02_Views/WpfApp
dotnet run

# Layouty
cd ../../03_Layouts/WpfApp
dotnet run

# Aplikacja biznesowa (RealWorld)
cd ../../RealWorld/WpfApp
dotnet run
```

### 4. Uruchom poszczególne warstwy RealWorld
```bash
# Zbuduj całe rozwiązanie RealWorld
cd src/RealWorld
dotnet build

# Uruchom aplikację WpfApp (główna aplikacja)
cd WpfApp
dotnet run

# Testuj poszczególne warstwy
cd ../Domain
dotnet test  # jeśli są testy

cd ../Infrastructure  
dotnet test  # jeśli są testy

cd ../ViewModels
dotnet test  # jeśli są testy
```

## Ścieżka nauki

### Etap 1: Podstawy (01_XAML)
1. Zapoznaj się z podstawami XAML
2. Eksperymentuj z różnymi pędzlami
3. Zrozum koncepcję zasobów statycznych

### Etap 2: Widoki (02_Views)
1. Porównaj WpfApp z WpfOldApp
2. Zrozum różnice między UserControl a Window
3. Naucz się organizować strukturę aplikacji

### Etap 3: Layouty (03_Layouts)
1. Przetestuj każdy panel układu
2. Zrozum kiedy używać którego panelu
3. Połącz różne panele w złożone układy

### Etap 4: Praktyka (RealWorld)
1. **Architektura aplikacji:**
   - Przeanalizuj podział na warstwy (Domain, Infrastructure, ViewModels, WpfApp)
   - Zrozum zasady Clean Architecture
   - Naucz się Dependency Injection
2. **Warstwa Domain:**
   - Przeanalizuj modele biznesowe (Customer, Region, Sensor)
   - Zrozum hierarchię dziedziczenia czujników
   - Naucz się definiować abstrakcje (interfejsy)
3. **Warstwa Infrastructure:**
   - Zrozum implementację wzorca Repository
   - Naucz się tworzyć serwisy z danymi testowymi
   - Przygotuj się do integracji z bazą danych
4. **Warstwa ViewModels:**
   - Przeanalizuj generyczne ViewModels
   - Zrozum implementację wzorca MVVM
   - Naucz się Dependency Injection w ViewModels
5. **Aplikacja WpfApp:**
   - Przeanalizuj zaawansowane widoki (Sensors, Regions, MapSensors)
   - Naucz się tworzyć Custom Controls
   - Zrozum wizualizację danych na mapie
   - Naucz się tworzyć skalowalne aplikacje

## Wsparcie

W przypadku pytań lub problemów:
- Sprawdź dokumentację w folderze `docs/`
- Przeanalizuj przykłady kodu
- Skonsultuj się z prowadzącym szkolenie

## Licencja

Ten projekt jest przeznaczony do celów edukacyjnych w ramach szkolenia VavaTech.
