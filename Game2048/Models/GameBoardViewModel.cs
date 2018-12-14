using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game2048.Models
{
    [Serializable]
    public class GameBoardViewModel
    {
        public int BoardSize { get; set; } = 4; // I use it for the html helpers
        public int[,] Matrix { get; set; }
        public int Score { get; set; } = 0;
        public int BestScore { get; set; } = 0;
        public string State { get; set; } = "";
    }

}
