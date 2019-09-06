using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{
    public class SimpleEquationKata
    {
        public static string SolveTheEquation(string equation)
        {
            var equationSplit = equation.Split(' ');
            var c = 0d;
            switch (equationSplit[1])
            {
                case "+":
                    c = Double.Parse(equationSplit[4]) - Double.Parse(equationSplit[2]);
                    break;
                case "*":
                    c = Double.Parse(equationSplit[4]) / Double.Parse(equationSplit[2]);
                    break;
                case "-":
                    c = Double.Parse(equationSplit[4]) + Double.Parse(equationSplit[2]);
                    break;
                case "/":
                    c = Double.Parse(equationSplit[4]) * Double.Parse(equationSplit[2]);
                    break;
                default:
                    break;
            }

            return $"x = {Math.Round(c, 2)}";
        }
    }
}
