using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio.IndentificadoA
{
    public class Letras
    {

        public Letras (){
        
      }

       public string palavra ;
       public bool pertence = false;
        public int soma ;
      public void Teste (string palavra){

           char[] ch = new char[palavra.Length]; 
    
        // Copy character by character into array 
        for (int i = 0; i < palavra.Length; i++) { 
            ch[i] = palavra[i]; 
            if(ch[i] == 'a' || ch[i] == 'A')
            {
                soma = soma + 1;
            }
        } 
          
          if(soma > 0){
            Console.WriteLine("A palavra possui a Letra A");
            Console.WriteLine("A quantidade de letras A é : " + soma);
          }
          else{
           Console.WriteLine("Não possui a letra A");
          }
         
                            
        
    }
    }  
}