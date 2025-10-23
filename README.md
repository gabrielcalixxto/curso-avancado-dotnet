# MyRecipeBook API (apenas formação de estrutura de API no padrão DDD)

**MyRecipeBook** é uma **API RESTful** desenvolvida em **.NET 9**, estruturada segundo os princípios do **Domain-Driven Design (DDD)**. O projeto é organizado em camadas para facilitar manutenção, escalabilidade e separação de responsabilidades.

---

## 📁 Estrutura do Projeto

- **API**: expõe os endpoints REST para consumo de clientes (mobile, web, etc.)  
- **Application**: contém a lógica de aplicação e serviços, servindo de ponte entre API e Domain  
- **Domain**: entidades, regras de negócio e contratos fundamentais do sistema  
- **Infrastructure**: implementações de persistência e integração com recursos externos  
- **Shared**: componentes reutilizáveis, como DTOs, exceções e comunicação entre camadas

---

## ⚙️ Tecnologias e Padrões Utilizados

- **.NET 9 Minimal API / Controllers**
- **C# 12**
- **Arquitetura DDD (Domain-Driven Design)**
- **Swagger / OpenAPI** para documentação e teste dos endpoints
- **JSON** para troca de dados
- Possibilidade de consumo por apps mobile (Xamarin, MAUI, Flutter) ou clientes web

---

## 🚀 Funcionalidades Principais

- Teste de API pelo no endpoint /recipe

---

## 🛠️ Como Rodar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/MyRecipeBook.git
cd MyRecipeBook/src/Backend/MyRecipeBook.API
