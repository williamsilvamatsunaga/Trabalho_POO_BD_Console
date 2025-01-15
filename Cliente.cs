using System.Text.RegularExpressions;

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
        if (nome.Length > 50)
        {
            throw new Exception("O nome deve conter no máximo 50 caracteres.");
        }
        foreach (char c in nome)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                throw new Exception("O nome deve conter apenas letras.");
            }
        }

        this.nome = nome;
    }

    public void SetTratamentoCpf(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            throw new Exception("O CPF deve conter 11 digitos.");
        }

        int soma = 0;
        for(int i = 0; i < 9; i++)
        {
            int digito = int.Parse(cpf[i].ToString());
            soma = soma + digito * (10 - i);
        }

        int primeiro_digito_verificador = 11 - (soma % 11);
        if(primeiro_digito_verificador >= 10)
        {
            primeiro_digito_verificador = 0;
        }

        if (int.Parse(cpf[9].ToString()) != primeiro_digito_verificador)
        {
            throw new Exception("CPF inválido.");
        }

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            int digito = int.Parse(cpf[i].ToString());
            soma = soma + digito * (11 - 1);
        }

        int segundo_digito_verificador = 11 - (soma % 11);
        if(segundo_digito_verificador >= 10)
        {
            segundo_digito_verificador = 0;
        }

        if (int.Parse(cpf[10].ToString()) == segundo_digito_verificador)
        {
            throw new Exception("CPF inválido.");
        }

        this.cpf = cpf;
    }

    public void SetTratamentoEmail(string email)
    {
        if (email.Length > 320)
        {
            throw new Exception("Comprimento excedo o limite permitido.");
        }

        string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        if(!Regex.IsMatch(email, emailPattern))
        {
            throw new Exception("Formato incorreto.");
        }
    }

    public void SetTratamentoTelefone(string telefone)
    {
        telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

        if (!telefone.All(char.IsDigit))
        {
            throw new Exception("O número deve conter apenas díditos.");
        }

        if (telefone.Length != 11)
        {
            throw new Exception("O número deve conter 11 dígitos.");
        }


    }

    public string GetList()
    {
        return $"Nome: {this.nome}\n" +
            $"CPF: {this.cpf}\n" +
            $"Email: {this.email}";
    }
}