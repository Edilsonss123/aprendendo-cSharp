namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var a  = 11;
            if (a==1) {
                Console.WriteLine("Entrou no if");
            } else if (a==2) {
                Console.WriteLine("Entrou no elseif");
            }else {
                Console.WriteLine("Entrou no else");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Case Default");
                    break;
            }
            
            var b = (a == 1) ? "O valor de a": "mais um";
            Console.WriteLine(b);
        }
    }
}