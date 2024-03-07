using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CodeFirst.ViewModels
{
    public class PersonViewModel
    {
        public int PersonID { get; set; }


        [Required]
        [MaxLength(200)]
        [DisplayName("نام و نام خانوادگی")]
        public string name { get; set; }


        [Required]
        [MaxLength(11)]
        [DisplayName("شماره تلفن")]
        public string phoneNumber { get; set; }



        [DisplayName("تاریخ تولد")]
        public int BirthDay { get; set; }


        [DisplayName("تصویر")]
        public IFormFile ImageData { get; set; }
    }
}
