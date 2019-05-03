# GymPass
GymPass Code for the interview

This project was developed using the C# language and the .Net Core Framework. The code is in portuguese, since the task is in portuguese, so the evaluator can understand the semantics.

To change the data loaded by the code copy and paste the new data into the file "log.txt" into the root folder.

## Running the code

1. Install [DotNet Core 2.2 Framework](https://dotnet.microsoft.com/download/dotnet-core/2.2 "DotNet Core 2.2 Framework")
2. Open the Command Prompt on the project's folder.
3. Run the following commands:
    - dotnet restore
    - dotnet build
    - dotnet run
    
## Result
1. After running the project there is going to be an file named "resutado.txt" in the root folder formatted as the instructions given in the task.
2. The console is going to present the Bônus tasks.

## The Task

Here is the task proposed

---------------------------------------
PROBLEMA
========
Dado o seguinte log de uma corrida de Kart:

```text
Hora                               Piloto             Nº Volta   Tempo Volta       Velocidade média da volta
23:49:08.277      038 – F.MASSA                           1		1:02.852                        44,275
23:49:10.858      033 – R.BARRICHELLO                     1		1:04.352                        43,243
23:49:11.075      002 – K.RAIKKONEN                       1             1:04.108                        43,408
23:49:12.667      023 – M.WEBBER                          1		1:04.414                        43,202
23:49:30.976      015 – F.ALONSO                          1		1:18.456			35,47
23:50:11.447      038 – F.MASSA                           2		1:03.170                        44,053
23:50:14.860      033 – R.BARRICHELLO                     2		1:04.002                        43,48
23:50:15.057      002 – K.RAIKKONEN                       2             1:03.982                        43,493
23:50:17.472      023 – M.WEBBER                          2		1:04.805                        42,941
23:50:37.987      015 – F.ALONSO                          2		1:07.011			41,528
23:51:14.216      038 – F.MASSA                           3		1:02.769                        44,334
23:51:18.576      033 – R.BARRICHELLO		          3		1:03.716                        43,675
23:51:19.044      002 – K.RAIKKONEN                       3		1:03.987                        43,49
23:51:21.759      023 – M.WEBBER                          3		1:04.287                        43,287
23:51:46.691      015 – F.ALONSO                          3		1:08.704			40,504
23:52:01.796      011 – S.VETTEL                          1		3:31.315			13,169
23:52:17.003      038 – F.MASS                            4		1:02.787                        44,321
23:52:22.586      033 – R.BARRICHELLO		          4		1:04.010                        43,474
23:52:22.120      002 – K.RAIKKONEN                       4		1:03.076                        44,118
23:52:25.975      023 – M.WEBBER                          4		1:04.216                        43,335
23:53:06.741      015 – F.ALONSO                          4		1:20.050			34,763
23:53:39.660      011 – S.VETTEL                          2		1:37.864			28,435
23:54:57.757      011 – S.VETTEL                          3		1:18.097			35,633

```

Resultado esperado
------------------
* A partir de um input de um arquivo de log do formato acima, montar o resultado da corrida com as seguintes informações: **Posição Chegada**, **Código Piloto**, **Nome Piloto**, **Qtde Voltas Completadas** e **Tempo Total de Prova**.

Observações
------------
* A primeira linha do arquivo pode ser desconsiderada (Hora, Piloto, Nº Volta, Tempo Volta, Velocidade média da volta).
* A corrida termina quando o primeiro colocado completa 4 voltas


Bônus
-----
Não obrigatório. Faça apenas caso se identifique com o problema ou se achar que há algo interessante a ser mostrado na solução

**********************************************
* Descobrir a melhor volta de cada piloto
***********************************************
* Descobrir a melhor volta da corrida
************************************************
* Calcular a velocidade média de cada piloto durante toda corrida
************************************************************************
* Descobrir quanto tempo cada piloto chegou após o vencedor



SOLUÇÃO
=======
* A solução poderá ser desenvolvida em qualquer linguagem da sua escolha;
* Seja criativo;
* Uma outra pessoa estará lendo o que você fez, portanto, lembre-se de buscar trazer a semântica do problema no seu código;
* Crie testes;
* Não é necessário utilizar nenhum framework, procure utilizar os recursos da linguagem;


ENTREGA
=======
* **Não** faça um fork desse projeto. Crie um repositório no seu perfil do GitHub e nos envie a url;
* Crie um arquivo SUAS-INSTRUÇÕES.txt para adicionar algum comentário/observação que achar importante;
