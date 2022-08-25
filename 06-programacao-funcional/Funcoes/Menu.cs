using Classes.Calculo;
using Classes.Arquivo;

namespace Funcoes
{
    public class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS= 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Montar()
        {
            while (true)
            {
                Console.WriteLine("\nMenu opções disponiveis:\n");
                Console.WriteLine("[1] => Ler Arquivos");
                Console.WriteLine("[2] => Tabuada");
                Console.WriteLine("[3] => Calcular Média");
                Console.WriteLine("[0] => Sair");
                var inputEntrada = Console.ReadLine();
                if (int.TryParse(inputEntrada, out int entrada)) {
                    if (entrada == SAIDA_PROGRAMA)
                    {
                        Console.Clear();
                        break;
                    }
                    
                    TratarOpcaoSelecionada(entrada);
                    Console.WriteLine("\n\n\n");
                }
            }

        }
        private static void TratarOpcaoSelecionada(int entrada)
        {
            
            switch (entrada)
            {
                case LER_ARQUIVOS:
                    (new Sequencial()).LerArquivo();
                    break;
                case TABUADA:
                    Tabuada.CalcularTabuada();
                    break;
                case CALCULO_MEDIA:
                    MediaNota.CalcularMediaNotas();
                    break;
            }
        }
    }
}