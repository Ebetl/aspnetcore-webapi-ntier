using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FlutterBackend.Entities
{
    public class PersonelDetay
    {
        public int Sicil { get; set; }

        [StringLength(50)]
        public string AdıSoyadı { get; set; }
    
        public string İseGirisTarihi { get; set; }

        public string Kıdem { get; set; }

        public string Firma { get; set; }

        public string Departman { get; set; }

        public string Görev { get; set; }

        public string DogumTarihi { get; set; }
        
        public string Yönetici { get; set; }

    }
}
