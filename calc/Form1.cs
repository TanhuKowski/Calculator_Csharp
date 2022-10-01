using Microsoft.VisualBasic.Devices;

namespace calc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textb1.Text = textb1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textb1.Text);
            textb1.Clear();
            textb1.Focus();
            count = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textb1.Text != "") { 
            num1 = float.Parse(textb1.Text);
                textb1.Clear();
                textb1.Focus();
                count = 2;
        }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textb1.Text);
            textb1.Clear();
            textb1.Focus();
            count = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textb1.Text);
            textb1.Clear();
            textb1.Focus();
            count = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textb1.Clear();
            count = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int c = textb1.TextLength;
            int flag = 0;
            string text = textb1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textb1.Text = textb1.Text + ".";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
             if (textb1.Text.Length > 0)
            {
                textb1.Text = textb1.Text.Remove(textb1.Text.Length - 1);
            }
        }

        private void textb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textb1.Text.Contains("-")) textb1.Text = textb1.Text.Remove(0, 1);
            else textb1.Text = "-" + textb1.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            num1 = float.Parse(textb1.Text);
            count = 5;
        }

        public void compute(int count)
{
    switch (count)
    {
        case 1:
            ans = num1 + float.Parse(textb1.Text);
            textb1.Text = ans.ToString();
            break;
         case 2: 
             ans = num1 - float.Parse(textb1.Text);
                    textb1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textb1.Text);
                    textb1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textb1.Text);
                    textb1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 / 100;
                    textb1.Text = ans.ToString();
                    break;
            }
} 

    }
}
