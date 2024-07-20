using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingAPI.Model
{
    public class User
    {


        public int Id { get; set; }


        [Required]
        [StringLength(30,MinimumLength =3 )]
        public string FirstName { get; set; }
      
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Email { get; set; }


    }
}
