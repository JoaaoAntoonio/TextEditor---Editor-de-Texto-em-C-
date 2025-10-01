📝 TextEditor - Editor de Texto em C#
Um editor de texto simples feito em C# para console. Permite abrir arquivos existentes para leitura ou criar novos arquivos digitando texto no console.


🚀 Funcionalidades

Menu interativo com opções para:
Abrir arquivo existente (somente leitura)
Criar novo arquivo digitando texto no console
Sair do programa

>Entrada de texto ao criar novo arquivo:
ESC → finaliza a digitação
Enter → cria nova linha
Backspace → apaga o último caractere digitado

>Leitura e escrita de arquivos de texto:
StreamReader → abrir arquivos
StreamWriter → salvar arquivos


📂 Estrutura do Código

Program.cs → contém todo o código do editor:
Menu() → exibe o menu principal e recebe a opção do usuário
Abrir() → lê e mostra o conteúdo de um arquivo existente
Salvar() → salva o texto digitado em um arquivo


✨ Observações

O editor não permite editar arquivos existentes, apenas criar novos textos.
Fácil de estender futuramente, por exemplo, adicionando funcionalidades como busca no texto ou copiar/colar.
