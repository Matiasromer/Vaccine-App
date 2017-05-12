﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
   public class Barn
    {
        //Hej fra Jonatan
        // Barn klasse (denne klasse) hed engang Bruger.
        public string Barn_Navn;
        public int Device_id { get; set; }
        public int Barn_Id { get; set; }
        public DateTime Barn_Foedsel { get; set; }
        public String Gender { get; set; }
       // public string Email { get; set; }
      //  public string Barn { get; set; }
       // public int Tlfnr { get; set; }

        public Barn(string BarnNavn, int DeviceId, DateTime Fødselsdato, String Gender)
        {
            this.Barn_Navn = BarnNavn;
            this.Device_id = DeviceId;
            this.Barn_Foedsel = Fødselsdato;
            this.Gender = Gender;
          //  this.Email = Email;
          //  this.Barn = Barn;
          //  this.Tlfnr = Tlfnr;
        }

        //public Barn(int fødselsdato, int deviceId, int gender, string barnNavn)
        //{
        //    Fødselsdato = fødselsdato;
        //    DeviceId = deviceId;
        //    Gender = gender;
        //    BarnNavn = barnNavn;
        //  //  Tlfnr = tlfnr;
        //}

        public override string ToString()
        {
            return $"{Barn_Navn}   -  {Barn_Foedsel:d} -  {Gender}  ";
        }
    }
}
