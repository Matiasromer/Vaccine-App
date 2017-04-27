using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.ViewModel;

namespace Vaccine_App.Handler
{
    class BrugerHandler
    {

        public BrugerViewmodel BrugerViewmodel { get; set; }

        public BrugerHandler(BrugerViewmodel bvm)
        {
            this.BrugerViewmodel = bvm;
        }


    }
}
