namespace StokTakip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firma")]
    public partial class Firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma()
        {
            Urun = new HashSet<Urun>();
        }

        public int FirmaID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string FirmaAdi { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string YetkiliAdSoyad { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string YetkiliUnvani { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Ulke { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Sehir { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Adres { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Telefon { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Email { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string Faks { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz")]
        public string WebSayfasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
