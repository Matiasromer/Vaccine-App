using System;
using System.Collections.Generic;
using Vaccine_App.ViewModel;
using Vaccine_App.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.AccessCache;
using System.Collections.ObjectModel;

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
            //barnListe = new ObservableCollection<BarnListe>(Liste());
            //SelectedBarnListe = barnListe.FirstOrDefault();
            this.VaccineNavn = VaccineNavn;
            this.Date = DateTime;
        }

        //    public ObservableCollection<BarnListe> barnListe { get; set; }

        //    private BarnListe selectedBarnListe;

        //    public BarnListe SelectedBarnListe
        //    {
        //        get { return selectedBarnListe; }
        //        set { selectedBarnListe = value; }
        //    }

        //    public List<BarnListe> Liste()
        //    {

        //        List<BarnListe> vacciner = new List<BarnListe>();
        //        vacciner.Add(HepatitisB1());
        //        vacciner.Add(HepatitisB2());
        //        vacciner.Add(DiTeKiPolHib1());
        //        vacciner.Add(Pnoumokok1());
        //        vacciner.Add(DiTeKiPolHib2());
        //        vacciner.Add(Pnoumokok2());
        //        vacciner.Add(HepatitisB3());
        //        vacciner.Add(DiTeKiPolHib3());
        //        vacciner.Add(Pnoumokok3());
        //        vacciner.Add(MFR1());
        //        vacciner.Add(DiTeKiPolHib4());
        //        vacciner.Add(Hpv());
        //        vacciner.Add(MFR2());

        //        return vacciner;
        //    }
        //    Liste over vaccinationer:







        //    Vacciner, og forskellige anal måneder der skal gå før de skal modtages - inkluderer navn, nr. og Antal måneder fra foedsel.
        //    #region Vacciner
        //    public string HepatitisB1(BarnListe)
        //    {
        //        return HepatitisB1(new BarnListe("Brian", 1, "Hepatitis B, 1 Måned"));

        //    }
        //    public string HepatitisB2(BarnListe)
        //    {
        //        return HepatitisB2(new BarnListe("Brian", 1, "Hepatitis B, 2 måneder"));
        //    }
        //    public string DiTeKiPolHib1(BarnListe)
        //    {
        //        return DiTeKiPolHib1(new BarnListe("Brian", 1, "Di-Te-Ki-Pol-hib, 3 Måneder"));
        //    }
        //    public string Pnoumokok1(BarnListe)
        //    {
        //        return Pnoumokok1(new BarnListe("Brian", 1, "Pnoumokok, 3 Måneder"));
        //    }
        //    public string DiTeKiPolHib2(BarnListe)
        //    {
        //        return DiTeKiPolHib2(new BarnListe("Brian", 1, "Di-Te-Ki-Pol-hib, 5 Måneder"));
        //    }
        //    public string Pnoumokok2(BarnListe)
        //    {
        //        return Pnoumokok2(new BarnListe("Brian", 1, "Pnoumokok, 5 Måneder"));
        //    }
        //    public string HepatitisB3(BarnListe)
        //    {
        //        return DiTeKiPolHib3(new BarnListe("Brian", 1, "Hepatitis B, 12 Måneder"));
        //    }
        //    public string DiTeKiPolHib3(BarnListe)
        //    {
        //        return DiTeKiPolHib3(new BarnListe("Brian", 1, "Di-Te-Ki-Pol-hib, 12 Måneder"));
        //    }
        //    public string Pnoumokok3(BarnListe)
        //    {
        //        return Pnoumokok3(new BarnListe("Brian", 1, "Pnoumokok, 12 Måneder"));
        //    }
        //    public string MFR1(BarnListe)
        //    {
        //        return MFR1(new BarnListe("Brian", 1, "MFR, 12 Måneder"));
        //    }
        //    public string DiTeKiPolHib4(BarnListe)
        //    {
        //        return DiTeKiPolHib4(new BarnListe("Brian", 1, "Di-Te-Ki-Pol-hib vaccination 4, 60 Måneder"));
        //    }
        //    Valgfri Vaccination for piger
        //    public string Hpv(BarnListe)
        //    {
        //        return Hpv(new BarnListe("Brian", 1, "Hpv, 144 Måneder"));
        //    }
        //    public string MFR2(BarnListe)
        //    {
        //        return MFR2(new BarnListe("Brian", 1, "MFR, 144 Måneder"));
        //    }
        //    #endregion
        //}
    }
}
