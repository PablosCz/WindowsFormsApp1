using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string a, b;
        int Cislo, hrac1, hrac2, CelkemHodu = 0, soucet = 0;
        bool jeNaRadeHrac1 = true;
        Random rnd = new Random();
        List<int> list = new List<int>();
        int[] list1 = new int[6]; // Pole pro počítání objevení čísel 1-6

        public Form1(string _a, string _b)
        {
            InitializeComponent();
            a = _a;
            b = _b;
            lblHrac1.Text = a;
            lblHrac2.Text = b;
        }

        private void btnHodKostkou_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxCelkHodKostkou.Text, out CelkemHodu))
            {
                MessageBox.Show("Zadej číslo");
                return;
            }

            Cislo = rnd.Next(1, 7); // Generuje číslo 1-6
            soucet += Cislo;
            list.Add(Cislo);
            list1[Cislo - 1]++; // Aktualizace počtu objevení čísla

            vykreslitHistogram();
            lblCelkSoucet.Text = soucet.ToString();
            lblKostkaCislo.Text = Cislo.ToString();

            if (jeNaRadeHrac1)
            {
                if (list.Count == CelkemHodu) // Kontrola počtu hodů
                {
                    hrac1 = soucet;
                    lblHrac1Soucet.Text = hrac1.ToString();
                    soucet = 0;
                    list.Clear(); // Vymazání seznamu hodů pro druhého hráče
                    jeNaRadeHrac1 = false;
                }
            }
            else
            {
                if (list.Count == CelkemHodu)
                {
                    hrac2 = soucet;
                    lblHrac2Soucet.Text = hrac2.ToString();
                    vyhodnotVysledek();
                }
            }
        }

        private void vyhodnotVysledek()
        {
            if (hrac1 == hrac2)
            {
                MessageBox.Show("Remíza");
            }
            else if (hrac1 > hrac2)
            {
                MessageBox.Show(a + " vyhrál");
            }
            else
            {
                MessageBox.Show(b + " vyhrál");
            }

            MessageBox.Show("Padla vám čísla: " + String.Join(",", list.ToArray()));
            Application.Exit();
        }

        private void txtBoxCelkHodKostkou_TextChanged(object sender, EventArgs e)
        {
            btnHodKostkou.Enabled = !string.IsNullOrWhiteSpace(txtBoxCelkHodKostkou.Text) && int.TryParse(txtBoxCelkHodKostkou.Text, out _);
        }

        private void vykreslitHistogram()
        {
            var graf = chartHistogram.Series["Vysledky"];
            graf.Points.Clear();

            for (int i = 0; i < list1.Length; i++)
            {
                graf.Points.AddXY(i + 1, list1[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
