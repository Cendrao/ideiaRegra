using System.Collections.Generic;
using ConsoleApplication1.Models.Domain.Interface;
using ConsoleApplication1.Models.Exception;

namespace ConsoleApplication1.Models.Domain
{
    public class VerificadorDeRegra
    {

        private IList<IRegra> _listaDeRegras;


        public VerificadorDeRegra(IList<IRegra> regras)
        {
            if (regras == null && regras.Count == 0) throw new RegraException("Você deve definir regras a serem verificadas");

            _listaDeRegras = regras;
        }

        public  void Verificar()
        {
            foreach (var item in _listaDeRegras)
            {
                if (!item.Satisfaz())
                    throw  new RegraException(item.MensagemDeErro());
            }
        }

    }
}
