using System;
using System.IO;
using System.Diagnostics;

namespace calculatorLibrary
{
    public class Calculator
    {    
        public Calculator()
        {
        StreamWriter logFile = File.CreateText("calculator.log");
        Trace.Listeners.Add(new TextWriterTraceListener(logFile));
        Trace.AutoFlush = true;
        Trace.WriteLine("Starting Calculator Log");
        Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }

        public double doAddition(double input1, double input2) //Addition function
        {
            double answer = double.NaN;
            answer = input1 + input2;
            Trace.WriteLine(String.Format("{0} + {1} = {2}", input1, input2, answer));
            return answer;

        }
        public double doSubtraction(double input1, double input2) //Subtraction function
        {
            double answer = double.NaN;
            answer = input1 - input2;
            Trace.WriteLine(String.Format("{0} + {1} = {2}", input1, input2, answer));
            return answer;
        }

        public double doMultiplication(double input1, double input2) //Multiplication function
        {
            double answer = double.NaN;
            answer = input1 * input2;
            Trace.WriteLine(String.Format("{0} + {1} = {2}", input1, input2, answer));
            return answer;
        }
        public double doDivision(double input1, double input2) //Divison function
        {
            double answer = double.NaN;
            answer = input1 / input2;
            Trace.WriteLine(String.Format("{0} + {1} = {2}", input1, input2, answer));
            return answer;
        }
    }
}
