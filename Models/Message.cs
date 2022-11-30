using la_mia_pizzeria_static.Validator;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Message
    {
        //properties
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "La mail deve avere un formato corretto")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]        
        public string Email { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(500, ErrorMessage = "Il messaggio non può essere più lungo di 500 caratteri")]
        [Column(TypeName = "text")]
        public string Text { get; set; }

        //costruttore
        //public Message (string email, string name, string title, string text)
        //{ 
        //    Email= email;
        //    Name= name;
        //    Title= title;
        //    Text= text;
        //}
    }
}
