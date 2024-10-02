using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu primeiro nome?");
        string? name = Console.ReadLine();

        Console.WriteLine("Digite o seu sobrenome?");
        string? lastName = Console.ReadLine();

        //Exercício 01
        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");

        //Exercício 02
        Console.WriteLine($"Seu nome completo é {name} {lastName}");

        //Exercício 03
        Console.WriteLine("Digite o primeiro valor:");
        float? value1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        float? value2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma dos valores é: {value1 + value2}");
        Console.WriteLine($"A subtração dos valores é: {value1 - value2}");
        Console.WriteLine($"A multiplicação dos valores é: {value1 * value2}");
        Console.WriteLine($"A divisão dos valores é: {value1 / value2}");
        Console.WriteLine($"A média dos valores é: {((value1 + value2) / 2)}");

        //Exercício 04
        Console.WriteLine("Digite um texto:");
        string? text = Console.ReadLine();

        Console.WriteLine($"O texto digitado possui {text.Length} caracteres");

        //Exercício 05
        Console.WriteLine("Digite a placa do veículo:");
        string? vehicleLicensePlate = Console.ReadLine();

        string signLetters = vehicleLicensePlate.Substring(0, 3);
        string plateNumbers = vehicleLicensePlate.Substring(3, 4);

        bool isValidSignLetters = signLetters.All(char.IsLetter);
        bool isValidPlateNumbers = plateNumbers.All(char.IsDigit);

        if (isValidSignLetters && isValidPlateNumbers)
        {
            Console.WriteLine("Placa válida");
        }
        else
        {
            Console.WriteLine("Placa inválida");
        }

        //Exercício 06
    }
}