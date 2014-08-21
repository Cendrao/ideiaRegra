using ConsoleApplication1.Models.Domain.Interface;
using ConsoleApplication1.Models.Exception;

namespace ConsoleApplication1.Models.Domain
{
    class RegraQuantidadeDeCarac : IRegra
    {

        private string _palavra;
        private int _quantidade;

        public RegraQuantidadeDeCarac(string palavra, int quantidade)
        {
            _palavra = palavra;
            _quantidade = quantidade;
        }

        public bool Satisfaz()
        {
            return _palavra.Length < _quantidade;
        }

        public string MensagemDeErro()
        {
            throw  new RegraException("A palavra deve conter menos de " + _quantidade + " caracteres");
        }
    }
}
