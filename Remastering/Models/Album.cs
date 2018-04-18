using System;
using System.Collections.Generic;
using System.Text;

namespace Remastering.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }       
        public int Id_Bands { get; set; }
        public int Id_Genres { get; set; }
    }
}
