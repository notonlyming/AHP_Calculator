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
    public partial class FormMatrix : Form
    {
        private string[,] PairMatrix;
        private string[] Factor;
        private Label[] LabelRowFactors;
        private Label[] LabelColumnFactors;
        private Label LabelParentFactor;
        private TextBox[,] textBoxes;
        private Point contralMargin = new Point(5, 5);
        private Font defaultFont = new Font(new FontFamily("微软雅黑"), 12, new FontStyle());
        private Size UniformSize = new Size(60, 30);
        public FormMatrix(string[,] PairMatrix, string[] Factor, string ParentFactor)
        {
            InitializeComponent();
            this.PairMatrix = PairMatrix;
            this.Factor = Factor;
            LabelColumnFactors = new Label[Factor.Length];
            LabelRowFactors = new Label[Factor.Length];
            //put parent lable factor
            LabelParentFactor = new Label
            {
                Text = ParentFactor,
                Location = contralMargin,
                Size = UniformSize,
                Font = defaultFont,
                TextAlign = ContentAlignment.MiddleCenter
            };
            toolTip1.SetToolTip(LabelParentFactor, ParentFactor);
            Controls.Add(LabelParentFactor);

            textBoxes = new TextBox[Factor.Length, Factor.Length];
        }

        private void BuildFactor()
        {
            //Build Factors
            for (int i = 0; i < LabelColumnFactors.Length; i++)
            {
                LabelRowFactors[i] = new Label
                {
                    Text = Factor[i],
                    Size = UniformSize,
                    Font = defaultFont,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                LabelColumnFactors[i] = new Label
                {
                    Text = Factor[i],
                    Size = UniformSize,
                    Font = defaultFont,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                //set text for fators labels
                toolTip1.SetToolTip(LabelColumnFactors[i], Factor[i]);
                toolTip1.SetToolTip(LabelRowFactors[i], Factor[i]);
                //put label
                if (i == 0)
                {
                    LabelColumnFactors[i].Location = new Point(LabelParentFactor.Left + LabelParentFactor.Width, LabelParentFactor.Top);
                    LabelRowFactors[i].Location = new Point(LabelParentFactor.Left, LabelParentFactor.Top + LabelParentFactor.Height);
                }
                else
                {
                    LabelColumnFactors[i].Location = new Point(LabelColumnFactors[i - 1].Left + LabelColumnFactors[i - 1].Width, LabelParentFactor.Top);
                    LabelRowFactors[i].Location = new Point(LabelParentFactor.Left, LabelRowFactors[i - 1].Top + LabelRowFactors[i - 1].Height);
                }
                this.Controls.Add(LabelColumnFactors[i]);
                this.Controls.Add(LabelRowFactors[i]);
            }
        }

        private void BuildTable()
        {
            const int TextMaxLength = 10;
            //build table
            int matrixSize = Factor.Length;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        MaxLength = TextMaxLength,
                        ReadOnly = true,
                        Font = defaultFont,
                        TextAlign = HorizontalAlignment.Center,
                        Size = UniformSize
                    };

                    Controls.Add(textBoxes[i, j]);
                    if (i == 0 && j == 0)
                    {
                        textBoxes[i, j].Left = LabelColumnFactors[i].Left;
                        textBoxes[i, j].Top = LabelRowFactors[i].Top;
                    }
                    else if (j == 0)
                    {
                        textBoxes[i, j].Left = textBoxes[i - 1, j].Left;
                        textBoxes[i, j].Top = textBoxes[i - 1, j].Top + textBoxes[i - 1, j].Height;
                    }
                    else
                    {
                        textBoxes[i, j].Top = textBoxes[i, 0].Top;
                        textBoxes[i, j].Left = textBoxes[i, j - 1].Left + textBoxes[i, j - 1].Width;
                    }
                }
            }
        }

        private void FillTable()
        {

            //fill table
            for (int i = 0; i < Factor.Length; i++)
            {
                for (int j = 0; j < Factor.Length; j++)
                {
                    textBoxes[i, j].Text = PairMatrix[i, j];
                }
            }
        }

        private void FormMatrix_Load(object sender, EventArgs e)
        {
            BuildFactor();
            BuildTable();
            FillTable();
            //resize form
            this.Size = new Size(LabelColumnFactors[Factor.Length - 1].Left + UniformSize.Width + contralMargin.X + 20,
                LabelRowFactors[Factor.Length - 1].Top + UniformSize.Height + contralMargin.Y + 40);
            MinimumSize = Size;  //窗口不可调
        }
    }
}
