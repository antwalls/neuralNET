using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public interface IData
    {
        IData getData(Object data);
        void setData(Object data);
    }
}
