\# Sistema de Gerenciamento de Salas de Reunião



Aplicação desktop desenvolvida em C# com Windows Forms e PostgreSQL para o gerenciamento de salas de reunião e suas reservas.



\## Tecnologias utilizadas



\- C#

\- .NET 10

\- Windows Forms

\- PostgreSQL 18

\- Npgsql



\## Funcionalidades



\### Gerenciamento de salas

\- Cadastro de salas.

\- Consulta e listagem de salas.

\- Pesquisa de salas pelo nome.

\- Ordenação por andar e nome.

\- Paginação de resultados.

\- Alteração e exclusão de salas.



\### Gerenciamento de reservas

\- Cadastro de reservas.

\- Consulta de reservas.

\- Alteração e exclusão de reservas.

\- Associação de reservas às salas cadastradas.

\- Impedimento de reservas com horários conflitantes na mesma sala.



\### Disponibilidade

\- Consulta das horas livres das salas em determinado período.

\- Contagem de reservas cadastradas nos últimos sete dias.



\## Requisitos para execução



\- Windows.

\- PostgreSQL instalado.

\- .NET 10 SDK.

\- Visual Studio com a carga de trabalho de desenvolvimento para desktop com .NET.



\## Configuração da conexão



A aplicação utiliza User Secrets para armazenar a string de conexão, evitando deixar a senha do banco diretamente no código-fonte.



\## Como executar



1\. Clone este repositório:



```bash

git clone https://github.com/leofelix-prog/P2-PlataformaDeDS.git

```



2\. Abra a solução `SalaDeReunioes.slnx` no Visual Studio.

3\. Configure a conexão com o PostgreSQL.

4\. Compile e execute a aplicação pelo Visual Studio.

