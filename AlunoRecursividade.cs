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

      int [] seq = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];

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

      Console.WriteLine("Insira uma palavra ou frase para verificar se palidromo: \n");

            string name = Console.ReadLine();

            string reverse = string.Empty;
            
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            
            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }



    

    
/////////method///////////
   public int CalculaFactorial(int n) {
         if (n == 1 || n ==0)
            return 1;
         else
            return n * CalculaFactorial(n - 1);
      }

  public int Fibonnaci(int n) {
         if (n == 1 || n == 0)
            return 1;
         else
            return n * Fibonnaci(n - 1);
      }

      /* 
      public static int Fibonatchi(int position) {

    if(position == 0) {
        return 1;
    }
    if(position == 1) {
        return 1;
    } else {
        return Fibonatchi(position - 2) + Fibonatchi(position - 1);
    }
}
      
      
      */

      /////////////////////////////////////////////////
      /// 
      /// 
      /// 
// Helper recursive function to check palindrome
public  bool isPalindromeRec(string s, int left, int right) {
    
    // Base case
    if (left >= right) 
        return true;
    
    // If mismatch found
    if (s[left] != s[right]) 
        return false;

    // Recursive call with narrowed range
    return isPalindromeRec(s, left + 1, right - 1);
}

/*bool isPalindrome(string& s) {
    return isPalindromeRec(s, 0, s.size() - 1);*/
}
/*
int main() {
    string s = "abba";
    
    if (isPalindrome(s)) {
        cout << "true" << endl;
    }
    else {
        cout << "false" << endl;
    }

    return 0;
}*/


  


