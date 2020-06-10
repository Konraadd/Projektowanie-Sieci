using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using PrawdopodobieństwoBlokady;

namespace ProjektowanieSieci
{
    public partial class Wykres : Form
    {
        public Wykres()
        {
            InitializeComponent();
        }

        private void Wykres_Load(object sender, EventArgs e)
        {
            int V = Form1.V;
            List<double> A_ratio = Form1.A_ratio;
            List<int> t = Form1.Ti;
            List<double> a = Form1.a;
            List<double> Ai;
            List<List<double>> blocking_p = new List<List<double>>();
            List<double> x_data = new List<double>(a.Count);


            /*
            List<double> x_data = new List<double>(a.Count);
            List<List<double>> blocking_p = new List<List<double>>();
            for (int i = 0; i < Ti.Count; i++)
            {
                blocking_p.Add(new List<double>());
            }
            for (double i = a[0]; i < a[1]; i += a[2])
            {
                x_data.Add(i);

                List<double> temp = KaufmanRoberts.BlockingPropabilities(V, Ti, i, A_ratio);
                for (int c = 0; c < temp.Count; c++)
                {
                    blocking_p.ElementAt(c).Add(temp[c]);
                }
            }
            */
            for (double i = a[0]; i < a[1]; i += a[2])
            {
                x_data.Add(i);
                double aR = Math.Round(i, 1);       //zaokrąglone a
                Ai = KaufmanRoberts.calculateAi(A_ratio, aR, V, t);
                
                List<double> temp = KaufmanRoberts.BlockingPropabilities(V, t, Ai, aR);
                for (int c = 0; c < temp.Count; c++)
                {
                    blocking_p.ElementAt(c).Add(temp[c]);
                }
            }


            // zapelnienie wykresu danymi
            this.formsPlot1.plt.Clear();
            int count = 0;
            foreach (List<double> values in blocking_p)
            {
                this.formsPlot1.plt.PlotSignalXY(x_data.ToArray(), ScottPlot.Tools.Log10(values.ToArray()), label: "Klasa A" + count.ToString());
            }

            this.formsPlot1.plt.Ticks(logScaleY: true);
            this.formsPlot1.plt.XLabel("Oferowanych ruch a");
            this.formsPlot1.plt.YLabel("Prawdopodobieństwo blokady (10^)");
            double[] bounds = this.formsPlot1.plt.AxisAuto(0.05, 0.1);
            this.formsPlot1.plt.AxisBounds(bounds[0], bounds[1], bounds[2], bounds[3]);
            this.formsPlot1.plt.Legend();
            
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
