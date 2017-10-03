using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        void OnButton_one(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            resul_.Text += b.Text.ToString();
        }
        void OnButton_equal(object sender, EventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                resul_.Text = "Error!";
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (resul_.Text.Contains("+"))
            {
                iOp = resul_.Text.IndexOf("+");
            }
            else if (resul_.Text.Contains("-"))
            {
                iOp = resul_.Text.IndexOf("-");
            }
            else if (resul_.Text.Contains("*"))
            {
                iOp = resul_.Text.IndexOf("*");
            }
            else if (resul_.Text.Contains("÷"))
            {
                iOp = resul_.Text.IndexOf("÷");
            }
            else
            {
                //error
            }

            op = resul_.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(resul_.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(resul_.Text.Substring(iOp + 1, resul_.Text.Length - iOp - 1));

            if (op == "+")
            {
                resul_.Text = Convert.ToString(op1 + op2);

            }
            else if (op == "-")
            {
                resul_.Text = Convert.ToString(op1 - op2);
            }
            else if (op == "*")
            {
                resul_.Text = Convert.ToString(op1 * op2);
            }
            else
            {
                resul_.Text = Convert.ToString(op1 / op2);
            }
        }
        void OnButton_point(object sender, EventArgs e)
        {
            if (!resul_.Text.Contains("."))
            {
                resul_.Text = resul_.Text += ".";
            }
        }
        void OnButton_clean(object sender, EventArgs e)
        {
            resul_.Text = null;
        }

        private void del_Clicked(object sender, EventArgs e)
        {
            if (resul_.Text.Length > 0)
            {
                resul_.Text = resul_.Text.Substring(0, resul_.Text.Length - 1);
            }
        }

        private void masmenos_Clicked(object sender, EventArgs e)
        {
            resul_.Text = Convert.ToString(Math.Abs(Convert.ToDecimal(resul_.Text)));
        }

        private void principal_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}