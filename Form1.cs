using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_5
{
    
    public partial class Form1 : Form
    {
        public bool hist_enabled = false;
        History journal = new History();

        public string Cur_Str = "";
        public float a, b;
        bool func = false;
        string num_func = "0";

        string temp = "";

        public Form1()
        {
            InitializeComponent();
            Cur_Expr.Text = "0";
            foreach(Control control in this.Controls)
            {
                if(control is MdiClient)
                {
                    control.BackColor = Color.LightGray;
                }
            }

        }
        public void Clear()
        {
            num_func = "0";
            func = false;
            Cur_Expr.Text = "0";
            Cur_Str = "";
            a = 0;
            b = 0;
        }
        public void Calculate()
        {
            if (Cur_Str != "")
            {
                switch (num_func)
                {
                    case "+":
                        b = float.Parse(Cur_Str);

                        temp = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
                        journal.List.Items.Add(temp);

                        a = (a + b);
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";

                        break;
                    case "-":
                        b = float.Parse(Cur_Str);

                        temp = a.ToString() + " - " + b.ToString() + " = " + (a - b).ToString();
                        journal.List.Items.Add(temp);

                        a = (a - b);
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "*":
                        b = float.Parse(Cur_Str);

                        temp = a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString();
                        journal.List.Items.Add(temp);

                        a = (a * b);
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "/":
                        b = float.Parse(Cur_Str);

                        temp = a.ToString() + " / " + b.ToString() + " = " + (a / b).ToString();
                        journal.List.Items.Add(temp);

                        a = (a / b);
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "n!":
                        if (a == 0)
                        {
                            temp = a.ToString() + "! = " + "1";
                            journal.List.Items.Add(temp);

                            a = 1;
                        }else if (a % 1 == 0)
                        {
                            long tempo = 1;
                            for(long i = 1; i < a + 1; i++)
                            {
                                tempo *= i;
                            }
                            temp = a.ToString() + "! = " + tempo.ToString();
                            journal.List.Items.Add(temp);
                            a = tempo;
                        }
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "n!f":
                        double x;
                        int k = (int)a;
                        int t = 1;
                        for (int i = 1; i < k + 1; i++)
                        {
                            t *= i;
                        }
                        x = Math.Log10(t) + (a-k)* Math.Log10(k+1);
                        x = Math.Pow(10, x);

                        temp = a.ToString() + "! = " + x.ToString();
                        journal.List.Items.Add(temp);


                        Cur_Expr.Text = x.ToString();
                        Cur_Str = "";

                        break;
                    case "x^y":
                        b = float.Parse(Cur_Str);

                        float c = (float)Math.Pow(a, b);
                        temp = a.ToString() + "^" + b.ToString() + " = " + c.ToString();
                        journal.List.Items.Add(temp);

                        a = c;
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "log":
                        b = float.Parse(Cur_Str);

                        c = (float)Math.Log10(b);
                        temp = "log(" + b.ToString() + ") = " + c.ToString();
                        journal.List.Items.Add(temp);

                        a = c;
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    case "ln":
                        b = float.Parse(Cur_Str);

                        c = (float)Math.Log(b);
                        temp = "ln(" + b.ToString() + ") = " + c.ToString();
                        journal.List.Items.Add(temp);

                        a = (float)Math.Log(b);
                        b = 0;
                        Cur_Expr.Text = a.ToString();
                        Cur_Str = "";
                        break;
                    default:
                        break;

                }
                func = false;
                num_func = "200";
            }
        }
        private void Solve_Click(object sender, EventArgs e)
        {
            if(Cur_Str == "" && func == true)
            {
                Remove_Click(this, e);
                func = false;
                num_func = "200";
            }else if (Cur_Str == "")
            {

            }else if (func == true) { 
                Calculate();
            }

        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {

            }
            else
            {
                Cur_Str += "0";
                Cur_Expr.Text += "0";
            }
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "1";
                Cur_Expr.Text = "1";
            }
            else
            {
                Cur_Str += "1";
                Cur_Expr.Text += "1";
            }
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "2";
                Cur_Expr.Text = "2";
            }
            else
            {
                Cur_Str += "2";
                Cur_Expr.Text += "2";
            }
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "3";
                Cur_Expr.Text = "3";
            }
            else
            {
                Cur_Str += "3";
                Cur_Expr.Text += "3";
            }
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "4";
                Cur_Expr.Text = "4";
            }
            else
            {
                Cur_Str += "4";
                Cur_Expr.Text += "4";
            }
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "5";
                Cur_Expr.Text = "5";
            }
            else
            {
                Cur_Str += "5";
                Cur_Expr.Text += "5";
            }
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "6";
                Cur_Expr.Text = "6";
            }
            else
            {
                Cur_Str += "6";
                Cur_Expr.Text += "6";
            }
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "7";
                Cur_Expr.Text = "7";
            }
            else
            {
                Cur_Str += "7";
                Cur_Expr.Text += "7";
            }
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "8";
                Cur_Expr.Text = "8";
            }
            else
            {
                Cur_Str += "8";
                Cur_Expr.Text += "8";
            }
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            if (num_func == "200")
            {
                num_func = "0";
                Clear();
            }
            if (Cur_Expr.Text == "0")
            {
                Cur_Str = "9";
                Cur_Expr.Text = "9";
            }
            else
            {
                Cur_Str += "9";
                Cur_Expr.Text += "9";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Cur_Expr.Text == "0")
            {
                
            }
            else if(Cur_Expr.Text.Length == 1)
            {
                Cur_Str = "";
                Cur_Expr.Text = "0";
            }
            else if(Cur_Str == "")
            {
                Cur_Expr.Text = Cur_Expr.Text.Remove(Cur_Expr.Text.Length - 1);
            }
            else{
                Cur_Str = Cur_Str.Remove(Cur_Str.Length - 1);
                Cur_Expr.Text = Cur_Expr.Text.Remove(Cur_Expr.Text.Length - 1);
            }
            num_func = "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {

                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = float.Parse(Cur_Str);

                    Cur_Expr.Text = Cur_Str + "-";
                    Cur_Str = "";
                    func = true;
                    num_func = "-";
                }
            }
            else if(Cur_Str == "")
            {
                Remove_Click(this,e);
                Cur_Expr.Text += "-";
                func = true;
                num_func = "-";
            }
            else
            {
                Calculate();
                Cur_Expr.Text += "-";
                func = true;
                num_func = "-";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {

                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = float.Parse(Cur_Str);

                    Cur_Expr.Text = Cur_Str + "+";
                    Cur_Str = "";
                    func = true;
                    num_func = "+";
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                Cur_Expr.Text += "+";
                func = true;
                num_func = "+";
            }
            else
            {
                Calculate();
                Cur_Expr.Text += "+";
                func = true;
                num_func = "+";
            }


        }
        private void Mupltiple_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {

                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = float.Parse(Cur_Str);

                    Cur_Expr.Text = Cur_Str + "*";
                    Cur_Str = "";
                    func = true;
                    num_func = "*";
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                Cur_Expr.Text += "*";
                func = true;
                num_func = "*";
            }
            else
            {
                Calculate();
                Cur_Expr.Text += "*";
                func = true;
                num_func = "*";
            }
        }

        private void Part_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {

                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = float.Parse(Cur_Str);

                    Cur_Expr.Text = Cur_Str + "/";
                    Cur_Str = "";
                    func = true;
                    num_func = "/";
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                Cur_Expr.Text += "/";
                func = true;
                num_func = "/";
            }
            else
            {
                Calculate();
                Cur_Expr.Text += "/";
                func = true;
                num_func = "/";
            }
        }

        private void Num_Reverse_Click(object sender, EventArgs e)
        {
            if(Cur_Str != "" && (num_func == "0" || num_func == "200"))
            {
                Cur_Str = Convert.ToString(0 - float.Parse(Cur_Str));
                Cur_Expr.Text = Cur_Str;
            }else if (Cur_Str != "")
            {
                Cur_Str = Convert.ToString(0 - float.Parse(Cur_Str));
                Cur_Expr.Text = Convert.ToString(a) + num_func + Cur_Str;
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            Cur_Str = "3,1415926535897932384626433832795";
            if (num_func == "0" || num_func == "200")
            {
                Cur_Expr.Text = Cur_Str;
            }
            else
            { 
                Cur_Expr.Text = Convert.ToString(a) + num_func + Cur_Str;
            }

        }

        private void Clear_Str_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if(num_func == "0" || num_func == "200")
            {
                Console.WriteLine("sadasdsa");
                Cur_Str = Cur_Expr.Text;
                float p = float.Parse(Cur_Str);
                if (p % 1 != 0)
                {
                    a = float.Parse(Cur_Str);
                    num_func = "n!f";
                    func = true;
                    Calculate();
                }
                else
                {
                    a = float.Parse(Cur_Str);
                    num_func = "n!";
                    func = true;
                    Calculate();
                }

            }
            else
            {
                float p = float.Parse(Cur_Str);
                if (p % 1 != 0)
                {
                    a = float.Parse(Cur_Str);
                    num_func = "n!f";
                    func = true;
                    Calculate();
                }
                else
                {
                    num_func = "n!";
                    func = true;
                    Calculate();
                }
            }

        }

        private void Num_LPH_Click(object sender, EventArgs e)
        {
            Cur_Expr.Text += "(";
            Cur_Str += "(";
        }

        private void Num_RPH_Click(object sender, EventArgs e)
        {
            Cur_Expr.Text += ")";
            Cur_Str += ")";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if(num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)Math.Cos(x * Math.PI / 180);
                temp = "Cos(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)Math.Sin(x * Math.PI / 180);
                temp = "Sin(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)Math.Tan(x * Math.PI / 180);
                temp = "Tan(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = 1 / (float)Math.Tan(x * Math.PI / 180);
                temp = "Ctg(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void ATan_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)(Math.Atan(x) * 180 / Math.PI);
                temp = "ATan(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void ACot_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = 1 / (float)Math.Atan(x);
                temp = "ACtg(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void ASin_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)(Math.Asin(x) * 180 / Math.PI);
                temp = "ASin(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void ACos_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)(Math.Acos(x) * 180 / Math.PI);
                temp = "ACos(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            if (num_func == "0" || num_func == "200")
            {
                if (Cur_Str == "") { Cur_Str = "0"; }
                float x = float.Parse(Cur_Str);

                float c = (float)Math.Sqrt(x);
                temp = "√(" + x.ToString() + ") = " + c.ToString();
                journal.List.Items.Add(temp);

                x = c;
                Cur_Str = Convert.ToString(x);
                Cur_Expr.Text = Cur_Str;
            }
        }

        private void x_degy_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {

                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = float.Parse(Cur_Str);

                    Cur_Expr.Text = Cur_Str + "^";
                    Cur_Str = "";
                    func = true;
                    num_func = "x^y";
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                Cur_Expr.Text += "^";
                func = true;
                num_func = "x^y";
            }
            else
            {
                Calculate();
                Cur_Expr.Text += "^";
                func = true;
                num_func = "x^y";
            }
        }

        private void Degree_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {
                    Cur_Expr.Text = "10^";
                    a = 10;
                    func = true;
                    num_func = "x^y";
                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = 10;

                    func = true;
                    num_func = "x^y";
                    Calculate();
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                a = 10;
                Cur_Str = Cur_Expr.Text;
                func = true;
                num_func = "x^y";
                Calculate();
            }
            else
            {

            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {
                    Cur_Expr.Text = "Log";
                    a = 10;
                    func = true;
                    num_func = "log";
                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    a = 10;

                    func = true;
                    num_func = "log";
                    Calculate();
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                a = 10;
                Cur_Str = Cur_Expr.Text;
                func = true;
                num_func = "log";
                Calculate();
            }
            else
            {

            }
        }

        private void Nat_Log_Click(object sender, EventArgs e)
        {
            if (func == false)
            {
                if (Cur_Expr.Text == "0")
                {
                    Cur_Expr.Text = "ln";
                    func = true;
                    num_func = "ln";
                }
                else
                {
                    Cur_Str = Cur_Expr.Text;
                    func = true;
                    num_func = "ln";
                    Calculate();
                }
            }
            else if (Cur_Str == "")
            {
                Remove_Click(this, e);
                Cur_Str = Cur_Expr.Text;
                func = true;
                num_func = "ln";
                Calculate();
            }
            else
            {

            }
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {

            hist_enabled = true;

            int height = Size.Height;
            int width = Size.Width;
            Size = new Size(width+375,height); 


            journal.MdiParent = this;


            journal.Show();
            journal.Location = new Point(width-20, 0);

        }
        public void setsize()
        {
            journal.MdiParent = this;
            Size = new Size(440, 600);
        }

        private void Num_Float_Click(object sender, EventArgs e)
        {
            bool cur_float = false;
            for (int i = 0; i < Cur_Str.Length; i++)
            {
                if (Cur_Str[i] == ',') { cur_float = true; }
            }
            if (cur_float != true)
            {
                if (Cur_Str == "") { Cur_Str = "0,"; Cur_Expr.Text += ","; } else
                {
                    Cur_Str += ",";
                    Cur_Expr.Text += ",";
                }

            }
        }

    }
}