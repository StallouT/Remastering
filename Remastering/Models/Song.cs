using System;
using System.Collections.Generic;
using System.Text;

namespace Remastering.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Id_Albums { get; set; }
    }
}
