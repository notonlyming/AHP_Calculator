using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP_Calculator
{
    public partial class FormSurvey : Form
    {
        private Label[] labelQuestions;
        public string[,] pairWiseMatrix;
        private string[] factors;
        private string parentFactor;
        private int[] compairIndex;
        private Font defaultFont = new Font(new FontFamily("微软雅黑"), 12, new FontStyle());
        private ComboBox[] ComboBoxReverseOrNot;
        private ComboBox[] ComboBoxImportantTimes;

        public FormSurvey(string[] factors, string parentFactor, string[,] priviousMatrix = null)
        {
            InitializeComponent();
            this.factors = factors;
            this.parentFactor = parentFactor;
            labelQuestions = new Label[factors.Length * (factors.Length - 1) / 2];
            pairWiseMatrix = new string[factors.Length, factors.Length];
            //generate answer control
            ComboBoxReverseOrNot = new ComboBox[labelQuestions.Length];
            ComboBoxImportantTimes = new ComboBox[labelQuestions.Length];
            for (int i = 0; i < ComboBoxImportantTimes.Length; i++)
            {
                ComboBoxImportantTimes[i] = new ComboBox();
                ComboBoxImportantTimes[i].SelectionChangeCommitted += new System.EventHandler(this.AnswerChanged);
                ComboBoxImportantTimes[i].Items.Add("1 - 同等重要");
                ComboBoxImportantTimes[i].Items.Add("3 - 稍微重要");
                ComboBoxImportantTimes[i].Items.Add("5 - 较强重要");
                ComboBoxImportantTimes[i].Items.Add("7 - 强烈重要");
                ComboBoxImportantTimes[i].Items.Add("9 - 极端重要");
            }
            //generate what to compare
            compairIndex = new int[labelQuestions.Length * 2];
            int counter = 0;
            for (int i = 1; i <= factors.Length - 1; i++)
            {
                for (int j = i + 1; j <= factors.Length; j++)
                {
                    compairIndex[counter] = j;
                    compairIndex[counter + 1] = i;
                    counter += 2;
                }
            }

            //init matrix
            if (priviousMatrix != null)
            {
                for (int i = 0; i < factors.Length; i++)
                {
                    for (int j = 0; j < factors.Length; j++)
                    {
                        pairWiseMatrix[i, j] = priviousMatrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < factors.Length; i++)
                {
                    for (int j = 0; j < factors.Length; j++)
                    {
                        pairWiseMatrix[i, j] = "0";
                    }
                }
            }

            //对角线初始化为1
            for (int i = 0; i < pairWiseMatrix.GetLength(0); i++)
            {
                pairWiseMatrix[i, i] = "1";
            }
        }

        private void FormSurvey_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < labelQuestions.Length; i++)
            {
                int[] positionInPairMatrix = new int[2] { compairIndex[2 * i] - 1, compairIndex[2 * i + 1] - 1 };
                //add question
                labelQuestions[i] = new Label
                {
                    Text = "Consider two factors: " + factors[positionInPairMatrix[0]] + " and " + factors[positionInPairMatrix[1]] +
                    ", which one is more important in " + parentFactor + "? How many times more important?",
                    AutoSize = true,
                    Font = defaultFont
                };
                flowLayoutPanel1.Controls.Add(labelQuestions[i]);
                //add answer control
                ComboBoxReverseOrNot[i] = new ComboBox();
                ComboBoxReverseOrNot[i].SelectionChangeCommitted += new System.EventHandler(this.AnswerChanged);
                ComboBoxReverseOrNot[i].Items.Add(factors[positionInPairMatrix[0]]);
                ComboBoxReverseOrNot[i].Items.Add(factors[positionInPairMatrix[1]]);
                flowLayoutPanel1.Controls.Add(ComboBoxReverseOrNot[i]);
                flowLayoutPanel1.Controls.Add(ComboBoxImportantTimes[i]);
                //load privious answer
                if (pairWiseMatrix[positionInPairMatrix[0], positionInPairMatrix[1]].Equals("0") == false)
                {
                    if (pairWiseMatrix[positionInPairMatrix[0], positionInPairMatrix[1]].IndexOf("1/") == 0)
                    {
                        ComboBoxReverseOrNot[i].SelectedIndex = 1;
                        ComboBoxImportantTimes[i].SelectedIndex =
                            (int.Parse(pairWiseMatrix[positionInPairMatrix[0], positionInPairMatrix[1]].Substring(2)) + 1) / 2 - 1;
                    }
                    else
                    {
                        ComboBoxReverseOrNot[i].SelectedIndex = 0;
                        ComboBoxImportantTimes[i].SelectedIndex =
                            (int.Parse(pairWiseMatrix[positionInPairMatrix[0], positionInPairMatrix[1]]) + 1) / 2 - 1;
                    }
                }
                //为了消除导入矩阵的null空项，调用该方法保存一下
                AnswerChanged(new object(), new EventArgs());
            }

        }

        private void AnswerChanged(object sender, EventArgs e)
        {
            //Throw all answer to matrix(save)
            for (int i = 0; i < labelQuestions.Length; i++)
            {
                if (ComboBoxImportantTimes[i].SelectedIndex != -1)
                {
                    if (ComboBoxReverseOrNot[i].SelectedIndex == 0)
                    {
                        pairWiseMatrix[compairIndex[2 * i] - 1, compairIndex[2 * i + 1] - 1] = ((ComboBoxImportantTimes[i].SelectedIndex + 1) * 2 - 1).ToString();
                        pairWiseMatrix[compairIndex[2 * i + 1] - 1, compairIndex[2 * i] - 1] = "1/" + ((ComboBoxImportantTimes[i].SelectedIndex + 1) * 2 - 1).ToString();
                    }
                    else if (ComboBoxReverseOrNot[i].SelectedIndex == 1)
                    {
                        pairWiseMatrix[compairIndex[2 * i] - 1, compairIndex[2 * i + 1] - 1] = "1/" + ((ComboBoxImportantTimes[i].SelectedIndex + 1) * 2 - 1).ToString();
                        pairWiseMatrix[compairIndex[2 * i + 1] - 1, compairIndex[2 * i] - 1] = ((ComboBoxImportantTimes[i].SelectedIndex + 1) * 2 - 1).ToString();
                    }
                }
            }
        }
    }
}