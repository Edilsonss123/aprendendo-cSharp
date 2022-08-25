namespace ArrayECollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            exemploArray();
            exmploCollection();
        }

        public static void exemploArray()
        {
            Console.WriteLine($"\n\nArray\n");
            string[] irmaos = new string[3];

            irmaos[0] = "Elaine";
            irmaos[1] = "Érika";
            irmaos[2] = "Eduardo";

            Console.WriteLine($"Total de irmãos {irmaos.Length}");
            //ordenando pelo nome
            Array.Sort(irmaos);
            
            // verificando se um determinado valor existe no array
            string irmaoProcurado = "Érika";
            bool pessaoEncontrada = Array.Exists(irmaos, p => p == irmaoProcurado);
            Console.WriteLine(pessaoEncontrada ? $"{irmaoProcurado} foi encontrado":$"{irmaoProcurado} não foi encontrada");

            foreach (string nome in irmaos)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        }

        public static void exmploCollection()
        {
            Console.WriteLine($"\n\nCollection\n");

            List<string> pessoas = new List<string>();
            pessoas.Add("Edilson");
            pessoas.Add("Walter");
            pessoas.Add("Luana");

            Console.WriteLine($"Total de pessoas {pessoas.Count}");
           
            foreach (string pessoa in pessoas)
            {
                Console.WriteLine($"Pessoa: {pessoa}");
            }

            // verificando se um determinado valor existe na collection
            string pessoasProcurada = "Emerson";
            bool pessaoEncontrada = pessoas.Exists(p => p == pessoasProcurada);
            Console.WriteLine(pessaoEncontrada ? $"{pessoasProcurada} foi encontrado":$"{pessoasProcurada} não foi encontrada");
            //convertendo uma lista para array
            string[] arrayPessoas = pessoas.ToArray();
            Console.WriteLine(arrayPessoas[0]);
        }
    }
}