public class Program
{
    public static void Main(string[] args)
    {

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
                        string nome = "";
                        bool validar_nome = false;
                        while (!validar_nome)
                        {
                            try
                            {
                                Console.Write("Digite o nome do cliente: ");
                                nome = Console.ReadLine();

                                validar_nome = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Erro ao cadastrar nome! {ex.Message}");
                            }
                        }

                        string cpf = "";
                        bool validar_cpf = false;
                        while (!validar_cpf)
                        {
                            try
                            {
                                Console.Write("Digite o CPF do cliente: ");
                                cpf = Console.ReadLine();

                                validar_cpf = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Erro ao cadastrar cpf! {ex.Message}");
                            }
                        }

                        string email = "";
                        bool validar_email = false;
                        while (!validar_email)
                        {
                            try
                            {
                                Console.Write("Digite o email do cliente: ");
                                email = Console.ReadLine();

                                validar_email = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine($"Erro ao cadastrar email! {ex.Message}");
                            }
                        }

                        string telefone = "";
                        bool validar_telefone = false;
                        while (!validar_telefone)
                        {
                            try
                            {
                                Console.Write("Digite o telefone do cliente: ");
                                telefone = Console.ReadLine();

                                validar_telefone = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine($"Erro ao cadastrar telefone! {ex.Message}");
                            }
                        }

                        string endereco = "";
                        bool validar_endereco = false;
                        while (!validar_endereco)
                        {
                            try
                            {
                                Console.Write("Digite o endereço do cliente: ");
                                endereco = Console.ReadLine();

                                validar_endereco = true;
                            }
                            catch( Exception ex)
                            {
                                Console.WriteLine($"Erro ao cadastrar telefone! {ex.Message}");
                            }
                        }

                        Cliente c = new Cliente(nome, cpf, email, telefone, endereco);

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(Cliente.GetList());

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