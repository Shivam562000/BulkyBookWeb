using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        // variable naming => use camel case (variableName)
        // data annoation
        [Key]   // primary key of DB
        public int id { get; set; }
        [Required]   // can't be null value
        [MaxLength(25)]
        public string name { get; set; }

        [Range(1,100)]
        public int displayOrder { get; set; }
    }
}

/*
Code first approach  =>
    Create models then use "entity framework" 

DB first approach  =>
    create database(tables) & use it code
*/

