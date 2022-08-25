namespace Variaveis
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 1;
        
        static void Main(string[] args)
        {
            int i = 1;
            var x = 1;
            string s = "Edilson";
            Console.WriteLine($"\n{i}\n{x}\n{s}");

            double f = 1.5f;
            double f2 = 1.5f;
            Console.WriteLine($"{f}\n{f2}");

            bool bo = true;
            bool boo2 = false;
            bool boo3 = bool.Parse("false");
            bool boo4 = Convert.ToBoolean("false");
            Console.WriteLine($"{bo}\n{boo2}\n{boo3}\n{boo4}");

            Leao l = new Leao();
            Console.WriteLine(l.Urrar());
            TratarSaidaPrograma();

        }

        public static void TratarSaidaPrograma()
        {
           while (true)
           {
                Console.WriteLine($"Digite {SAIDA_PROGRAMA} para sair do programa");
                var inputEntrada = Console.ReadLine();
                if (int.TryParse(inputEntrada, out int number1)) {
                    Console.WriteLine(number1);
                    if (number1 == SAIDA_PROGRAMA)
                    {
                        break;
                    }
                }
           } 
        }
    }

    public abstract class Animal
    {
       public abstract string Urrar();
    }
    public class Leao : Animal
    {
       public override string Urrar()
       {
            return "Au au au";
       }
        
    }
}