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
        public double[,] conventStringMatrixIntoNumberArray(string[,] stringMatrix)
        {
            double[,] NumberMatrix = new double[stringMatrix.GetLength(0),stringMatrix.GetLength(1)];
            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(0); j++)
                {
                    //遍历，并对每个元素进行转换
                    if (stringMatrix[i,j].Contains('/'))
                    {
                        string[] operateNumber = stringMatrix[i,j].Split('/');
                        NumberMatrix[i,j] = int.Parse(operateNumber[0]) / (double)int.Parse(operateNumber[1]);
                    }
                    else
                    {
                        NumberMatrix[i,j] = double.Parse(stringMatrix[i,j]);
                    }
                }
            }
            return NumberMatrix;
        }

        public ArrayList CheckMatrix(double[,] PairWiseMatrix)
        {
            //CI?CR?OK?
            ArrayList CheckMatrixResult = new ArrayList(3);  //创建容量为3的列表
            double[] RI = {0,0,0.58,0.90,1.12,1.24,1.32,1.41,1.45};
            int n = PairWiseMatrix.GetLength(0);
            double lamadaMax = GetMaxEigenvalueOfMatrix(PairWiseMatrix);
            double CI = (lamadaMax-n)/(n-1);
            double CR = CI/RI[n];
            CheckMatrixResult.Add(CI);
            CheckMatrixResult.Add(CR);
            CheckMatrixResult.Add(CR<0.1);
            return CheckMatrixResult;
        }

        public double GetMaxEigenvalueOfMatrix(double[,] Matrix)
        {
            //AWi/Wi的和求算术平均
            double result = 0;
            double[] W = GetEigenvectorOfMatrix(Matrix);  //求权向量
            double[] AW = MatrixMultiplyvector(Matrix, W);  //求AW乘积
            //加和
            for (int i = 0; i < W.Length; i++)
            {
                result += AW[i]/W[i];
            }
            //求平均
            result /= Matrix.GetLength(0);
            return result;
        }

        public double[] MatrixMultiplyvector(double[,] Matrix, double[] vector)
        {
            if (Matrix.GetLength(0) == vector.Length)
            {
                double[] resultvector = new double[vector.Length];
                double sum = 0;
                for (int rowIndex = 0; rowIndex < vector.Length; rowIndex++)
                {
                    sum = 0;
                    for (int columnIndex = 0; columnIndex < vector.Length; columnIndex++)
                    {
                        //每行元素与向量元素乘积加合
                        sum += (Matrix[rowIndex,columnIndex]*vector[columnIndex]);
                    }
                    //搞定赋值
                    resultvector[rowIndex]  = sum;
                }
                return resultvector;
            }
            else
            {
                return null;
            }
        }

        public double[] GetEigenvectorOfMatrix(double[,] Matrix)
        {
            //复制一下
            double[,] ColumnNormalizedMatrix = new double[Matrix.GetLength(0),Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    ColumnNormalizedMatrix[i,j] = Matrix[i,j];
                }
            }
            //将每一列标准化
            double sum = 0;
            for (int columnIndex = 0; columnIndex < Matrix.GetLength(0); columnIndex++)
            {
                sum = 0;
                //求该列的和
                for (int rowIndex = 0; rowIndex < Matrix.GetLength(0); rowIndex++)
                {
                    sum += ColumnNormalizedMatrix[rowIndex,columnIndex];
                }
                //将该列标准化
                for (int rowIndex = 0; rowIndex < Matrix.GetLength(0); rowIndex++)
                {
                    ColumnNormalizedMatrix[rowIndex,columnIndex] /= sum;
                }
            }
            //求列向量的和
            double[] w = new double[Matrix.GetLength(0)];
            for (int rowIndex = 0; rowIndex < w.Length; rowIndex++)
            {
                //将这一行的数加起来
                w[rowIndex] = 0;
                for (int columnIndex = 0; columnIndex < w.Length; columnIndex++)
                {
                    w[rowIndex] += ColumnNormalizedMatrix[rowIndex,columnIndex];
                }
            }
            //w向量归一化
            //求和
            sum = 0;
            for (int i = 0; i < w.Length; i++)
            {
                sum += w[i];
            }
            //元素除和
            for (int i = 0; i < w.Length; i++)
            {
                w[i] /= sum;
            }
            return w;
        }

        public bool IsMatrixHasZero(string[,] Matrix) 
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i,j].Equals("0"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
