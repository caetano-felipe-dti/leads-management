# Projeto Fullstack (.NET 6 + EFCore e React)

Este projeto consiste em um backend desenvolvido com .NET 6 e Entity Framework Core, e um frontend utilizando React. Siga as instruções abaixo para configurar e executar o ambiente local.

---

## Backend (.NET 6 + EFCore)

### Passos para configuração:
1. **Clone o repositório**:
git clone https://github.com/seu-repositorio/backend.git
cd leads-management
Configure o banco de dados:
Verifique o arquivo appsettings.json para configurar a string de conexão com o banco de dados.
Execute as migrações do Entity Framework Core:
dotnet ef database update
Inicie o servidor:
cd API
dotnet run
O servidor estará disponível em http://localhost:5000 (ou outra porta configurada).

Frontend (React)
Passos para configuração:
Acesse a pasta do frontend:
Após clonar o repositório no passo anterior, navegue até a pasta do frontend:
cd frontend
Instale as dependências:
npm install
Inicie o servidor de desenvolvimento:
npm start
O frontend estará disponível em http://localhost:3000.
