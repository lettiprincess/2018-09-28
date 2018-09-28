using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Bejegyzes
    {
        public Bejegyzes(string szerzo, string tartalom)
        {

        }

        public string szerzo;
        public string tartalom;
        public int lajkok;
        public DateTime letrejott;
        public DateTime szerkesztett;

        public string Szerzo
        {
            get
            {
                return this.szerzo;
            }
        }

        public string Tartalom{
            get
            {
                return this.tartalom;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.tartalom = value;
                }
            }
        }
            

        public int Lajkok
        {
            get
            {
                return this.lajkok;
            }
        }

        public DateTime Letrejott
        {
            get
            {
                return DateTime.Now;
            }
        }

        public DateTime Szerkesztett
        {
            get
            {
                return DateTime.Now;
            }
        }

        public void Like() {
             lajkok++;
        }
    }
}
