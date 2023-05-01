namespace BulkyBookWeb.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
    }
}

/*
Code first approach  =>
    Create models then use "entity framework" 

DB first approach  =>
    create database(tables) & use it code
*/

