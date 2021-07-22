using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]     
        public string Title { get; set; }


        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //пример обьединения атрибутов в одну строку
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"),Required,StringLength(30)]      
        public string Genre { get; set; }

        [Range(1, 100),DataType(DataType.Currency)]       
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        //атрибуты будут работать только тогда когда в таблице заполнино значение рейтинга 
        //иначе будет исключение
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        //[StringLength(5)]
        //[Required]
        public string Rating { get; set; }
    }
}
