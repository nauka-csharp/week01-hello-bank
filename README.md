1. Przygotowanie środowiska
IDE, SDK i narzędzia
Zainstaluj .NET 8 SDK i Visual Studio 2022/2025 Community lub VS Code z rozszerzeniami C# i C# Dev Kit. Źródło konfiguracji znajdziesz w tutorialach “Write your first C# code” 

.

Przećwicz GitHub Flow: branch → PR → review → merge 

.

Załóż monorepo nauka‑csharp z folderami /week01, /week02 …

2. Miesiąc 1 – C# Fundamentals (Sprinty 1‑4)
Sprint 1: Składnia & „Hello World”
Przerób interaktywne lekcje „Tour of C#” 

.

Zadanie: „Hello Bank” – konsolowa apka, która loguje transakcje w pamięci.

Sprint 2: Sprint 2 – nowości: record, LINQ, pattern-matching.

.

Zadanie: Kalkulator ocen – pobiera listę punktów, wyznacza średnią.

Sprint 3: Kontrola przepływu, kolekcje, pattern‑matching
Ćwiczenia W3Schools + challenge z pattern‑matching 

Zadanie: Gra „Wisielec” z List<char> i switch expressions.

Sprint 4: Pierwsze testy jednostkowe
Wprowadzenie do xUnit 


Dodaj testy do wszystkich poprzednich projektów (TDD mile widziane).

3. Miesiąc 2 – OOP, SOLID i Clean Architecture (Sprinty 5‑8)
Zapoznaj się z przykładowym szablonem Clean Architecture 


Stwórz bibliotekę TaskScheduler.Core z modelami TaskItem, ITaskRepository.

Rozszerz testy integracyjne (xUnit + FluentAssertions 
C# Corner
).

Każdy sprint kończy się refaktoryzacją według zasady „Single Responsibility”.

4. Miesiąc 3 – ASP.NET Core Minimal APIs (Sprinty 9‑12)
Sprint 9: Minimal API 101
Przejdź tutorial „Create a Minimal API” 

, skup się na MapGet / MapPost.

Zadanie: wystaw swój TaskScheduler jako REST‑API (SQLite In‑Memory).

Sprint 10: Walidacja i automapper
Dodaj IEndpointFilter, fluent validation, DTO‑mapy.

Sprint 11: Autentykacja – Identity & JWT
: „ASP.NET Core Identity” 



Dodaj rejestrację i logowanie.

Sprint 12: Dokumentacja Swagger & Tests
Skonfiguruj Swashbuckle + testy end‑to‑end w WebApplicationFactory.

5. Miesiąc 4 – Entity Framework Core 8 (Sprinty 13‑16)
Tutorial „First app with EF Core” 



Migruj TaskScheduler do bazy SQLite/PostgreSQL; wprowadź repozytoria asynchroniczne.

Dodaj migracje dotnet ef migrations add InitialCreate.

Testy: In‑Memory vs. SQLite‑in‑container.

6. Miesiąc 5 – UI: Razor Pages & Blazor
Artykuł o hostingu Blazor WebAssembly 



Sprint 17‑18: stwórz panel webowy do zarządzania zadaniami (Blazor WASM + API).

Sprint 19: dodaj komponenty live‑update (SignalR).

7. Miesiąc 6 – DevOps & Cloud (Sprinty 20‑24)
Quickstart: deploy ASP.NET Core na Azure App Service 



Skonfiguruj GitHub Actions (dotnet test, dotnet publish) i automatyczny deploy.

Dodaj Dockerfile & kontenery; patrz poradnik Visual Studio Containers 



8. Jak będziemy pracować
Poniedziałek – dostajesz instrukcję sprintu + materiały.

Wtorek–Czwartek – kod, commity opisane według Conventional Commits.

Piątek – PR + code‑review; razem omawiamy refactor i kolejny krok.

W razie pytań: zgłaszasz issue „question” w repo, ja odpowiadam w wątku.
