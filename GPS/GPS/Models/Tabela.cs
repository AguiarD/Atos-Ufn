using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Tabela
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DataPartida { get; set; }

        //------------------------------------------------------Time A

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

        //------------------------------------------------------Time B

        public int JogB1 { get; set; }
        public virtual Jogador JogadoresB1 { get; set; }
        public int GolB1 { get; set; }

        public int JogB2 { get; set; }
        public virtual Jogador JogadoresB2 { get; set; }
        public int GolB2 { get; set; }

        public int JogB3 { get; set; }
        public virtual Jogador JogadoresB3 { get; set; }
        public int GolB3 { get; set; }

        public int JogB4 { get; set; }
        public virtual Jogador JogadoresB4 { get; set; }
        public int GolB4 { get; set; }


        public int JogB5 { get; set; }
        public virtual Jogador JogadoresB5 { get; set; }
        public int GolB5 { get; set; }


        public int JogB6 { get; set; }
        public virtual Jogador JogadoresB6 { get; set; }
        public int GolB6 { get; set; }


        public int JogB7 { get; set; }
        public virtual Jogador JogadoresB7 { get; set; }
        public int GolB7 { get; set; }


        public int JogB8 { get; set; }
        public virtual Jogador JogadoresB8 { get; set; }
        public int GolB8 { get; set; }


        public int JogB9 { get; set; }
        public virtual Jogador JogadoresB9 { get; set; }
        public int GolB9 { get; set; }


        public int JogB10 { get; set; }
        public virtual Jogador JogadoresB10 { get; set; }
        public int GolB10 { get; set; }

        protected void TimeA(int j1, int j2, int j3, int j4, int j5, int j6, int j7, int j8, int j9, int j10)
        {
            this.JogA1 = j1;
            this.JogA2 = j2;
            this.JogA3 = j3;
            this.JogA4 = j4;
            this.JogA5 = j5;
            this.JogA6 = j6;
            this.JogA7 = j7;
            this.JogA8 = j8;
            this.JogA9 = j9;
            this.JogA10 = j10;
        }

        protected void TimeB(int j1, int j2, int j3, int j4, int j5, int j6, int j7, int j8, int j9, int j10)
        {
            this.JogB1 = j1;
            this.JogB2 = j2;
            this.JogB3 = j3;
            this.JogB4 = j4;
            this.JogB5 = j5;
            this.JogB6 = j6;
            this.JogB7 = j7;
            this.JogB8 = j8;
            this.JogB9 = j9;
            this.JogB10 = j10;
        }


        protected int GolsA(int gJ1, int gJ2, int gJ3, int gJ4, int gJ5, int gJ6, int gJ7, int gJ8, int gJ9, int gJ10)
        {
            this.GolA1 = gJ1;
            this.GolA2 = gJ2;
            this.GolA3 = gJ3;
            this.GolA4 = gJ4;
            this.GolA5 = gJ5;
            this.GolA6 = gJ6;
            this.GolA7 = gJ7;
            this.GolA8 = gJ8;
            this.GolA9 = gJ9;
            this.GolA10 = gJ10;
            int GolsTimeA = GolA1 + GolA2 + GolA3 + GolA4 + GolA5 + GolA6 + GolA7 + GolA8 + GolA9 + GolA10;

            return GolsTimeA;
        }

        protected int GolsB(int gJ1, int gJ2, int gJ3, int gJ4, int gJ5, int gJ6, int gJ7, int gJ8, int gJ9, int gJ10)
        {
            this.GolB1 = gJ1;
            this.GolB2 = gJ2;
            this.GolB3 = gJ3;
            this.GolB4 = gJ4;
            this.GolB5 = gJ5;
            this.GolB6 = gJ6;
            this.GolB7 = gJ7;
            this.GolB8 = gJ8;
            this.GolB9 = gJ9;
            this.GolB10 = gJ10;
            int GolsTimeB = GolB1 + GolB2 + GolB3 + GolB4 + GolB5 + GolB6 + GolB7 + GolB8 + GolB9 + GolB10;

            return GolsTimeB;
        }

    }
}
