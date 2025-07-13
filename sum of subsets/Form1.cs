using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sum_of_subsets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[] subsetArray;
        static TextBox[] textBoxes;
        static string[] subsetAndis;
        static int waight;
        static string result;
        public void creatSubsetAndis()
        {
            string x;
            for (int i = 0; i < subsetAndis.Length; i++)
            {
                x = "";
                int j = i;
                while (j / 2 > 0)
                {
                    x = j % 2 + x;
                    j = j / 2;
                }
                x = j % 2 + x;
                while (x.Length < textBoxes.Length)
                    x = 0 + x;
                subsetAndis[i] = x; 
            }
        }
        private void creatSubset_Click(object sender, EventArgs e)
        {
            if (subsetLenght == null)
            {
                MessageBox.Show("inter your subset lenght");
            }
            else
            {
                
                textBoxes = new TextBox[Convert.ToInt32(subsetLenght.Text)];
                subsetAndis = new string[(int)Math.Pow(2, Convert.ToDouble(subsetLenght.Text))];
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i] = new TextBox();
                    textBoxes[i].Size = new Size(50, 22);
                    textBoxes[i].Location = new Point(55 * i, 0);
                    subset.Controls.Add(textBoxes[i]);
                }
                creatSubsetAndis();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            waight = Convert.ToInt32(waightTxt.Text);
            for (int i = 0; i < subsetAndis.Length; i++)
            {
                int test = 0;
                for (int j = 0; j < textBoxes.Length; j++)
                {
                    if (subsetAndis[i][j] == '1')
                        test += Convert.ToInt32(textBoxes[j].Text);
                }
                if (test == waight)
                    result = result + subsetAndis[i] + '/' ;
            }
            string[] res = result.Split('/');
            resultTable.RowCount = res.Length;
            for (int i = 0; i < res.Length - 1 ; i++)
            {
                TextBox resTxt = new TextBox();
                string x = "{";
                for (int j = 0; j < textBoxes.Length; j++)
                {
                    if (res[i][j] == '1')
                        x += textBoxes[j].Text + ',' ;
                }
                x += "}";
                resTxt.Text = x;
                resTxt.Size = new Size(150, 22);
                resultTable.Controls.Add(resTxt,0,i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
