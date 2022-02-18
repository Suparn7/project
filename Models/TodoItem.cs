using System;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
namespace todoonboard_api.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }

        public System.DateTime created{get; set;}

        public DateTime updated{get; set;}

        public Board board {get; set;}
    }
}