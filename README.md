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

**Opis:** Praktyczny przykład kompletnej aplikacji biznesowej demonstrującej zastosowanie wszystkich poznanych koncepcji w rzeczywistym projekcie.

### MyApp - Aplikacja biznesowa
**Lokalizacja:** `src/RealWorld/WpfApp/`

**Funkcjonalności:**
- Zarządzanie klientami (Customers)
- Nowoczesny interfejs użytkownika
- Wzorzec MVVM w praktyce
- Style i zasoby globalne
- Nawigacja między widokami

**Struktura aplikacji:**
```
WpfApp/
├── Views/
│   ├── ShellView.xaml          # Główny kontener aplikacji
│   └── CustomersView.xaml      # Widok zarządzania klientami
├── Resources/
│   └── Styles.xaml             # Globalne style aplikacji
├── App.xaml                    # Konfiguracja aplikacji
└── WpfApp.csproj              # Konfiguracja projektu
```

**Kluczowe cechy:**
- Wykorzystanie wzorca MVVM
- Separacja logiki biznesowej od interfejsu
- Testowalna architektura
- Nowoczesne style i UX

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

# Aplikacja biznesowa
cd ../../RealWorld/WpfApp
dotnet run
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
1. Przeanalizuj architekturę aplikacji biznesowej
2. Zrozum implementację wzorca MVVM
3. Naucz się tworzyć skalowalne aplikacje

## Wsparcie

W przypadku pytań lub problemów:
- Sprawdź dokumentację w folderze `docs/`
- Przeanalizuj przykłady kodu
- Skonsultuj się z prowadzącym szkolenie

## Licencja

Ten projekt jest przeznaczony do celów edukacyjnych w ramach szkolenia VavaTech.
