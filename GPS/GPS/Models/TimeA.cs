using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class TimeA
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DataPartida { get; set; }


        public int JogA1 { get; set; }
        public virtual Jogador JogadoresA1 { get; set; }
        public int GolA1 { get; set; }

        public int JogA2 { get; set; }
        public virtual Jogador JogadoresA2 { get; set; }
        public int GolA2 { get; set; }

        public int JogA3 { get; set; }
        public virtual Jogador JogadoresA3 { get; set; }
        public int GolA3 { get; set; }

        public int JogA4 { get; set; }
        public virtual Jogador JogadoresA4 { get; set; }
        public int GolA4 { get; set; }


        public int JogA5 { get; set; }
        public virtual Jogador JogadoresA5 { get; set; }
        public int GolA5 { get; set; }


        public int JogA6 { get; set; }
        public virtual Jogador JogadoresA6 { get; set; }
        public int GolA6 { get; set; }


        public int JogA7 { get; set; }
        public virtual Jogador JogadoresA7 { get; set; }
        public int GolA7 { get; set; }


        public int JogA8 { get; set; }
        public virtual Jogador JogadoresA8 { get; set; }
        public int GolA8 { get; set; }


        public int JogA9 { get; set; }
        public virtual Jogador JogadoresA9 { get; set; }
        public int GolA9 { get; set; }


        public int JogA10 { get; set; }
        public virtual Jogador JogadoresA10 { get; set; }
        public int GolA10 { get; set; }
    }
}
