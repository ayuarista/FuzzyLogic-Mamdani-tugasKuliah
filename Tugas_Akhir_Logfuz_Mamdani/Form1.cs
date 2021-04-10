using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_Logfuz_Mamdani
{
    public partial class kasus1 : Form
    {
        public kasus1()
        {
            InitializeComponent();
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            // Mencari Keanggotaan
            double PmMax, PmMin, Permintaan;
            double uTrn, uNak;
            {
                PmMax = double.Parse(pmMax.Text);
                PmMin = double.Parse(pmMin.Text);
                Permintaan = double.Parse(minta.Text);
                uTrn = rumus.turun(PmMax, PmMin, Permintaan);
                uTurun.Text = uTrn.ToString();
                uNak = rumus.naik(PmMax, PmMin, Permintaan);
                uNaik.Text = uNak.ToString();
            }
            double PsMax, PsMin, Persediaan;
            double uSdk, uByk;
            {
                PsMax = double.Parse(psMax.Text);
                PsMin = double.Parse(psMin.Text);
                Persediaan = double.Parse(sedia.Text);
                uSdk = rumus.sedikit(PsMax, PsMin, Persediaan);
                uByk = rumus.banyak(PsMax, PsMin, Persediaan);
                uSedikit.Text = uSdk.ToString();
                uBanyak.Text = uByk.ToString();
            }

            // Mencari Nilai Aturan ( a-predikat 1-4)
            double r1 = double.MinValue;
            double r2 = double.MinValue;
            double r3 = double.MinValue;
            double r4 = double.MinValue;
            // Aturan 1
            // Turun
            if ((pm1.Text == "Permintaan Turun") && (plh1.Text == "And") && (ps1.Text == "Persediaan Banyak"))
            {
                r1 = Math.Min(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Turun") && (plh1.Text == "And") && (ps1.Text == "Persediaan Sedikit"))
            {
                r1 = Math.Min(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Turun") && (plh1.Text == "Or") && (ps1.Text == "Persediaan Banyak"))
            {
                r1 = Math.Max(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Turun") && (plh1.Text == "Or") && (ps1.Text == "Persediaan Sedikit"))
            {
                r1 = Math.Max(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule1.Text = r1.ToString();
            }
            // Naik
            else if ((pm1.Text == "Permintaan Naik") && (plh1.Text == "And") && (ps1.Text == "Persediaan Banyak"))
            {
                r1 = Math.Min(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Naik") && (plh1.Text == "And") && (ps1.Text == "Persediaan Sedikit"))
            {
                r1 = Math.Min(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Naik") && (plh1.Text == "Or") && (ps1.Text == "Persediaan Banyak"))
            {
                r1 = Math.Max(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule1.Text = r1.ToString();
            }
            else if ((pm1.Text == "Permintaan Naik") && (plh1.Text == "Or") && (ps1.Text == "Persediaan Sedikit"))
            {
                r1 = Math.Max(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule1.Text = r1.ToString();
            }
            else { rule1.Text = "Pilih Aturan";
            }


            // Aturan 2
            // Turun
            if ((pm2.Text == "Permintaan Turun") && (plh2.Text == "And") && (ps2.Text == "Persediaan Banyak"))
            {
                r2 = Math.Min(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Turun") && (plh2.Text == "And") && (ps2.Text == "Persediaan Sedikit"))
            {
                r2 = Math.Min(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Turun") && (plh2.Text == "Or") && (ps2.Text == "Persediaan Banyak"))
            {
                r2 = Math.Max(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Turun") && (plh2.Text == "Or") && (ps2.Text == "Persediaan Sedikit"))
            {
                r2 = Math.Max(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule2.Text = r2.ToString();
            }
            //Naik
            else if ((pm2.Text == "Permintaan Naik") && (plh2.Text == "And") && (ps2.Text == "Persediaan Banyak"))
            {
                r2 = Math.Min(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Naik") && (plh2.Text == "And") && (ps2.Text == "Persediaan Sedikit"))
            {
                r2 = Math.Min(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Naik") && (plh2.Text == "Or") && (ps2.Text == "Persediaan Banyak"))
            {
                r2 = Math.Max(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule2.Text = r2.ToString();
            }
            else if ((pm2.Text == "Permintaan Naik") && (plh2.Text == "Or") && (ps2.Text == "Persediaan Sedikit"))
            {
                r2 = Math.Max(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule2.Text = r2.ToString();
            }
            else { rule2.Text = "Pilih Aturan";
            }

            //Aturan 3
            //Turun
            if ((pm3.Text == "Permintaan Turun") && (plh3.Text == "And") && (ps3.Text == "Persediaan Banyak"))
            {
                r3 = Math.Min(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Turun") && (plh3.Text == "And") && (ps3.Text == "Persediaan Sedikit"))
            {
                r3 = Math.Min(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Turun") && (plh3.Text == "Or") && (ps3.Text == "Persediaan Banyak"))
            {
                r3 = Math.Max(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Turun") && (plh3.Text == "Or") && (ps3.Text == "Persediaan Sedikit"))
            {
                r3 = Math.Max(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule3.Text = r3.ToString();

            }
            //Naik
            else if ((pm3.Text == "Permintaan Naik") && (plh3.Text == "And") && (ps3.Text == "Persediaan Banyak"))
            {
                r3 = Math.Min(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Naik") && (plh3.Text == "And") && (ps3.Text == "Persediaan Sedikit"))
            {
                r3 = Math.Min(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Naik") && (plh3.Text == "Or") && (ps3.Text == "Persediaan Banyak"))
            {
                r3 = Math.Max(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule3.Text = r3.ToString();
            }
            else if ((pm3.Text == "Permintaan Naik") && (plh3.Text == "Or") && (ps3.Text == "Persediaan Sedikit"))
            {
                r3 = Math.Max(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule3.Text = r3.ToString();
            }
            else { rule3.Text = "Pilih Aturan";
            }

            //Aturan 4
            //Turun
            if ((pm4.Text == "Permintaan Turun") && (plh4.Text == "And") && (ps4.Text == "Persediaan Banyak"))
            {
                r4 = Math.Min(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Turun") && (plh4.Text == "And") && (ps4.Text == "Persediaan Sedikit"))
            {
                r4 = Math.Min(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Turun") && (plh4.Text == "Or") && (ps4.Text == "Persediaan Banyak"))
            {
                r4 = Math.Max(Math.Round(uTrn, 2), Math.Round(uByk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Turun") && (plh4.Text == "Or") && (ps4.Text == "Persediaan Sedikit"))
            {
                r4 = Math.Max(Math.Round(uTrn, 2), Math.Round(uSdk, 2));
                rule4.Text = r4.ToString();
            }
            //Naik
            else if ((pm4.Text == "Permintaan Naik") && (plh4.Text == "And") && (ps4.Text == "Persediaan Banyak"))
            {
                r4 = Math.Min(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Naik") && (plh4.Text == "And") && (ps4.Text == "Persediaan Sedikit"))
            {
                r4 = Math.Min(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Naik") && (plh4.Text == "Or") && (ps4.Text == "Persediaan Banyak"))
            {
                r4 = Math.Max(Math.Round(uNak, 2), Math.Round(uByk, 2));
                rule4.Text = r4.ToString();
            }
            else if ((pm4.Text == "Permintaan Naik") && (plh4.Text == "Or") && (ps4.Text == "Persediaan Sedikit"))
            {
                r4 = Math.Max(Math.Round(uNak, 2), Math.Round(uSdk, 2));
                rule4.Text = r4.ToString();
            }
            else { rule4.Text = "Pilih Aturan";
            }


            double min = double.MinValue;
            double max = double.MinValue;


            // uPemesanan Bertambah, Berkurang
            // Mencari Min
            if (pr1.Text == "Pemesanan Berkurang")
            {
                min = r1;
                max = Math.Max(Math.Max(r2, r3), r4);
            }
            else if (pr2.Text == "Pemesanan Berkurang")
            {
                min = r2;
                max = Math.Max(Math.Max(r1, r3), r4);
            }
            else if (pr3.Text == "Pemesanan Berkurang")
            {
                min = r3;
                max = Math.Max(Math.Max(r1, r2), r4);
            }
            else if (pr4.Text == "Pemesanan Berkurang")
            {
                min = r4;
                max = Math.Max(Math.Max(r1, r2), r3);
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr2.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(r1, r2);
                max = Math.Max(r3, r4);
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(r1, r3);
                max = Math.Max(r2, r4);
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(r1, r4);
                max = Math.Max(r2, r3);
            }
            else if ((pr2.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(r2, r3);
                max = Math.Max(r1, r4);
            }
            else if ((pr2.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(r2, r4);
                max = Math.Max(r1, r3);
            }
            else if ((pr3.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min= Math.Max(r3, r4);
                max = Math.Max(r1, r2);
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr2.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(Math.Max(r1, r2), r3);
                max = r4;
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr2.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(Math.Max(r1, r2), r4);
                max = r3;
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(Math.Max(r1, r3), r4);
                max = r2;
            }
            else if ((pr2.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(Math.Max(r2, r3), r4);
                max = r1;
            }
            else if ((pr1.Text == "Pemesanan Berkurang") && (pr2.Text == "Pemesanan Berkurang") && (pr3.Text == "Pemesanan Berkurang") && (pr4.Text == "Pemesanan Berkurang"))
            {
                min = Math.Max(Math.Max(Math.Max(r1, r2), r3), r4);
                max = 0;
            }
            else if ((pr1.Text == "Pemesanan Bertambah") && (pr2.Text == "Pemesanan Bertambah") && (pr3.Text == "Pemesanan Bertambah") && (pr4.Text == "Pemesanan Bertambah"))
            {
                min = 0;
                max = Math.Max(Math.Max(Math.Max(r1, r2), r3), r4);
            }
            else { min = 0; max = 0;
            }

            // uPemesanan
            kpsn1.Text = min.ToString();
            kpsn2.Text = max.ToString();

            // nilai a1 dan a2
            // Mencari a1 dan a2
            double MinPro, MaxPro, a1, a2, m1, m2, m3, La1, La2, La3, z;
            MinPro = double.Parse(prMin.Text);
            MaxPro = double.Parse(prMax.Text);
            a1 = (min * (MaxPro - MinPro)) + (MinPro); // Mencari batas area 1
            a2 = (max * (MaxPro - MinPro)) +(MinPro); // Mencari batas area 2
            ta1.Text = a1.ToString();
            ta2.Text = a2.ToString();

            // Defuzzyfikasi Momen
            m1 = Math.Round(((0.5 * min) * Math.Pow(a1, 2)),2);
            m2 = Math.Round((1 / (MaxPro - MinPro)) * (((0.3333 * Math.Pow(a2, 3))) - ((MinPro / 2) * Math.Pow(a2, 2)) - (0.3333 * Math.Pow(a1, 3)) + ((MinPro / 2) * Math.Pow(a1, 2))), 2);
            m3 = Math.Round((((0.5 * max) * Math.Pow(MaxPro, 2)) - ((0.5 * max) * Math.Pow(a2, 2))),2);
            tm1.Text = m1.ToString();
            tm2.Text = m2.ToString();
            tm3.Text = m3.ToString();

            // Mencari Luas Area A1,A2,A3
            La1 = a1 * min;
            La2 = (min + max) * (a2 - a1) / 2;
            La3 = (MaxPro - (MaxPro - MinPro)) * max;
            la1.Text = La1.ToString();
            la2.Text = La2.ToString();
            la3.Text = La3.ToString();
            z = Math.Round((m1 + m2 + m3) / (La1 + La2 + La3),2); // Titik Pusat
            hasil.Text = z.ToString();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tentang_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            frm.Show();
            this.Hide();
        }
    }

    // Rumus uTurun, uNaik, uBanyak, uSedikit
    public partial class rumus
    {
        public static double turun(double PmMax, double PmMin, double Permintaan)
        {
            double u;
            if (Permintaan <= PmMin)
            {
                u = 1;
            }
            else if ((PmMin <= Permintaan) && (Permintaan <= PmMax))
            {
                u = (PmMax - Permintaan) / (PmMax - PmMin);
            }
            else
            {
                u = 0;
            }
            return u;
        }
        public static double naik(double PmMax, double PmMin, double Permintaan)
        {
            double u;
            if (Permintaan <= PmMin)
            {
                u = 1;
            }
            else if ((PmMin <= Permintaan) && (Permintaan <= PmMax))
            {
                u = (Permintaan - PmMin) / (PmMax - PmMin);
            }
            else
            {
                u = 0;
            }
            return u;
        }
        public static double sedikit(double PsMax, double PsMin, double Persediaan)
        {
            double u;
            if (Persediaan <= PsMin)
            {
                u = 1;
            }
            else if ((PsMin <= Persediaan) && (Persediaan <= PsMax))
            {
                u = (PsMax - Persediaan) / (PsMax - PsMin);
            }
            else
            {
                u = 0;
            }
            return u;
        }
        public static double banyak(double PsMax, double PsMin, double Persediaan)
        {
            double u;
            if (Persediaan <= PsMin)
            {
                u = 1;
            }
            else if ((PsMin <= Persediaan) && (Persediaan <= PsMax))
            {
                u = (Persediaan - PsMin) / (PsMax - PsMin);
            }
            else
            {
                u = 0;
            }
            return u;
        }
    }
}
