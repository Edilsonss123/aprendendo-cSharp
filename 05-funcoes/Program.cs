namespace Funcoes
{
    public class Program {
        public static void Main(string[] args)
        {
            Console.WriteLine(Calcular());
            Tabuada(2);
            LerArquivo(1);
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("Tabuada\n\n");
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
        }
        internal static int Calcular()
        {
            int a = 1;            
            int b = 2;            
            int c = a + b;
            return c;            
        }

        private static void LerArquivo(int numeroSequencialArquivo)
        {
            Console.WriteLine("Lendo Arquivos\n\n");
            string arquivo = @$"./../recursos/arquivo{numeroSequencialArquivo}.txt";
            if (File.Exists(arquivo))
            {
                string text = System.IO.File.ReadAllText(arquivo);
                Console.WriteLine($"Texto arquivo = {text}\n");

                string[] lines = System.IO.File.ReadAllLines(arquivo);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            numeroSequencialArquivo++;
            string proximoArquivo = @$"./../recursos/arquivo{numeroSequencialArquivo}.txt";
            if (File.Exists(proximoArquivo))
            {
                LerArquivo(numeroSequencialArquivo);  
            }
        }

    }
}