using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FlutterBackend.Entities
{
     public class IK_Mobil
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string AdıSoyadı { get; set; }

        public string CepTelefon { get; set; }

        public string Sifre { get; set; }

        public string SifreTarih { get; set; }
    }
}
