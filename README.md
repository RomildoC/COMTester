# Monitor Serial em C# (COMTester)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

Uma aplicação simples e funcional desenvolvida em C# com Windows Forms para monitorar, receber e enviar dados através de portas seriais (COM). Ideal para desenvolvedores, hobistas e engenheiros que trabalham com microcontroladores (Arduino, ESP32), automação industrial e outros dispositivos que utilizam comunicação serial.



## Funcionalidades

-   **Detecção Automática de Portas:** Lista todas as portas COM disponíveis no sistema.
-   **Atualização Dinâmica:** A lista de portas é atualizada automaticamente a cada 5 segundos, detectando novos dispositivos conectados ou desconectados sem a necessidade de reiniciar o programa.
-   **Configuração de Conexão:** Permite selecionar a porta COM e a velocidade de comunicação (Baud Rate).
-   **Visualização em Tempo Real:** Exibe os dados recebidos em um `TextBox` com rolagem, onde cada novo dado é exibido em uma nova linha.
-   **Envio de Dados:** Possui um campo de texto e um botão para enviar strings pela porta serial para o dispositivo conectado.
-   **Limpeza do Log:** Um botão para limpar a tela de dados recebidos.
-   **Interface Intuitiva:** Os controles são habilitados e desabilitados de forma inteligente de acordo com o status da conexão, melhorando a experiência do usuário.

## Tecnologias Utilizadas

-   **C# (.NET Framework)**
-   **Windows Forms** para a interface gráfica.
-   **System.IO.Ports** para a comunicação serial.

## Como Compilar e Executar

### Pré-requisitos

-   **Visual Studio** (2019 ou mais recente)
-   **Carga de trabalho de desenvolvimento para desktop com .NET** instalada no Visual Studio.

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
    ```

2.  **Abra o projeto:**
    - Navegue até a pasta do projeto clonado.
    - Abra o arquivo da solução (`.sln`) com o Visual Studio.

3.  **Compile e Execute:**
    - Pressione `F5` ou clique no botão "Iniciar" no Visual Studio para compilar e executar a aplicação.

## Como Utilizar o Programa

1.  **Selecione a Porta:** Escolha a porta COM correspondente ao seu dispositivo na lista suspensa. Se você conectar um novo dispositivo, aguarde até 5 segundos para que ele apareça na lista.
2.  **Selecione o Baud Rate:** Escolha a mesma velocidade que está configurada no seu dispositivo (ex: 9600, 115200, etc.).
3.  **Conectar:** Clique no botão "Conectar". Os campos de configuração serão desabilitados, e os de envio serão habilitados.
4.  **Receber Dados:** Os dados enviados pelo seu dispositivo aparecerão na caixa de texto principal.
5.  **Enviar Dados:** Digite o texto que deseja enviar na caixa de texto inferior e clique em "Enviar".
6.  **Desconectar:** Ao finalizar, clique em "Desconectar" para liberar a porta COM.

## Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---
Meu Primeiro Projeto em C#
Criado com ❤️ por RomildoC
