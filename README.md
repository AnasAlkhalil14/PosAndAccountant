# Al-Maher | POS & Accounting System

A desktop point-of-sale and accounting system built for a real family shop. It covers sales, purchases, inventory, debts, expenses, and partner profit distribution, with AI-powered reports.

**Status:** In active development, now starting to be used in the shop.

## Features

- **Sales and purchases:** invoices, products, customers, suppliers
- **Debts and expenses:** track what is owed and what is spent
- **Partners:** profit distribution by share percentage, with automatic re-balancing when a partner is added or changed
- **Dashboard:** KPIs and charts
- **AI reports:** ask a question in natural language, and it is converted to a safe SQL query (3 security layers)
- **Audit log:** tracks changes across the system

## Tech Stack

- C# WinForms (.NET)
- SQL Server
- N-Tier architecture (Presentation / Business / Data Access)
- Stored procedures with Table-Valued Parameters (TVPs)
- 22-table relational schema

## Architecture

```
AlMaher/
├── Presentation/     # WinForms UI
├── Business/         # Business logic
├── DataAccess/       # Database access layer
└── DTO/              # Data Transfer
```

## Getting Started

1. Clone the repo
```
   git clone https://github.com/AnasAlkhalil14/PosAndAccountant
```
2. Run the SQL script File in `Database/` on your SQL Server instance.
3. Set your connection string in `App.config`.
4.Copy secrets.config.example to secrets.config and add your Gemini API key. This is only needed for AI reports.
5. Open the solution in Visual Studio and run.

## Roadmap

- [ ] Roles and permissions (in progress)
- [ ] Backup and restore (in progress)
- [ ] Barcode support (in progress)
- [ ] AI invoice capture for purchases (planned)

## Author

**Anas Alkhalil**
Information Engineering student, University of Homs

[LinkedIn](https://linkedin.com/in/anas-alkhalil) · [GitHub](https://github.com/AnasAlkhalil14)
