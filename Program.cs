 using estagio.Fibonacci;
 using estagio.IndentificadoA;
 using estagio.SomaVariavel;
 using estagio.MultiplicacaoElementos;

   Console.WriteLine("1- Fabonacci: exercicio 1");
   Console.WriteLine("2- Verificar as Letras: exercicio 2");
   Console.WriteLine("3- Soma da variavel: exercicio 3");
  Console.WriteLine("4- Multiplicaçao de elementos: exercicio 4");
  
   int opcao = int.Parse(Console.ReadLine());

 switch(opcao) 
 {
  case 1:
  Console.WriteLine("\nSequência de Fibonacci");

    Console.WriteLine("Digite o elemento para ver se pertence a Fabonacci");
      Console.WriteLine("Digite o numero do elemento");
         int n = int.Parse(Console.ReadLine());

          var numero = new Fibonacci();
         numero.Teste(n);
        
        
    break;
  case 2:
    Console.WriteLine("\nSequência de Letras A");

    Console.WriteLine("Digite a palavra para verificar a quantidade de Letras A");
        string palavras = Console.ReadLine();

          var palavra = new Letras();
            palavra.Teste(palavras);
    break;
      case 3:
       var soma = new SomaVariavel();
       soma.SomaVariaveis();
         break;
             case 4:
           Console.WriteLine("                               "); 
          Console.WriteLine("1-Soma de nos 2 numeros impares"); 
          Console.WriteLine("2-Multiplicaçao do numero da frente por 2;"); 
          Console.WriteLine("3-soma por numeros apenas impares ;"); 
         Console.WriteLine("4-Numeros pares elevado a 2;;");  
         Console.WriteLine("5- Fibonacci;");  
         
         Console.WriteLine("                    "); 
         int opcao2 = int.Parse(Console.ReadLine());
          switch (opcao2)
          {
           case 1:
          var somaElementos = new MultiplicacaoElementos();
            somaElementos.SomaDosNumerosImparesPor2();
         break;
          case 2:
           var multElementos = new MultiplicacaoElementos();
            multElementos.MultNumerosAnteriorPor2();
         break;
           case 3:
           var somaElementosImpares = new MultiplicacaoElementos();
            somaElementosImpares.SomaNumerosAnteriorPorImapares();
         break;
          case 4:
           var multNumerosParAoQuadrado = new MultiplicacaoElementos();
            multNumerosParAoQuadrado.MultNumerosParAoQuadrado();
         break;
          case 5:
           var fibonacci = new MultiplicacaoElementos();
           fibonacci.Fibonacci();
         break;
          
          }

         break;
         
  default:
    // code block
    break;
}
