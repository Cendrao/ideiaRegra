namespace ConsoleApplication1.Models.Domain.Interface
{
    public interface IRegra
    {
        bool Satisfaz();

        string MensagemDeErro();
    }
}