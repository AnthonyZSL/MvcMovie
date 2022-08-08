using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        //ReleaseDate上的DateType
        //户无需在日期字段中输入时间信息。
        //仅显示日期，而非时间信息。
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
