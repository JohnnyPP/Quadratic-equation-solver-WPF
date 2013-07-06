using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscriminantEqualZeroLibrary;
using DiscriminantGreaterThanZeroLibrary;
using DiscriminantLessThanZeroLibrary;

namespace EquationSolver
{
    public class Solver
    {
        private double a, b, c, Discriminant;
        DiscriminantEqualZero DEZ = new DiscriminantEqualZero();
        DiscriminantGreaterThanZero DGTZ = new DiscriminantGreaterThanZero();
        DiscriminantLessThanZero DLTZ = new DiscriminantLessThanZero();

        public string Results(string InputString)
        {
            try
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
                        return DiscriminantEqualZero();
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
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                return "Error check the input values and format";
            }
        }

        private string DiscriminantEqualZero()
        {
            return DEZ.DiscrEqualZero(a, b, Discriminant);
        }

        private string DiscriminantGreaterThanZero()
        {
            return DGTZ.DiscrGreaterThanZero(a,b,Discriminant);
        }

        private string DiscriminantLessThanZero()
        {
            return DLTZ.DiscrLessThanZero(a, b, c, Discriminant);
        }
    }
}
