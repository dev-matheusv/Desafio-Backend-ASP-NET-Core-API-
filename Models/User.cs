namespace DesafioKognit.Models;

public class User
{
    public int ID { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DateTime Nascimento { get; set; }
    public string CPF { get; set; } = string.Empty;
}