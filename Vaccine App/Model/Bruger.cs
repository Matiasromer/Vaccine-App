using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Bruger
    {
        public int DeviceId { get; set; }
        public int Cpr { get; set; }
        public string Email { get; set; }
        public string Barn { get; set; }
        public int Tlfnr { get; set; }

        public Bruger(int DeviceId, int Cpr, string Email, string Barn, int Tlfnr)
        {
            this.DeviceId = DeviceId;
            this.Cpr = Cpr;
            this.Email = Email;
            this.Barn = Barn;
            this.Tlfnr = Tlfnr;
        }
    }
}
