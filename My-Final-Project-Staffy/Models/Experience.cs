﻿using System.Collections.Generic;

namespace My_Final_Project_Staffy.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Vacation> Vacations { get; set; }
    }
}
