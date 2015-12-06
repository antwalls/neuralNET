using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public abstract class Data
    {
        protected Object data { get; set; }

        protected Data(object data)
        {
            this.data = data;
        }
        public static Data operator+(Data op1, Data op2)
        {
            return null;
        }
    }
}
