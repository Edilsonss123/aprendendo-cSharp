using Classes.Models;

namespace OrientacaoObjeto
{
    public class Program {
        public static void Main(string[] args)
        {
            CadastrarClientes();
            /* List<Cliente> clientes = Cliente.LerClientes();
            Cliente cliente = new Cliente();
            cliente.CPF = "1209878787";
            cliente.Nome = "Esmael Santos";
            cliente.Telefone = "3198354843";
            cliente.Gravar();

            Cliente cliente2 = new Cliente();
            cliente2.CPF = "8888787777";
            cliente2.Nome = "Anna Beatriz Santos";
            cliente2.Telefone = "31313132";
            cliente2.Gravar(); */
        }

        public static void CadastrarClientes()
        {
            while (true)
            {
                
                string menu = $" ============= Cadastro de cliente ============="+
                "\n     0 - Sair do cadastro"+
                "\n     1 - Novo cadastro"+
                "\n     2 - Listar clientes";
                Console.WriteLine(menu);
                var inputEntrada = Console.ReadLine();
                if (int.TryParse(inputEntrada, out int entrada)) {
                    if (entrada == 0)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (entrada == 1)
                    {

                        Console.WriteLine("Cadastro de cliente:\n");
                        Console.Write("Nome: ");
                        string Nome = Convert.ToString(Console.ReadLine());

                        Console.Write("CPF: ");
                        string CPF = Convert.ToString(Console.ReadLine());

                        Console.Write("Telefone: ");
                        string Telefone = Convert.ToString(Console.ReadLine());

                        (new Usuario(){
                            Nome = Nome,
                            Telefone = Telefone,
                            CPF = CPF
                        }).Gravar();
                        Console.Write("Cadastro ralizado com sucesso.\n\n");
                    }
                    else if (entrada == 2)
                    {
                        List<Cliente> clientes = Cliente.LerClientes();
                        Console.WriteLine("Lista de clientes\n");
                        foreach (Cliente c in clientes)
                        {
                            Console.WriteLine($"Nome: {c.Nome}\nTelefone: {c.Telefone}\nCPF: {c.CPF}");
                            Console.WriteLine($"\n========================= ========================= =========================\n");
                        } 
                    }
                    

                }
            }

        }
    }
}