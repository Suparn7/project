using System;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
namespace todoonboard_api.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name {get; set;}
    }


}