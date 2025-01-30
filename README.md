# 🍕 Sistema de Pedidos de Pizzaria  

Um sistema para gerenciamento de pedidos de pizza, desenvolvido em **.NET Framework 4.8**, focado na separação da lógica de negócios e na implementação de testes unitários eficientes.  

---

## 🛠️ Funcionalidades  

- **Cadastro de Pizzas**  
  Adicione novas pizzas ao sistema com nome e tempo de preparo.
  
  ![Descrição da imagem](../Sistema_Pizzaria/Src/imagem3.PNG)

- **Cálculo do Tempo de Pedido**  
  Determine o tempo total de um pedido com base nos sabores selecionados.

  ![Descrição da imagem](../Sistema_Pizzaria/Src/imagem4.PNG)
- **Autenticação e Autorização (JWT)**  
  Implementação de autenticação baseada em **JSON Web Token (JWT)** para proteger endpoints da API.

    ![Descrição da imagem](../Sistema_Pizzaria/Src/imagem1.PNG)
  
  Validação do Token após Login do usuario e senha.

    ![Validação do Token](../Sistema_Pizzaria/Src/imagem2.PNG)

- **Validação de Sabores**  
  Garante que todas as pizzas do pedido existam no sistema.  

- **Testes Unitários**  
  Verifica se o cálculo do tempo total do pedido está correto.

  <img src="/Src/imagem5.PNG" alt="Print Testes Unitarios" width="1000" height="400">


    
---

## 💻 Tecnologias Utilizadas  

- **.NET Framework 4.8**  
- **C#**  
- **xUnit/NUnit** (Testes Unitários)  
- **Entity Framework** (Persistência de Dados)  
- **SQL Server**  

---

## 🔗 Estrutura do Projeto  

- **Controllers (API):** Gerencia as requisições dos pedidos.  
- **Services (Regras de Negócio):** Processa os cálculos de tempo e validações.  
- **Data (Persistência):** Gerencia as pizzas cadastradas no banco de dados.  
- **Tests (Testes Unitários):** Garante que as regras de negócio estão corretas.  

---

## 📋 Roteiro  

### **1. Planejamento**  
- Definir os requisitos e fluxos do sistema.  
- Modelar a estrutura do banco de dados.  

### **2. Desenvolvimento**  
- Criar a API para manipulação dos pedidos.  
- Implementar a camada de serviços para regras de negócio.  
- Desenvolver os testes unitários.  

### **3. Entrega**  
- Código organizado e documentado.  
- Banco de dados configurado e pronto para uso.  

---

## ✅ Critérios de Avaliação  

1. **Funcionalidade:** O cálculo de tempo deve ser preciso.  
2. **Qualidade do Código:** Estrutura modular e bem organizada.  
3. **Testes:** Cobertura adequada para regras de negócio.  
4. **Documentação:** Instruções claras para execução do projeto.  
