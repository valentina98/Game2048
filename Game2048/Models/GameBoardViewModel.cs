using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game2048.Models
{
    public class GameBoardViewModel
    {
        public int BoardSize { get; set; } = 4;
        public int[,] Matrix { get; set; }
        public string Move { get; set; }
        public bool IsFull { get; set; }
    }

}
