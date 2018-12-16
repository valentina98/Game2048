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
        public int BoardSize { get; set; }
        // The value of this field is set and reset during and after serialization.
        public Stack<int> MatrixStack;
        // This field is not serialized. The OnDeserializedAttribute is used to set the member value after serialization.
        [JsonIgnore]
        public int[,] Matrix { get; set; }
        public int Score { get; set; }
        public int BestScore { get; set; }
        public string State { get; set; }


        // https://www.newtonsoft.com/json/help/html/SerializationCallbacks.htm

        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {

            for (int i = 0; i < BoardSize; i++)
                for (int j = 0; j < BoardSize; j++)
                    MatrixStack.Push(Matrix[i, j]);
            //foreach (int num in Matrix)
            //    MatrixStack.Push(num);
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

            //_gameManager = gameManager;
            BoardSize = 4;
            MatrixStack = new Stack<int>();
            Matrix = new int[BoardSize, BoardSize];
            //Matrix = _gameManager.InitializeMatrix();
            Score = 0;
            BestScore = 0;
            State = "";

            //_additionalData = new int[BoardSize, BoardSize];
            //_gameManager = gameManager;
            //_httpContextAccessor = httpContextAccessor;

        }


    }

}
