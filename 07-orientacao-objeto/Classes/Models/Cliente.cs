using Funcoes;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Classes
{
    namespace Models
    {
        public class Cliente
        {
            public string? Nome;
            public string? CPF;
            public string? Telefone;
            private IConfiguration? configuration;
            public Cliente()
            {
            }

            public static IConfiguration? Configuracao()
            {
                ServiceProvider serviceProvider = ConfiguracaoBuilder.RegisterServices(default(string[]));
                IConfiguration? configuration = serviceProvider.GetService<IConfiguration>();
                serviceProvider.Dispose();
                return configuration;
            }
            public  virtual void Gravar()
            {
                List<Cliente> clientes = LerClientes();
                clientes.Add(this);
                IConfiguration? bancoDeDados = Configuracao();
                string? bancoDeDadosCliente = bancoDeDados["AppSettings:BancoDeDados:Tabela:Cliente"];
                string? delimitador = bancoDeDados["AppSettings:BancoDeDados:DelimitadorDados"];

                if (File.Exists(bancoDeDadosCliente))
                {
                    StreamWriter stream = new StreamWriter(bancoDeDadosCliente);
                    stream.WriteLine($"nome{delimitador}telefone{delimitador}cpf");
                    foreach (Cliente c in clientes)
                    {
                        stream.WriteLine($"{c.Nome}{delimitador}{c.Telefone}{delimitador}{c.CPF}");
                    }
                    stream.Close();
                }
            }

            public static List<Cliente> LerClientes()
            {
                var bancoDeDados = Configuracao();
                List<Cliente> clientes = new List<Cliente>();
                string? bancoDeDadosCliente = bancoDeDados["AppSettings:BancoDeDados:Tabela:Cliente"];
                if (File.Exists(bancoDeDadosCliente))
                {
                    using (StreamReader arquivo = File.OpenText(bancoDeDadosCliente)) {
                        string? delimitador = bancoDeDados["AppSettings:BancoDeDados:DelimitadorDados"];
                        string linha;
                        int i = 0;
                        while ((linha = arquivo.ReadLine()) != null)
                        {
                            i++;
                            if (i > 1)
                            {
                                List<string> cliente = linha.Split(delimitador, StringSplitOptions.RemoveEmptyEntries).ToList();
                                clientes.Add(new Cliente() {
                                    Nome= cliente[0],
                                    CPF= cliente[1],
                                    Telefone= cliente[2],
                                });
                            }
                        }
                    }
                }
                return clientes;                
            }
        }
    }
}