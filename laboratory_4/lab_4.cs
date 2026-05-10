using System;

namespace Project
{
    class individual_task
    {
        public static int indiv_task_var_3(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                return 0;
            }
            else if (d == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}