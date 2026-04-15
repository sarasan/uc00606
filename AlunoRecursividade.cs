
namespace ExerciciosAula02B;
  public class AlunoRecursividade
  {
    public void Executar()

    {
      
      Console.WriteLine("==================================\n");
      Console.WriteLine("\n\n 1. EXERCÍCIOS DE RECURSIVIDADE");
      Console.WriteLine("==================================\n");

      Console.WriteLine("==================================\n");
      Console.WriteLine("\n\n  EXERCÍCIO 5: Factorial Simulado (Recursivo)");
      Console.WriteLine("==================================\n");

      Console.WriteLine("Insira um numero inteiro positivo para calcular o factorial: \n");

      int num = Convert.ToInt32(Console.ReadLine());

      if (num < 0)
        {
            Console.WriteLine(" Erro: Não é possível calcular factorial de número negativo!\n");
        }

        else

        {
         int resultado = CalculaFactorial(num);

         Console.WriteLine("Factorial de:  " + num + " = " + resultado);
         
        }
         Console.WriteLine();



      Console.WriteLine("==================================\n");
      Console.WriteLine("\n\n EXERCÍCIO 3:Sequência de Fibonacci (Recursivo)");
      Console.WriteLine("==================================\n");

   

      Console.WriteLine("Insira o numero da posiçao na sequencia pretendida: \n");

      int pos = Convert.ToInt32(Console.ReadLine());

      if (pos < 0)
        {
            Console.WriteLine(" Erro: Não é possível verificar com número negativo!\n");
        }
        else

        {
         int resultado = Fibonnaci(pos);

         Console.WriteLine("posiçao de:  " + pos + " = " + resultado);
         
        }
         Console.WriteLine();

/////////////////////////////
    Console.WriteLine("==================================\n");
    Console.WriteLine("\n\n EXERCÍCIO 4: Verificador de Palíndromo (Recursivo)");
    Console.WriteLine("==================================\n");

    bool pld;

    string str;

    Console.WriteLine("Insira uma palavra ou frase para verificar se e palindromo: \n");

    str = Console.ReadLine();

    pld = Palindromo(str);

    if (pld == true)
        {
        Console.WriteLine($"{str}  Palindromo.\n");
        }
    else
        {
        Console.WriteLine($"{str} Nao e Palindromo.\n");
        }
        Console.WriteLine();
    }

     
/////////methods///////////
   public int CalculaFactorial(int num) {
         if (num == 1 || num ==0)
            return 1;
         else
            return num * CalculaFactorial(num - 1);
      }

  public int Fibonnaci(int num) {
         if (num == 1 || num == 0)
            return 1;
         else
            return (Fibonnaci(num - 2) + Fibonnaci(num- 1));
      }

   
public static bool Palindromo(string str) {

    
    if(str.Length <= 1)
        {
           return true; 
        }
        else if (str[0] != str[str.Length - 1])
            {
                return false;
            }
            else
            {
                return Palindromo(str.Substring(1, str.Length -2));
            }
        }
    
    }

  



  








  


