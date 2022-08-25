namespace Classes
{
    namespace Calculo
    {
        class MediaNota
        {
            public static void CalcularMediaNotas() {
                Console.Write("Informe as notas separadas por virgulas:");
                var inputNotas = Convert.ToString(Console.ReadLine());
                if (String.IsNullOrEmpty(inputNotas)) {
                    CalcularMediaNotas();
                    return;
                }
                List<string> strNums = inputNotas.Split(new[] { ',', '\\', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Console.WriteLine(strNums[0],strNums.Count());
                if (strNums.Count() <= 0)
                {
                    CalcularMediaNotas();
                    return;

                }
                Decimal[] decimals = strNums.Select(n => Convert.ToDecimal(n)).ToArray();
                Console.Write($"A média das notas é: {Math.Round(decimals.Average(), 2)}");
            }
        }
    }
}