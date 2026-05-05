# 🚀 Desafios de Lógica: Algoritmos com C#

Este repositório contém a implementação de três desafios clássicos de lógica de programação, desenvolvidos em **C# (.NET 8)**. O objetivo deste projeto é demonstrar o domínio de fundamentos da computação, manipulação de strings e eficiência algorítmica.

O projeto utiliza uma interface de menu interativo via Console para facilitar a navegação entre as soluções.

---

## 🛠️ Desafios Implementados

### 1. Verificador de Palíndromos
*   **Objetivo:** Verificar se uma palavra ou frase é um palíndromo (lida da mesma forma de trás para frente).
*   **Regra de Ouro:** Implementado sem o uso de métodos prontos como `.Reverse()`.
*   **Técnica:** Utilização da abordagem de **Dois Ponteiros (Two Pointers)**, comparando as extremidades em direção ao centro para garantir performance $O(n)$ e economia de memória.
*   **Diferencial:** Normalização manual para ignorar espaços e caracteres especiais.

### 2. Sequência de Fibonacci
*   **Objetivo:** Gerar os primeiros $X$ elementos da sequência de Fibonacci, onde cada número é a soma dos dois anteriores.
*   **Diferencial:** Implementação focada em evitar o uso desnecessário de coleções, utilizando apenas variáveis de estado para manter a sequência fluida e eficiente.

### 3. Normalizador de Texto ("Grito")
*   **Objetivo:** Tratar strings com excesso de pontuações de exclamação e interrogação (ex: "Como é??????" -> "Como é?").
*   **Técnica:** Utilização de `StringBuilder` para a reconstrução da string, garantindo que pontuações repetidas sejam reduzidas a um único caractere, enquanto combinações como `?!` sejam preservadas.
*   **Foco Técnico:** Otimização de alocação de memória ao manipular strings mutáveis.

---

## 💻 Como Executar

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)

3. Navegue até a pasta do projeto e execute:
```
dotnet run
```

---

## 🧑‍💻 Autor

**Herbert Paz Espindola**  
*Junior Full Stack Developer*  
Focado em tecnologias Microsoft (.NET, C#, SQL Server) e desenvolvimento de sistemas ERP.
