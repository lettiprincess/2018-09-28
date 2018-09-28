﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Bejegyzes
    {
        /// <summary>
        /// Változók felvevése
        /// </summary>
        public string szerzo;
        public string tartalom;
        public int lajkok = 0;
        public DateTime letrejott;
        public DateTime szerkesztett;

        /// <summary>
        /// Az a feladat elkészítése
        /// </summary>
        /// <param name="szerzo"></param>
        /// <param name="tartalom"></param>
        /// <param name="lajkok"></param>
        /// <param name="letrejott"></param>
        /// <param name="szerkesztett"></param>
        public Bejegyzes(string szerzo, string tartalom,int lajkok,DateTime letrejott,DateTime szerkesztett)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.lajkok = lajkok;
            this.letrejott = letrejott;
            this.szerkesztett = szerkesztett;
        }
        
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

        /// <summary>
        /// A b feladat elkészítése
        /// </summary>
        public string Kiir()
        {
            string s;
            s = string.Format(szerzo + " - " + lajkok + " - " + letrejott + "\nSzerkesztve: " + szerkesztett + "\n" + tartalom);
            return s;
        }
    }
}
