using System.ComponentModel.DataAnnotations;

namespace BankPractice.Models
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string AccountNo { get; set; }

        public string Ifsccode { get; set; }

        public string Mobile { get; set; }
    }
}
