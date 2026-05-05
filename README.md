# Desafio Técnico: Verificador de Palíndromos

Este projeto é uma aplicação Console desenvolvida em **C# / .NET** que tem como objetivo identificar se uma string de entrada é um palíndromo.

## 🚀 O Desafio
O objetivo foi criar um algoritmo que verifique se uma palavra ou frase é igual quando lida de frente para trás e vice-versa, sem utilizar métodos prontos de manipulação de strings, como o `.Reverse()`.

## 🛠️ Solução e Decisões Técnicas

Para este desafio, utilizei a técnica de **Dois Ponteiros (Two Pointers)**, que é a abordagem mais eficiente em termos de performance ($O(n)$):

1.  **Normalização:** O código remove caracteres não alfanuméricos e converte o texto para letras minúsculas. Isso garante que frases como *"O lobo ama o bolo"* sejam identificadas corretamente, ignorando espaços e diferenciação entre maiúsculas/minúsculas.
2.  **Lógica de Comparação:** Em vez de inverter a string (o que ocuparia o dobro de memória), o algoritmo utiliza dois marcadores: um no início e outro no fim, comparando os caracteres em direção ao centro.
3.  **Eficiência:** O processo para assim que uma diferença é encontrada ou quando os ponteiros se cruzam, percorrendo no máximo metade da string.

## 💻 Como executar

1. Certifique-se de ter o **SDK do .NET** instalado.

2. Clone o repositório:
   ```bash
   git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)

3. Navegue até a pasta do projeto e execute:

Bash
dotnet run


## 🛠️ Tecnologias
- C#
- .NET (Console Application)
- Visual Studio 2022   
