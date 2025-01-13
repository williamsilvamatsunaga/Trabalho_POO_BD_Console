public class Program
{
    public static void Main(string[] args)
    {
        Cliente c = new Cliente();

        int escolha = 0;

        do
        {
            Console.WriteLine("Digite 1 p/ cadastrar cliente\n" +
                "Digite 2 p/ listar todos os clientes\n" +
                "Digite 3 p/ remover determinado cliente\n" +
                "Digite 4 p/ atualizar dados de um cliente\n" +
                "Digite 0 p/ sair do programa:");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        try
                        {
                            Console.Write("Digite o nome do cliente: ");
                            string nome = Console.ReadLine();

                            c.SetTratamentoCliente(nome);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"Erro ao cadastrar cliente!+ {ex.Message}");
                        }

                
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"{c.GetNome()}");

                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }

            Console.Write("Digite 1 /p acessar o menu ou 0 p/ fechar o programa: ");
            escolha = int.Parse(Console.ReadLine());

            Console.Clear();
        } while (escolha != 0);
    }
}