using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class StringData: Data
    {
        public StringData(object data) : base(data)
        {
        }
        public static StringData operator +(StringData op1, StringData op2)
        {
            op1.data += (string) op2.data;
            return op1;
        }
       
    }
}
