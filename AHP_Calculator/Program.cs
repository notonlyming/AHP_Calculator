using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AHP_Calculator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAHP());
        }
    }


    public class MatrixOperater
    {
        public double[,] conventStringMatrixIntoNumberArray()
        {
            return null;
        }

        public ArrayList CheckMatrix()
        {
            //OK?CI?CR?

            return null;
        }


    }
}
