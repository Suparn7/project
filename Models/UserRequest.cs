using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace todoonboard_api.Models
{
    
    public class UserRequest
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public string Password {get; set;}
    }
}