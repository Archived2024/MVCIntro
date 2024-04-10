using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models.ViewModels
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }
        [Display(Name="My first name")]
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
