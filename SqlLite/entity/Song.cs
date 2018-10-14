using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.entity
{
    class Song
    {
        private int _id;
        private string _name;
        private string _thumbnail;

        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string thumbnail { get => _thumbnail; set => _thumbnail = value; }
    }
}
