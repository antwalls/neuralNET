using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public abstract class Data
    {
        public Object data { get; set; }

        protected Data(object data){this.data = data;}
        
    }
}
