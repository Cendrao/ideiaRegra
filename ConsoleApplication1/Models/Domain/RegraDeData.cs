using System;
using ConsoleApplication1.Models.Domain.Interface;
using ConsoleApplication1.Models.Exception;

namespace ConsoleApplication1.Models.Domain
{
    public class RegraDeData : IRegraDeData
    {




        private readonly DateTime _dataInicio;
        private readonly DateTime _dataFim;
        private readonly DateTime _comparada;

        public RegraDeData(DateTime _dataInicio, DateTime dataFim, DateTime comparada)
        {
            if (_dataInicio == null) throw new RegraException("A Data de Inicio não pode ser nula");

            if (dataFim == null) throw new RegraException("A Data de Fim não pode ser nula");

            if (comparada == null) throw new RegraException("A Data a ser Comparada não pode ser nula");

            this._dataInicio = _dataInicio;
            _dataFim = dataFim;
            _comparada = comparada;

        }

        public bool Satisfaz()
        {
            return (_dataInicio <= _comparada && _dataFim >= _comparada);
        }

        public string MensagemDeErro()
        {
            return "A Data deve estar compreendida entre o inicio e o fim";
        }
    }
}
