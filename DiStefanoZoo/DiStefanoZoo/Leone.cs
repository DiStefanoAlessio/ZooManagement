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
        public bool IsMaschio { get; set; }

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

        public override double CalcolaCiboDiarioKg()
        {
            Random rnd = new Random();
            int cibo = rnd.Next(8, 11);

            return cibo;
        }

        public override double CalcolaCostoGestioneMensile()
        {
            return 400;
        }

        public override string EmettiVerso()
        {
            return "ROARRR!";
        }

        public double OreDiSonnoAlGiorno()
        {
            Random rnd = new Random();
            int ore = rnd.Next(16, 21);

            return ore;
        }

        public void RegistraPredazione()
        {
            _ultimaPredazione = DateTime.Now;
        }
    }
}
