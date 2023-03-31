# Introdução

Esse projeto visa fornecer uma ***classlibrary*** que facilite a tarefa de acessar a API do sistema [e-Aud](https://eaud.cgu.gov.br). O acesso à API do e-Aud é útil em diversos cenários diferentes, e alguns desses cenários são exemplificados em ***notebooks*** dentro da pasta Exemplos. 

# Configurando o Ambiente

Para iniciar no usod desse cliente, você deve primeiramente instalar o dotnet-sdk versão 7.0 ou superior. O link para baixar os arquivos de instalação pode ser encontrado [aqui](https://dotnet.microsoft.com/en-us/download). Depois de instalar o SDK, vc terá à sua disposição a ferramenta de linha de comando ***dotnet***. 

Para usar essa classlibrary em notebooks interativos, você precisará instalar o [***dotnet-interactive***](https://www.nuget.org/packages/Microsoft.dotnet-interactive). Para tanto, basta executar o seguinte comando dotnet **dotnet tool install --global Microsoft.dotnet-interactive --version 1.0.416502**.

Os notebooks dentro da pasta Exemplos estão no formato **dib**. Para editá-los, recomendamos o uso do Visual Studio Code com as extensões C# e Polyglot instaladas.

Esse cliente obtém a chave de acesso a partir de uma variável de ambiente. Assim, antes de abrir o visual studio code, crie uma variável de ambiente em seu sistema com o nome "CHAVE_EAUD" e com o valor da sua chave de acesso à api. No windows, isso pode ser feito em "Variáveis de ambiente para o usuário". No linux, isso pode ser feito editando-se o arquivo .bash_profile.

É possível também usar o ambiente de treinamento. Para isso, gere uma chave de acesso à API naquele ambiente, e coloque-a na variável de ambiente "CHAVE_EAUD_T".

