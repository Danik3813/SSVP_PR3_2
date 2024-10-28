using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SSVP_PR3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = listBox1.SelectedItem.ToString();
            //TODO: использовать регулярные выражения или функцию contain/indexof
            /* Regex ruReg = new Regex(@"[а-я]+");
            MatchCollection match = ruReg.Matches(Item);
            label3.Text = match.Count.ToString(); */
            int symbolsCount = 0;
            string russianAlphabet = "ёйцукенгшщзхъфывапролджэячсмитьбю";
            for (int i = 0; i < Item.Length; i++)
            {
                for (int j = 0; j < russianAlphabet.Length; j++)
                {
                    if (Item[i] == russianAlphabet[j]) symbolsCount++;
                }
            }
            label3.Text = symbolsCount.ToString();
        }
    }
}
