# dotnet_Csharp_console_app_series
.NET C# console dotnet C sharp .Net dot net


Melhorias:

1ª - na versão inicial, o programa finalizava execução caso usuário pressionasse qualquer tecla diferente das esperadas (mesmo que fosse por engano). Agora ele exibe qual tecla foi pressionada além de informar quais as opções são válidas.

2ª – antes de sair o programa exibe uma contagem regressiva com uma mensagem de agradecimento.

3ª - SUGESTÃO DE SÉRIE. caso o usuário não saiba o que assitr no seu tempo livre, eu implementei um método que faz uma sugestão de Série que que pode ser vista. Ele funciona da seguinte forma:
    
    - Existe uma lista interna de séries de sucesso

    - com base em um número aleatório o sistema busca na lista e sugere uma Série para usuário


OBS.: se estiver desenvolvendo este projeto, e quiser rodar o teste em outro terminal diferente do incluso na sua IDE, faça o seguinte: no arquivo launch.json da pasta .vsconde adicionar e substituir o seguinte trecho:

    Trecho Original:

    "console": "internalConsole",
    "stopAtEntry": false

    Trecho Modificado:

    "console": "externalTerminal",
    "stopAtEntry": false,
    "internalConsoleOptions": "openOnSessionStart"


Projeto de aprendizado no Bootcamp LocalizaLabs .NET Developer da Digital Innovation One - DIO

Criando um APP simples de cadastro de séries em .NET

Aprenda como criar um algoritmo simples de cadastro de séries para praticar seus conhecimentos de orientação a objetos, o principal paradigma de programação utilizada no mercado. Nesse projeto você vai aprender: Como pensar orientado a objetos, como modelar o seu domínio, como utilizar recursos de coleção.