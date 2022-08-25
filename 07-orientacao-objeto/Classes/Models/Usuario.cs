using Funcoes;

using Microsoft.Extensions.Configuration;
namespace Classes
{
    namespace Models
    {
        public class Usuario: Cliente
        {
            public  override void Gravar()
            {
                List<Usuario> usuarios = LerUsuarios();
                usuarios.Add(this);
                IConfiguration? bancoDeDados = Configuracao();
                string? bancoDeDadosCliente = bancoDeDados["AppSettings:BancoDeDados:Tabela:Usuario"];
                string? delimitador = bancoDeDados["AppSettings:BancoDeDados:DelimitadorDados"];

                if (File.Exists(bancoDeDadosCliente))
                {
                    StreamWriter stream = new StreamWriter(bancoDeDadosCliente);
                    stream.WriteLine($"nome{delimitador}telefone{delimitador}cpf");
                    foreach (Usuario c in usuarios)
                    {
                        stream.WriteLine($"{c.Nome}{delimitador}{c.Telefone}{delimitador}{c.CPF}");
                    }
                    stream.Close();
                }
            }

            public static List<Usuario> LerUsuarios()
            {
                var bancoDeDados = Configuracao();
                List<Usuario> usuarios = new List<Usuario>();
                string? bancoDeDadosCliente = bancoDeDados["AppSettings:BancoDeDados:Tabela:Usuario"];
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
                                List<string> usuario = linha.Split(delimitador, StringSplitOptions.RemoveEmptyEntries).ToList();
                                usuarios.Add(new Usuario() {
                                    Nome= usuario[0],
                                    CPF= usuario[1],
                                    Telefone= usuario[2],
                                });
                            }
                        }
                    }
                }
                return usuarios;                
            }
        }
    }
}