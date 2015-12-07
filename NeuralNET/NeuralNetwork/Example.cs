using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Example
    {
        public Data        input           { get; set; }
        public Data        desiredOutput   { get; set; }
        public double      error           { get; set; }
        public int         classId         { get; set; }
        public int         exampleId       { get; set; }


        public Example(Data input, Data desiredOutput, int classId, int exampleId)
        {
            this.input = input;
            this.desiredOutput = desiredOutput;
            this.error = 0.0;
            this.classId = classId;
            this.exampleId = exampleId;
        }
    }
}
