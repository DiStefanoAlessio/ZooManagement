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
        private string VerificaTemperaturaAnomala()
        {
            if (_temperaturaCorporeaC >=40 || _temperaturaCorporeaC <= 37)
            {
                return "Normale";
            }

            else
            {
                return "Anomala";
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

        private bool primoCalcoloOreSonno;

        private int ore;

        public double OreDiSonnoAlGiorno()
        {
            if (primoCalcoloOreSonno)
            {
                Random rnd = new Random();
                ore = rnd.Next(16, 21);
            }

            return ore;
        }

        public void RegistraPredazione()
        {
            _ultimaPredazione = DateTime.Now;
        }

        public string maschioFemmina()
        {
            if (IsMaschio)
            {
                return "Maschio";
            }

            else
            {
                return "Femmina";
            }
        }
    }
}