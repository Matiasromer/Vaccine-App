using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.Model;
using Vaccine_App.ViewModel;

namespace Vaccine_App.Handler
{
    class BarnHandler
    {
        // denne klasse hed engang BrugerHandler
        public BrugerViewmodel BrugerViewmodel { get; set; }

        public BarnHandler(BrugerViewmodel bvm)
        {
            this.BrugerViewmodel = bvm;
        }

        //udkodet fordi commit (rød streg kode)
        //public void CreateBarn()
        //{
        //    Model.Barn tempBarn = new Model.Barn();
        //    tempBarn.Fødselsdato = BrugerViewmodel.Fødselsdato;
        //    tempBarn.DeviceId = BrugerViewmodel.DeviceId;
        //    tempBarn.Gender = BrugerViewmodel.Gender;
        //    tempBarn.BarnNavn = BrugerViewmodel.BarnNavn;
        //  //  BarnSingleton.Instance.
        //}
    }
}
