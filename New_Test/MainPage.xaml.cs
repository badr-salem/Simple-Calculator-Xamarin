using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace New_Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Sum(Object sender , EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);
            int z = x + y;
            lblResult.Text = z.ToString();
        }

        public void Min(Object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);
            int z = x - y;
            lblResult.Text = z.ToString();
        }
        public void Multi(Object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);
            int z = x * y;
            lblResult.Text = z.ToString();
        }

        public void Qsmh(Object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);
            int z = x / y;
            lblResult.Text = z.ToString();
        }
    }
}
