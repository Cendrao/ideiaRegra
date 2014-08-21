

using System;
using System.Collections.Generic;
using ConsoleApplication1.Models.Domain;
using ConsoleApplication1.Models.Domain.Interface;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var listaRegras = new List<IRegra>
            {
                new RegraDeData(new DateTime(2001, 09, 11), new DateTime(2014, 12, 31), DateTime.Now),
                new RegraQuantidadeDeCarac("MatheusESAHOUEHSAOUEHSAOUEHSAOUEHSAOUEHSAOUEHSAOUEHOUASHEOUSAHEOUSAHEOUSAHEOUSAHUEOSAHUOESAH", 20)
            };


            var verificador = new VerificadorDeRegra(listaRegras);

            try
            {
                verificador.Verificar();
                Console.WriteLine("Passou tudo");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.Read();

        }
    }



}
