using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        // Propriedade calculada
        public int Duracao => (int)(DataTermino - DataInicio).TotalDays;

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;

        public Evento()
        {
            Nome = string.Empty;
            DataInicio = DateTime.Now;
            DataTermino = DateTime.Now.AddDays(1);
            NumeroParticipantes = 0;
            Local = string.Empty;
            CustoPorParticipante = 0;
        }
    }
}
