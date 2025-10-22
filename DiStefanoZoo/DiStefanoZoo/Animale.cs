using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiStefanoZoo
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Eta { get; set; }
        public double Peso { get; set; }
        public string StatoDiSalute { get; set; }
        public DateOnly DataArrivo { get; set; }
        public int AnniAlloZoo { get; set; }

        private double _pesoIniziale;

        private int _numeroControlliVeterinari;

        private double CalcolaVariazionePesoPercentuale()
        {
            int i = 0;

            while (i == 0)
            {
                _pesoIniziale = Peso;
                i++;
            }

            return ((Peso - _pesoIniziale) / _pesoIniziale) * 100;
        }
        private int CalcoloAnniAlloZoo()
        {
            DateOnly data = DateOnly.FromDateTime(DateTime.Now);
            AnniAlloZoo = data.Year - DataArrivo.Year;

            return AnniAlloZoo;
        }
        private string DeterminaStatoSaluteAutomatico()
        {
            return "";
        }
        public virtual double CalcolaCiboDiarioKg()
        {
            return Peso / 20;
        }
        public virtual double CalcolaCostoGestioneMensile()
        {
            return 100;
        }
        public virtual string EmettiVerso()
        {
            return "*L'animale emette un verso.*";
        }
        public void AggiornaPeso(double nuovoPeso)
        {
            if (Peso != nuovoPeso)
            {
                Peso = nuovoPeso;
            }

            else
            {
                Console.WriteLine("Il peso non è variato.");
            }
        }
        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinari++;

            DeterminaStatoSaluteAutomatico();
        }
        public virtual void MostraInformazioni()
        {



            Console.WriteLine("[" + Specie + "] " + Nome + " - " + Eta + " - " + Peso + " - " + StatoDiSalute +
                              "Allo zoo da: " + AnniAlloZoo + " anni" +
                              "Peso iniziale: " + _pesoIniziale + " (Variazione: " + CalcolaVariazionePesoPercentuale() + "%)" +
                              "Controlli veterinari effettuati: " + _numeroControlliVeterinari +
                              "Cibo giornaliero: " + CalcolaCiboDiarioKg() + "Kg" + " | " + "Costo mensile: " + CalcolaCostoGestioneMensile() + "€");
        }
    }
}
