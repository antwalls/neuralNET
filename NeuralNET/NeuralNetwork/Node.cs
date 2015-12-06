using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Node :Inputable, Outputable
    {
        Data data;

        public Data ReturnData()
        {
            throw new NotImplementedException();
        }
        public void FeedData(Data input)
        {
            data =+ input;
        }
    }
}
