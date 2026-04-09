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

      Console.WriteLine("Insira um numero para calcular o factorial: \n");

      int num = Convert.ToInt32(Console.ReadLine());

      

    }

public int factorial(int n)
    {
       if (n == 0 || n == 1)
        {
            return 1;

        }else if (n < 0)
        {
          Console.WriteLine("Insira um numero positivo")  ;
        }

        else
        {
            return n * factorial(n-1);
            
        }

    }


  }
/*

   public int CalculateFactorial(int n) {
         if (n == 1)
            return 1;
         else
            return n * CalculateFactorial(n - 1);
      }
      static void Main(string[] args) {
         int value = 5;
         int ret;
         Factorial fact = new Factorial();
         ret = fact.CalculateFactorial(value);
         Console.WriteLine("Factorial of " + value + " = " + ret);



*/


  /*def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n - 1)

# Example usage
result = factorial(5)
print(result)  # Output: 120 */

