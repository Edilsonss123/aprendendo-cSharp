namespace Classes
{
    namespace Calculo
    {
        class Tabuada
        {
            public static void CalcularTabuada() {
                Console.Write("Informe a tabuada desejada:");
                var inputNumeroTabuada = Console.ReadLine();
                if (int.TryParse(inputNumeroTabuada, out int numeroTabuada)) {
                    Calcular(numeroTabuada);
                }
            }

            private static void Calcular(int numero)
            {
                Console.WriteLine("Tabuada\n\n");
                for (var i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero*i}");
                }
            }
        }
    } 
}
