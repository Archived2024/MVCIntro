using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models.ViewModels
{
    public class CreateEmployeeViewModel
    {
        [StringLength(20)]
        public string Name { get; set; }
        public string Department { get; set; }

        [Range(500,50000)]
        public int Salary { get; set; }
    }
}
