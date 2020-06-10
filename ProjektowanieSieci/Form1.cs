using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using ScottPlot;

namespace ProjektowanieSieci
{
    public partial class Form1 : Form
    {
        public static int V = 0;
        public static List<double> A_ratio = new List<double>();
        public static List<int> Ti = new List<int>();
        public static List<double> a = new List<double>();
        public static bool is_plot_logarithmic;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V = 0;
            is_plot_logarithmic = checkBox1.Checked;
            A_ratio = new List<double>();
            Ti = new List<int>();
            a = new List<double>();

            string V_temp = textBoxV.Text;
            string a_temp = textBoxA.Text;
            string A_temp = textBoxAn.Text;
            string Ti_temp = textBoxTi.Text;

            string error = null;

            try
            {
                V = int.Parse(V_temp);
            }
            catch (Exception ex)
            {
                error += "V musi być liczbą\n";
            }

            try
            {
                string[] temp = a_temp.Split(':');
                foreach (string value in temp)
                {
                    a.Add(double.Parse(value, CultureInfo.InvariantCulture));
                }
                if (a.Count != 3)
                {
                    error += "a musi się składać z 3 liczb w formacie a_start:a_stop:a_increment\n";
                }
            }
            catch (Exception ex)
            {
                error += "a musi się składać z 3 liczb w formacie a_start:a_stop:a_increment\n";
            }

            try
            {
                string[] temp = A_temp.Split(':');
                foreach (string value in temp)
                {
                    A_ratio.Add(int.Parse(value));
                }

            }
            catch (Exception ex)
            {
                error += "A1:A2... muszą być liczbami rozdzielonymi dwukropkiem\n";
            }

            try
            {
                string[] temp = Ti_temp.Split(':');
                foreach (string value in temp)
                {
                    Ti.Add(int.Parse(value));
                }
            }
            catch (Exception ex)
            {
                error += "Wartości Ti muszą być liczbami rozdzielonymi dwukropkiem\n";
            }

            if (A_ratio.Count != Ti.Count)
                error += "Ilość wartość Ti musi się równać ilości wartości Ai\n";

            if (error != null)
            {
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Wykres wykres = new Wykres();
            wykres.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
