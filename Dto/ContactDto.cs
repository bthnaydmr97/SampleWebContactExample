using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Dto
{
    public class ContactDto
    {
        [DisplayName("İsim"), Required(ErrorMessage = "{0} alanı gereklidir."), StringLength(50, ErrorMessage = "{0} alanı max {1} karakter içermeli.")]
        public string Name { get; set; }
        [DisplayName("Soyisim"), Required(ErrorMessage = "{0} alanı gereklidir."), StringLength(50, ErrorMessage = "{0} alanı max {1} karakter içermeli.")]
        public string Surname { get; set; }
        [DisplayName("Yaş"), Required(ErrorMessage = "{0} alanı gereklidir.")]
        public int Age { get; set; }
        [DisplayName("Şehir"), Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string City { get; set; }
        public DateTime Date { get; set; }
    }
}
