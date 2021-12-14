-PROGRAMAÇÃO ORIENTADA A OBJETOS --
A POO é um dos varios paradigmas que existem no mercado1 


-Paradigma de programação: Técnica, metodologia, maneira de fazer.
Metodologia: aproximar o mundo real da programação. 
Se aproxima muito da vida real. 

-Abstração
-Encapsulamento
-Herança
-Polimorfismo

O principal conceito são as classes e os objetos.
classes - uma abstração do mundo real. 
objetos - é a instância de uma classe. 

----------tipos de paradigmas existentes--------------
Conjunto de técnicas regras e modelos para você trabalhar.
Linguagem != Paradigma. 

*POO
-Programação Estruturada.
-P. imperativa
-P. procedural.
-P. Orientada a Eventos.
-P. Lógica. 

E por ai vai! 

Uma linguagem pode se utilizar de varios paradigmas. 

--------entendendo Abstração-------------------------
Os pilares da POO sao independentes um do outro: 

-Abstração
-Encapsulamento
-Herança (COM EXCESÇÃO DA HERENÇA E DO POLIMORFISMO)
-Polimorfismo

****Abstração: Abstrair um objeto da vida real para a programação. 
considerando apenas os atributos importantes! 

****Encapsulamento: Serve para proteger uma classe e definir limites
para alteração de suas propriedades. 

Serve para ocultar o seu comportamento e expor somente
o necessário. 

*public = qualquer um pode fazer alteração. 
*private = somente a própria classe pode alterar.
*protected
*internal = somente alterado em herança com classes filhas.


****Herança: 
Nos permite herdar atributos métodos e comportamento de uma 
classe em outras classes.

Classes derivadas de outras classes.
Classe pai, classe filho...

Agrupar objetos do mesmo tipo com comportamentos diferentes.

Pessoa. 
Aluno e Professor. 
Não temos limite de herança. 


Polimorfismo. 
polimorfismo vem do grego "Muitas formas" 
com o polimorfismo, podemos sobreescrever metodos das 
classes para que se comportem de maneira diferente e 
ter sua própria implementação. 
Trazer o método para funcionar de uma forma mais especializada. 

polimorfismo em tempo de compilação (Overload/Early Binding) 

Polimorfismo em tempo de execução (Override/ Late Binding)


--Classe Abstrata --
Não se pode instanciar uma classe Abstrata 
Exclusivamente um modelo. 
A unica função é ser Herdada. 
Posso ter um método abstrato. 

--Classe Selada -- 
Uma classe selada 
Impedir que outras classes derivem dela.
Ponto final da herança
nao pode possuir classes filhas.
Metodos e Atributos selados.

--Classe System.Object --
Mãe de todas as classes do mundo .NET
Tudo que existe na classe C# herda dessa classe.
Prover serviços de baixo nivel para suas classes.

--INTERFACES-- 
UMA INTERFACE É UM CONTRATO QUE PODE SER IMPLEMENTADO 
POR UMA CLASSE
MUITO SEMELHANTE A UMA CLASSE ABSTRATA.
PODE DEFINIR METODOS ABSTRATOS OU NÃO. 
NÃO PODE SER INSTANCIADA. 
NO C# NAO EXISTE O CONCEITO DE HERANÇA MULTIPLA.
UMA CLASSE DERIVA DE UMA CLASSE APENAS.

COM INTERFACES ESSE CONCEITO É DIFERENTE.
POSSO TER UMA CLASSE QUE IMPLEMENTA MULTIPLAS INTERFACES.

A INTERFACE VEIO PARA SUBSTITUIR ESSE CONCEITO DE
HERANÇA MULTIPLA. 

antes do .NET 8 Não era possivel ter uma interface com
implementação de métodos. 



-ARQUIVOS! 
CLASSES ESTÁTICAS. 
fILE - MANIPULAR ARQUIVOS, CRIAR, MOVER, APAGAR..
DIRECTORY - OPERAÇÕES COM DIRETORIOS, NOMEAR DIRETORIOS.
PATH - ORGANIZAR CAMINHOS DE UMA MANEIRA LÓGICA. 



