
---

```md
# 🎟️ Ticketing System — Clean Architecture (.NET 10)

A real-world **Ticketing System backend** built with **ASP.NET Core 10**, following **Clean Architecture principles**, fully **Dockerized**, and covered by **real integration tests**.

> This project is designed as a production-ready backend, not a tutorial toy.

---

## 🧱 Architecture

This solution strictly follows **Clean Architecture**:

```

TicketingSystem
│
├── TicketingSystem.Domain        → Core domain entities & business rules
├── TicketingSystem.Application   → Use cases, DTOs, interfaces
├── TicketingSystem.Infrastructure→ EF Core, database, repositories
├── TicketingSystem.Api           → ASP.NET Core Web API
└── TicketingSystem.Tests         → Integration tests (real HTTP)

````

### Key Principles
- Dependency Inversion
- No Infrastructure dependency in Domain/Application
- Testable and maintainable design
- Explicit boundaries between layers

---

## ⚙️ Tech Stack

- **ASP.NET Core 10**
- **Entity Framework Core**
- **SQL Server 2022**
- **Docker & Docker Compose**
- **xUnit + WebApplicationFactory**
- **FluentAssertions**
- **Swagger / OpenAPI**

---

## 🐳 Docker Support

The project is fully containerized.

### Services
- **ticketing_api** → ASP.NET Core API
- **ticketing_sql** → SQL Server 2022

### Run with Docker
```bash
docker compose up --build
````

API will be available at:

```
http://localhost:8080
```

Swagger UI:

```
http://localhost:8080/swagger
```

---

## 🧪 Integration Tests (Real Tests)

This project includes **real integration tests**, not mocks.

✔ API boots using `WebApplicationFactory`
✔ Real HTTP requests are sent
✔ Full pipeline is tested (Controllers → Application → Infrastructure)

Example:

```csharp
[Fact]
public async Task login_should_fail_with_invalid_user()
{
    var response = await _client.PostAsJsonAsync(
        "/api/auth/login",
        new LoginRequestDto("x@test.com", "123")
    );

    response.IsSuccessStatusCode.Should().BeFalse();
}
```

Run tests:

```bash
dotnet test
```

---

## 📦 Database

* SQL Server runs in Docker
* Connection is handled via configuration
* Database is created automatically on first run

---

## 🚀 Project Status

✔ Clean Architecture implemented
✔ Dockerized
✔ Integration Tests passing
✔ Swagger enabled

🔜 Frontend (Angular / React) can be added later
🔜 Authentication & Authorization extensions
🔜 CI/CD pipeline

---

## 👤 Author

**Mehrad Khavary**
GitHub: [https://github.com/Mehrad44](https://github.com/Mehrad44)

---

## ⭐ Notes

This project is intentionally built as a **serious backend sample** suitable for:

* Portfolio
* Job interviews
* Real-world extension

If you're reviewing this repo:
👉 focus on **architecture**, **testability**, and **containerization**.

```

---

### اگر خواستی مرحله بعدی
می‌تونیم:
- README رو **دو زبانه (EN + FA)** کنیم  
- Badge حرفه‌ای اضافه کنیم (Docker, .NET, Tests Passing)  
- یا یه **Architecture Diagram** ASCII/PNG بذاریم

بگو:
> «README رو بذارم یا تغییرش بدی؟»

تا رگ خواب گیت‌هاب رو دقیق بزنیم 😎🔥
```
