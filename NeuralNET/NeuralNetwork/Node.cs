using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class Node :Inputable, Outputable
    {
        IData data;
        bool setData(IData _data)
        {
            try
            {
                data = _data;
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        IData getData()
        {
            return data;
        }

        IData ReturnData()
        {
            throw new NotImplementedException();
        }

        void FeedData(IData input)
        {
            throw new NotImplementedException();
        }
    }
}
