using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
   public class Person 
    {
        public string Name { get; internal set; }

        [Table("people")]
        public class person
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(250), Unique]
            public string Name { get; set; }
        }

    }
}
