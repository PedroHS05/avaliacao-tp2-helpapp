# 📘 Avaliação Técnica – Clean Architecture + Azure SQL

Este repositório contém minha entrega referente à avaliação técnica baseada no repositório original do professor:  
[https://github.com/victoricoma/avaliacao-tp2-helpapp](https://github.com/victoricoma/avaliacao-tp2-helpapp)

---

## ✅ Objetivo

Implementar os repositórios `Category` e `Product` seguindo os padrões da Clean Architecture, aplicar a migration `Initial` e conectar a aplicação com uma instância de SQL Server no Azure.

---

## 🚀 Funcionalidades implementadas

- [x] Repositórios `CategoryRepository` e `ProductRepository`
- [x] Configurações com `EntityTypeConfiguration` para `Category` e `Product`
- [x] Injeção de dependência configurada (`DependencyInjectionAPI`)
- [x] Migration `Initial` criada com `HasData()` para categorias
- [x] Banco de dados SQL Server criado localmente no SQL Server Manager Studio
- [x] Migration aplicada com sucesso no SSMS via `dotnet ef database update`

---
## 🔧 Comandos utilizados

Criação da migration
° dotnet ef migrations add Initial --project HelpApp.Infra.Data --startup-project HelpApp.API

Aplicação local da migration
° Update-Database -Project HelpApp.Infra.Data -StartupProject HelpApp.API

🔗 String de conexão (Local)
"ConnectionStrings": {
  "DefaultConnection": "Data Source=DESKTOP-HT5FAOF\\SQLEXPRESS;Initial Catalog=HelpAppDb;Integrated Security=True;TrustServerCertificate=True;"
}

💾 Configuração Local
SQL Server Express instalado localmente
Banco de dados nomeado: HelpAppDb

Migration aplicada com sucesso diretamente do Visual Studio Terminal (terminal nuget manager)

# 👨‍💻 Dados do aluno
Nome: Pedro Henrique Scabelo
Curso: Desenvolvimento de Sistemas – 3º Semestre

Professor: Victor Icoma

Branch da entrega: avaliacao-PedroHS05

## 🧱 Estrutura da aplicação

```bash
📦 HelpApp
 ┣ 📂 HelpApp.Domain
 ┃ ┣ 📂 Entities
 ┃ ┗ 📂 Interfaces
 ┣ 📂 HelpApp.Application
 ┣ 📂 HelpApp.Infra.Data
 ┃ ┣ 📂 Context
 ┃ ┣ 📂 Migrations
 ┃ ┣ 📂 Repositories
 ┃ ┗ 📂 EntitiesConfiguration
 ┣ 📂 HelpApp.Infra.IoC
 ┗ 📂 HelpApp.API

