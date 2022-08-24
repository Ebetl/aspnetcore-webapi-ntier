using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlutterBackend.Entities
{
    public class Phone
    {   
        [Key]
        public int ID { get; set; }
        
        [StringLength(50)]
        public string AdıSoyadı { get; set; }

        public string CepTelefon { get; set; }

       

    }
}
