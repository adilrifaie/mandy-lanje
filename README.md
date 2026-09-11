# Mandy Lanje

A full-featured e-commerce web application built with ASP.NET Core MVC — product catalog, session-based cart, checkout, and a complete admin back office with role-based access control.

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet)
![EF Core](https://img.shields.io/badge/EF%20Core-9.0-512BD4)
![SQLite](https://img.shields.io/badge/SQLite-database-003B57?logo=sqlite)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?logo=bootstrap)

## Features

**Storefront**
- Product catalog with category filtering, search, and pagination
- Session-backed shopping cart
- Checkout flow with order confirmation
- Public user registration and login

**Admin panel**
- Dashboard with live product/category/order/user counts
- Full CRUD for products (with image upload) and categories
- Order management
- User and role management
- Role-based authorization — Admin-only area, enforced server-side

## Tech stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 9) |
| Data access | Entity Framework Core 9 + SQLite |
| Auth | ASP.NET Core Identity |
| Mapping | AutoMapper |
| UI | Razor Views, Bootstrap 5, Font Awesome |

## Architecture

A 4-project layered solution:
Entities → POCOs, DTOs, request parameters
Repositories → EF Core data access (generic repository + unit of work)
Services → business logic, AutoMapper-backed DTO mapping
StoreApp → MVC controllers, Razor views, Admin area, ViewComponents


## Getting started

```sh
git clone https://github.com/adilrifaie/mandy-lanje.git
cd mandy-lanje
dotnet restore
dotnet ef database update --project Repositories --startup-project StoreApp
dotnet run --project StoreApp
```

Then open https://localhost:7025.

### About this project

Mandy Lanje is my first ASP.NET Core CRUD application, originally built while following a .NET e-commerce tutorial and since extended with authentication, role-based admin access, full category management, and a live admin dashboard.