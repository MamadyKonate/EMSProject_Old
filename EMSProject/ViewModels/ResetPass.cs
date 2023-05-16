using System.ComponentModel.DataAnnotations;

namespace EMSProject.ViewModels
{
    public class ResetPass
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string CurrentPassword { get; set; } = default!;
        public string NewPassword { get; set; } = default!;
        public string ReEnterNewPassword { get; set; } = default!;
    }
}
