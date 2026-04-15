# 💳 Sistema de Processamento de Pagamentos

Aplicação console em C# que simula um sistema de pagamentos, permitindo processar pagamentos via **Cartão** ou **Boleto**.

---

## 👥 Integrantes

- Arthur Cotrick Pagani RM554510 
- Diogo Leles Franciulli RM558487 
- Felipe Sousa de Oliveira RM559085 
- Ryan Brito Pereira Ramos RM554497 
- Vitor Chaves RM557067 

---

## 📁 Estrutura do Projeto

```
SistemaPagamentos/
├── Models/
│   ├── Pagamento.cs           # Classe base abstrata
│   ├── PagamentoCartao.cs     # Pagamento via cartão
│   └── PagamentoBoleto.cs     # Pagamento via boleto
├── Services/
│   └── PagamentoService.cs    # Serviço de processamento
├── UI/
│   └── Menu.cs                # Classe estática de menu
└── Program.cs                 # Ponto de entrada
```

---

## 🧱 Arquitetura e POO

### Herança e Abstração
- `Pagamento` é uma **classe abstrata** com o método `ProcessarPagamento()` abstrato.
- `PagamentoCartao` e `PagamentoBoleto` **herdam** de `Pagamento` e implementam o método com comportamento específico.

### Encapsulamento
- Propriedades com `get`/`set` em todas as classes.
- Lógica de processamento encapsulada dentro de cada modelo.

### Polimorfismo
- O `PagamentoService.Executar()` recebe um objeto `Pagamento` (tipo base) e chama `ProcessarPagamento()` — o método correto é resolvido em tempo de execução.

### Classe Estática
- `Menu.ExibirMenu()` é implementada como exigido: classe estática com método estático.

---

## 🔢 Tipos de Dados Utilizados

| Campo            | Tipo       | Justificativa                                      |
|------------------|------------|----------------------------------------------------|
| `Valor`          | `decimal`  | Precisão para valores monetários (sem arredondamento de ponto flutuante) |
| `DataPagamento`  | `DateTime` | Representação adequada de data e hora              |
| `NumeroCartao`   | `string`   | Identificador alfanumérico com formatação          |
| `CodigoBarras`   | `string`   | Sequência longa de dígitos, sem operações aritméticas |
| Opção do menu    | `string`   | Entrada do console lida como texto                 |
