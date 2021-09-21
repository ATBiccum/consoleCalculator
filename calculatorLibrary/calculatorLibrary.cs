using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace calculatorLibrary
{
    public class Calculator
    {
        JsonWriter writer;

        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }

        public double doAddition(double input1, double input2) //Addition function
        {
            double answer = double.NaN;            
            answer = input1 + input2;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(input1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(input2);
            writer.WritePropertyName("Operation");
            writer.WriteValue("Addition");
            writer.WritePropertyName("Answer");
            writer.WriteValue(answer);
            writer.WriteEndObject();
            return answer;

        }
        public double doSubtraction(double input1, double input2) //Subtraction function
        {
            double answer = double.NaN;
            answer = input1 - input2;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(input1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(input2);
            writer.WritePropertyName("Operation");
            writer.WriteValue("Subtraction");
            writer.WritePropertyName("Answer");
            writer.WriteValue(answer);
            writer.WriteEndObject();
            return answer;
        }

        public double doMultiplication(double input1, double input2) //Multiplication function
        {
            double answer = double.NaN;
            answer = input1 * input2;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(input1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(input2);
            writer.WritePropertyName("Operation");
            writer.WriteValue("Multiplication");
            writer.WritePropertyName("Answer");
            writer.WriteValue(answer);
            writer.WriteEndObject();
            return answer;
        }
        public double doDivision(double input1, double input2) //Divison function
        {
            double answer = double.NaN;
            answer = input1 / input2;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(input1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(input2);
            writer.WritePropertyName("Operation");
            writer.WriteValue("Division");
            writer.WritePropertyName("Answer");
            writer.WriteValue(answer);
            writer.WriteEndObject();
            return answer;
        }
        public double doPower(double input1, double input2) //Power function
        {
            double answer = double.NaN;
            answer = Math.Pow(input1, input2);
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(input1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(input2);
            writer.WritePropertyName("Operation");
            writer.WriteValue("Power of");
            writer.WritePropertyName("Answer");
            writer.WriteValue(answer);
            writer.WriteEndObject();
            return answer;
        }
        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}
