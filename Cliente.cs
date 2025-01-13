public class Cliente
{
    private int id_cliente;
    private string nome;
    private string cpf;
    private string email;
    private string telefone;
    private string endereco;

    public void SetTratamentoCliente(string nome)
    {
        try
        {
            if (nome.Length >= 50)
            {
                throw new Exception("Deve-se conter no máximo 50 caracteres.");
            }
            foreach (char c in nome)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("O nome deve conter apenas letras e números.");
                }
            }

            this.nome = nome;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public string GetNome()
    {
        return $"{this.nome}";
    }
}