using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WEBAPP_MVC.Domain.Entities
{
    public class ClassEntity
    {
        [DisplayName("Class name")]
        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
