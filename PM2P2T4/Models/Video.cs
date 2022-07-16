using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM2P2T4.Models
{
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Uri { get; set; }

        public string Descripcion { get; set; }
    }
}