//Crear un programa que lea dos números y que escriba el mayor de los dos.

internal class Program
{
    private static void Main(string[] args)
    {
        int num1; int num2;
        Console.WriteLine("Digite el primer número");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el segundo número");
        num2 = int.Parse(Console.ReadLine());

        if(num1 > num2)
        {
            Console.WriteLine("El mayor es: "+num1);
        }
        else
        {
            Console.WriteLine("El mayor es: "+num2);
        }
    }
}