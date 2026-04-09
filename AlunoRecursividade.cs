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


    }

    
/////////method///////////
   public int CalculaFactorial(int n) {
         if (n == 1 || n ==0)
            return 1;
         else
            return n * CalculaFactorial(n - 1);
      }

  }


