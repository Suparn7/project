using System;
namespace todoonboard_api.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }

        public System.DateTime created{get; set;}

        public DateTime updated{get; set;}

        public int board_id{get; set;}
    }
}