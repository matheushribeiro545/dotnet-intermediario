**Stack, Heap e Garbage Collector**

- Valor (computação): sequência de bits, que é denominada de acordo com o tipo de dados. É possível que a mesma quantidade de bits tenha valores diferentes, dependendo do tipo usado.

- Stack e Heap: tipo de memória, que armazena variáveis/objetos
  
  - Objetos simples, do tipo int, string, boolenas etc. ficam no Stack apenas;
  
  - Para objetos complexos (ex. classes, interfaces), o armazenamento será no Stack, com referência para o Heap;
  
  - Quando se termina o método, a memória Stack é limpada, no modelo LIFO.

- Garbage Collector (GB): Limpa os objetos da memória Heap que estão sem referência

- Tipos de referência
  
  - Utilizado em objetos complexos, ex.: classes
