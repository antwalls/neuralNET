using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public abstract class Node :Inputable, Outputable
    {
        Data                    data;

        public abstract Data    funcionPropagacion();
        public abstract Data    funcionActivacion();
        public abstract Data    funcionTransferencia();

        public void FeedData(Data input)
        {
            data.sum(input);
        }
        public Data ReturnData()
        {
            throw new NotImplementedException();
        }
    }
}
