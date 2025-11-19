using System;
using System.ComponentModel.DataAnnotations;

namespace ContractMonthlyClaimsSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        [Display(Name = "Hours Worked")]
        [Range(1, 200, ErrorMessage = "Hours must be between 1 and 200")]
        public decimal HoursWorked { get; set; }

        [Required]
        [Display(Name = "Hourly Rate")]
        [Range(50, 1000, ErrorMessage = "Hourly rate must be between R50 and R1000")]
        public decimal HourlyRate { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Additional Notes")]
        public string AdditionalNotes { get; set; }

        public string Status { get; set; } = "Pending";

        [Display(Name = "Submission Date")]
        public DateTime SubmissionDate { get; set; } = DateTime.Now;

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }
    }
}
