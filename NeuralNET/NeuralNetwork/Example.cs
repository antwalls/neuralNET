using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Example
    {
        private Data        input           { get; set; }
        private Data        desiredOutput   { get; set; }
        private double      error           { get; set; }
        private int         classId         { get; set; }


        public Example(Data input, Data desiredOutput, double error, int classId)
        {
            this.input = input;
            this.desiredOutput = desiredOutput;
            this.error = 0;
            this.classId = classId;
        }
    }
}
