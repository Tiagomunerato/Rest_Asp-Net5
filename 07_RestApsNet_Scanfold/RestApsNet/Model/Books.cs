using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApsNet.Model
{
    [Table("books")]
    public class Books
    {
         
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string Autor { get; set; }

        [Column("launch_date")]
        public string Lancamento { get; set; }

        [Column("price")]
        public string Preco { get; set; }
        [Column("title")]
        public string Titulo { get; set; }
    }
}

