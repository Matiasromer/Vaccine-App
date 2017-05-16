using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Kalender
    {
        //Props
        public string VaccineNavn { get; set; }
        public DateTime Date { get; set; }

        //Constructor
        public Kalender(string VaccineNavn, DateTime DateTime)
        {
            this.VaccineNavn = VaccineNavn;
            this.Date = DateTime;
        }


        //Vacciner, og forskellige anal måneder der skal gå før de skal modtages - inkluderer navn, nr. og Antal måneder fra foedsel.
        public string HepatitisB1()
        {
            return "Hepatitis B Vaccination 1, 1 Måned";
        }
        public string HepatitisB2()
        {
            return "Hepatitis B Vaccination 2, 2 Måneder";
        }
        public string DiTeKiPolHib1()
        {
            return "Di-Te-Ki-Pol-hib vaccination 1, 3 Måneder";
        }
        public string Pnoumokok1()
        {
            return "Pnoumokok vaccination 1, 3 Måneder";
        }
        public string DiTeKiPolHib2()
        {
            return "Di-Te-Ki-Pol-hib vaccination 2, 5 Måneder";
        }
        public string Pnoumokok2()
        {
            return "Pnoumokok vaccination 2, 5 Måneder";
        }
        public string HepatitisB3()
        {
            return "Hepatitis B Vaccination 3, 12 Måneder";
        }
        public string DiTeKiPolHib3()
        {
            return "Di-Te-Ki-Pol-hib vaccination 3, 12 Måneder";
        }
        public string Pnoumokok3()
        {
            return "Pnoumokok vaccination 3, 12 Måneder";
        }
        public string MFR1()
        {
            return "MFR vaccination 1, 12 Måneder";
        }
        public string DiTeKiPolHib4()
        {
            return "Di-Te-Ki-Pol-hib vaccination 4, 60 Måneder";
        }
        //Valgfri Vaccination for piger
        public string Hpv()
        {
            return "Hpv Vaccinaion, 144 Måneder";
        }
        public string MFR2()
        {
            return "MFR vaccination 2, 144 Måneder";
        }
    }
}
