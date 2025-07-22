namespace A02;
/* 
int: Números inteiros (ex: 10, -5, 0) 
double: Números de ponto flutuante(ex: 3.14, -2.5)
float: Números de ponto flutuante menores que double (ex: 1.5f, -0.7f) 
char: Caracteres(ex: 'a', 'Z', '!')
bool: Valores booleanos(true ou false)
string: Sequências de caracteres(textos)  
*/

public class Program
{
    public static void Main()
    { 
        var nome = "João"; // Variável do tipo string
        nome = "Maria";
        Console.WriteLine(nome);

        var idade = 30; // Variável do tipo int
        idade = 25;
        Console.WriteLine(idade);

        var altura = 1.65; // Variável do tipo double
        altura = 1.67;

        var peso = 70.5f; // Variável do tipo float
        peso = 68.0f;

        var inicial = 'J'; // Variável do tipo char
        inicial = 'M';

        var ativo = true; // Variável do tipo bool
        ativo = false;

        // Exibindo os valores

        Console.WriteLine("O usuario chamado(a): " + nome + " Tem a inicial: " + inicial);
        Console.WriteLine("Tem: " + altura + " metros de altura");
        Console.WriteLine("Tem: " + peso + " kg");
        Console.WriteLine("Tem: " + idade + " anos");
        Console.WriteLine("Está ativo: " + ativo);
    }
}