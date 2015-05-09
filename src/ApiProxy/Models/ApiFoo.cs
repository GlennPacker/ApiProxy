using System.ComponentModel.DataAnnotations;

namespace ApiProxy.Models
{
    public class ApiFoo
    {
        public int Id { get; set; }

        [StringLength(255, ErrorMessage = "*")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "*")]
        [Required]
        public string Description { get; set; }
    }
}
