using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiStefanoZoo
{
    class Elefante : Animale
    {
        public int LunghezzaProboscide { get; set; }
        public int ConsumoDiAcquaLitri { get; set; }

        private int _salutePelle;

        private int _frequenzaBagniSettimanali;

        private int CalcolaSalutePelle()
        {
            for (int i = 0; i < 1; i++)
            {
                if (_frequenzaBagniSettimanali < 7)
                {
                    _salutePelle = _salutePelle - 20;
                }
                else if (_frequenzaBagniSettimanali < 4)
                {
                    _salutePelle = _salutePelle - 50;
                }
                else if (_frequenzaBagniSettimanali <= 1)
                {
                    _salutePelle = _salutePelle - 90;
                }
                else if (_frequenzaBagniSettimanali > 7)
                {
                    _salutePelle = _salutePelle + 20;
                }
                if (ConsumoDiAcquaLitri < 150)
                {
                    _salutePelle = _salutePelle - 20;
                }
                else if (ConsumoDiAcquaLitri < 100)
                {
                    _salutePelle = _salutePelle - 50;
                }
                else if (ConsumoDiAcquaLitri > 150)
                {
                    _salutePelle = _salutePelle + 20;
                }
            }

            if (_salutePelle < 0)
            {
                _salutePelle = 0;
            }else if (_salutePelle > 100)
            {
                _salutePelle = 100;
            }

            return _salutePelle;
        }

        private string VerificaIdratazione()
        {
            if (ConsumoDiAcquaLitri < 150)
            {
                return "Idratazione insufficiente.";
            }
            else
            {
                return "Idratazione sufficiente.";
            }
        }
    }
}
