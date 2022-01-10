using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriKayit.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string ad { get; set; }
        [Required]
        public string soyad { get; set; }
        [Required]
        public string TcNo { get; set; }
        public string dogumYeri { get; set; }
        [Required]
        public string firma { get; set; }
        [Required]
        public string firmaSorumlusu { get; set; }
        public string unvan { get; set; }
        [Required]
        public string tel { get; set; }
        public string ceptel { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd MMM yyyy}")]
        public DateTime dogumTarihi { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime kayitTarihi { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm}")]
        public DateTime düzenlemeTarihi { get; set; }
    }
}
