double altura, peso, resultado;

Console.WriteLine("\n----CALCULADORA IMC----\n");


Console.Write("Digite a altura (m): ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso (kg).: ");
peso = Convert.ToDouble(Console.ReadLine());

resultado =  peso / Math.Pow(altura,2);

Console.Write($"\nIMC: ");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write($"{resultado:N1} ");
Console.ResetColor();

Console.WriteLine("kg/m²\n");

