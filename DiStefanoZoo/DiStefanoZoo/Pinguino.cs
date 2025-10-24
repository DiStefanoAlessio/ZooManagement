using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiStefanoZoo
{
    class Pinguino : Animale
    {
        public int TemperaturaAcquaIdeale { get; set; }
        public int NumeroUova { get; set; }

        private double _spessoreGrassoSottocutaneoMm;

        private double _tempoInAcquaOreGiornaliere;

        private string CalcolaIsolamentoTermico()
        {
            if (_spessoreGrassoSottocutaneoMm >= 20 && _spessoreGrassoSottocutaneoMm <= 40)
            {
                return "Isolamento termico sufficiente.";
            }

            else
            {
                return "Isolamento termino insufficiente.";
            }
        }

        private string VerificaEsposizioneAcqua()
        {
            if (_tempoInAcquaOreGiornaliere < 4)
            {
                return "Esposizione insufficiente.";
            }

            else
            {
                return "Esposizione sufficiente";
            }
        }

        public override double CalcolaCiboDiarioKg()
        {
            Random rnd = new Random();
            int cibo = rnd.Next(1, 3);

            return cibo;
        }

        public override double CalcolaCostoGestioneMensile()
        {
            return 250;
        }

        public override string EmettiVerso()
        {
            return "Squawk squawk!";
        }

        private int velocità = 0;
        public int VelocitaNuotoKmH()
        {
            bool primoCalcoloVelocità = true;
            
            if (primoCalcoloVelocità)
            {
                Random rnd = new Random();
                velocità = rnd.Next(10, 16);
                primoCalcoloVelocità = false;
            }

            return velocità;
        }
        public void RegistraTempoInAcqua(double ore)
        {
            _tempoInAcquaOreGiornaliere = ore;
            
            VerificaEsposizioneAcqua();
        }
    }
}
