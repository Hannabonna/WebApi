using System;

namespace WebApi_Intro
{
    public class Categories
    {
       public string Name { get; set; }

       public string Description { get; set; }
    }

    public class Primary : Categories
    {
        public int Id { get; set; }
    }
}
