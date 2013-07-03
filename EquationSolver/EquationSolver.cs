using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationSolver
{
    public class Solver
    {
        private double a, b, c, x1, x2, xReal, xImaginary, Discriminant;

        public string Results(string InputString)
        {
            string[] SplitString;
            

            //InputLength = TextBox_input.Text;
            //IndexOfTheFirstComma = TextBox_input.Text.IndexOf(",").ToString();
            //IndexOfTheSecondComma = TextBox_input.Text.LastIndexOf(",").ToString();
            SplitString = InputString.Split(new Char[] { ',' });
            a = double.Parse(SplitString[0]);
            b = double.Parse(SplitString[1]);
            c = double.Parse(SplitString[2]);

            if (a != 0)
            {
                Discriminant = b * b - 4 * a * c;

                if (Discriminant == 0)
                {
                    return DiscrimantEqualZero();
                }

                if (Discriminant > 0)
                {
                    return DiscriminantGreaterThanZero();
                }

                if (Discriminant < 0)
                {
                    return DiscriminantLessThanZero();
                }

                return "Quadratic equation return path";
            }
            else
            {
                return "Linear equation has only one root: " + (-c / b).ToString();
            }
        }

        private string DiscrimantEqualZero()
        {
            return "The equation has only one root.\n\r" + "Discriminant: "
                        + Discriminant + "\n\rRoot: " + ((-b - Math.Sqrt(Discriminant)) / (2 * a)).ToString();
        }

        private string DiscriminantGreaterThanZero()
        {
            x1 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(Discriminant)) / (2 * a);

            return "The equation has two roots.\n\r" + "Discriminant: " + Discriminant.ToString()
                + "\n\rRoot1: " + x1.ToString() + "\n\r" + "Root2: " + x2.ToString();

        }

        private string DiscriminantLessThanZero()
        {
            xReal = -b / (2 * a);
            xImaginary = (Math.Sqrt(4 * a * c - b * b)) / (2 * a);

            return "The equation has two complex roots.\n\r" + "Discriminant: "
                + Discriminant.ToString()
                + "\n\rRoot1: " + xReal.ToString() + " + i" + xImaginary.ToString()
                + "\n\rRoot2: " + xReal.ToString() + " - i" + xImaginary.ToString();
        }
    }
}
