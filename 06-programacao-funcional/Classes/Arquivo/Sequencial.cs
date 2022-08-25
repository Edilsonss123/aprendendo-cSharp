using Funcoes;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Classes
{
    namespace Arquivo
    {
        class Sequencial
        {
            private IConfiguration configuration;
            public Sequencial(string[] args = default(string[]))
            {
                ServiceProvider serviceProvider = ConfiguracaoBuilder.RegisterServices(args);
                this.configuration = serviceProvider.GetService<IConfiguration>();
                serviceProvider.Dispose();
            }
            
            public void LerArquivo()
            {
                Console.Write("Informe o identificador do arquivo:");
                var inputNumeroSequencia = Console.ReadLine();
                if (int.TryParse(inputNumeroSequencia, out int numeroSequencialArquivo)) {
                    Ler(numeroSequencialArquivo);
                }
                
            }

            public void Ler(int numeroSequencialArquivo)
            {
                Console.WriteLine("Lendo Arquivos\n\n");
                string arquivo = @$"{this.configuration["AppSettings:CaminhoArquivo"]}arquivo{numeroSequencialArquivo}.txt";
                if (File.Exists(arquivo))
                {
                    Console.WriteLine($"ARQUIVO {numeroSequencialArquivo}\n");
                    string text = System.IO.File.ReadAllText(arquivo);
                    Console.WriteLine($"Texto arquivo = {text}\n");

                    string[] lines = System.IO.File.ReadAllLines(arquivo);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }

                numeroSequencialArquivo++;
                string proximoArquivo = @$"{this.configuration["AppSettings:CaminhoArquivo"]}arquivo{numeroSequencialArquivo}.txt";
                if (File.Exists(proximoArquivo))
                {
                    Ler(numeroSequencialArquivo);  
                }
            }
        }
    }
}