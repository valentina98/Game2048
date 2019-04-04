//using Game2048.Managers;
using Game2048.Managers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Game2048.Models
{
    [Serializable]
    public class GameBoardViewModel
    {
        // This members are serialized and deserialized with no change.
        public int BoardSize { get; set; }
        public int Score { get; set; }
        public int BestScore { get; set; }
        public string State { get; set; }

        // The value of this field is set and reset during and after serialization.
        public Stack<int> MatrixStack;

        // This field is not serialized. The OnDeserializedAttribute is used to set the member value after serialization.
        [JsonIgnore]
        public int[,] Matrix { get; set; }

        // https://www.newtonsoft.com/json/help/html/SerializationCallbacks.htm

        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {
            for (int i = 0; i < BoardSize; i++)
                for (int j = 0; j < BoardSize; j++)
                    MatrixStack.Push(Matrix[i, j]);
        }
        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            for (int i = 0; i < BoardSize; i++)
                for (int j = 0; j < BoardSize; j++)
                    Matrix[i, j] = MatrixStack.Pop();
        }

        public GameBoardViewModel()//IGameManager gameManager, IHttpContextAccessor httpContextAccessor
        {
            BoardSize = 4;
            Score = 0;
            BestScore = 0;
            State = "";

            MatrixStack = new Stack<int>();

            Matrix = new int[BoardSize, BoardSize];

            //_gameManager = gameManager;
            //Matrix = _gameManager.InitializeMatrix();
            //_additionalData = new int[BoardSize, BoardSize];
            //_gameManager = gameManager;
            //_httpContextAccessor = httpContextAccessor;
        }


    }

}
