using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiStefanoZoo
{
    class Leone : Animale
    {
        public double LunghezzaCriniera { get; set; }
        public bool IsmMaschio { get; set; }

        private double _temperaturaCorporeaC;

        private DateTime _ultimaPredazione;

        private double CalcolaGiorniDallUltimaPredazione()
        {
            DateTime data = DateTime.Now;

            return (data - _ultimaPredazione).TotalDays;
        }
        private bool VerificaTemperaturaAnomala()
        {
            if (_temperaturaCorporeaC >=40 || _temperaturaCorporeaC <= 37)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
