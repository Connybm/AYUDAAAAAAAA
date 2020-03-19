using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desempeño
{
    public partial class Frm_DesempenioEmpleados : Form
    {
        public Frm_DesempenioEmpleados()
        {
            InitializeComponent();
            DateTime fechaHoy = DateTime.Now;
            string fechaEvaluacion = fechaHoy.ToString("yyyy/MM/dd");
            Txt_fechaEvaluacion.Text = fechaEvaluacion;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puntaje: PT = Puntos Totales. PC = Puntos Categorías. TC = Total Categoria. " +
                "Categorías: MDE = Muy debajo de las Expectativas. DE = Debajo de las Expectativas. " +
                "AE = Alcanza Expectativas. ME = Mejora Expectativas. S = Sobresaliente.");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public int total;
        private void Txt_totalPT_TextChanged(object sender, EventArgs e)
        {
            total = 5 * 20;
            Txt_totalPT.Text = total.ToString();
        }

        public int PTMDE;
        private void Txt_PTMDE_TextChanged(object sender, EventArgs e)
        {
            PTMDE = (total / 5) * 0 + 0;
            Txt_PTMDE.Text = PTMDE.ToString();
        }

        public int PTDE;
        private void Txt_PTDE_TextChanged(object sender, EventArgs e)
        {
            PTDE = (total / 5) * 1 + 1;
            Txt_PTDE.Text = PTDE.ToString();
        }

        public int PTAE;
        private void Txt_PTAE_TextChanged(object sender, EventArgs e)
        {
            PTAE = (total / 5) * 2 + 1;
            Txt_PTAE.Text = PTAE.ToString();
        }

        public int PTME;
        private void Txt_PTME_TextChanged(object sender, EventArgs e)
        {
            PTME = (total / 5) * 3 + 1;
            Txt_PTME.Text = PTME.ToString();
        }

        public int PTS;
        private void Txt_PTS_TextChanged(object sender, EventArgs e)
        {
            PTS = (total / 5) * 4 + 1;
            Txt_PTS.Text = PTS.ToString();
        }

        public int totalCategoria;
        private void Txt_totalcategoria_TextChanged(object sender, EventArgs e)
        {
            totalCategoria = 19 + 1;
            Txt_totalcategoria.Text = totalCategoria.ToString();
        }

        public int PCMDE;
        private void Txt_PCMDE_TextChanged(object sender, EventArgs e)
        {
            PCMDE = 0 + 1;
            Txt_PCMDE.Text = PCMDE.ToString();
        }

        public int PCDE;
        private void Txt_PCDE_TextChanged(object sender, EventArgs e)
        {
            PCDE = PCMDE + 1;
            Txt_PCDE.Text = PCDE.ToString();
        }

        public int PCAE;
        private void Txt_PCAE_TextChanged(object sender, EventArgs e)
        {
            PCAE = PCDE + 1;
            Txt_PCAE.Text = PCAE.ToString();
        }

        public int PCME;
        private void Txt_PCME_TextChanged(object sender, EventArgs e)
        {
            PCME = PCAE + 1;
            Txt_PCME.Text = PCME.ToString();
        }

        public int PCS;
        private void Txt_PCS_TextChanged(object sender, EventArgs e)
        {
            PCS = PCME + 1;
            Txt_PCS.Text = PCS.ToString();
        }

        public int totalProducticidad = 0;
        private void Nud_productividadMDE_ValueChanged(object sender, EventArgs e)
        {
         /*   if(Nud_productividadMDE.Increment = true)
            {
                TotalP = totalProducticidad + Nud_productividadMDE.value;
            }
            else
            {
                TotalP = totalProducticidad - (3 - Nud_productividadMDE.value);
            };
            */
            if (Nud_productividadMDE.Value==3)
            {
                Nud_productividadDE.Enabled = false;
                Nud_productividadAE.Enabled = false;
                Nud_productividadME.Enabled = false;
                Nud_productividadS.Enabled = false;
            }
            else
            {
                Nud_productividadDE.Enabled = true;
                Nud_productividadAE.Enabled = true;
                Nud_productividadME.Enabled = true;
                Nud_productividadS.Enabled = true;
            }
        }

        private void Nud_productividadDE_ValueChanged(object sender, EventArgs e)
        {

            if (Nud_productividadDE.Value == 3)
            {
                Nud_productividadMDE.Enabled = false;
                Nud_productividadAE.Enabled = false;
                Nud_productividadME.Enabled = false;
                Nud_productividadS.Enabled = false;
            }
            else
            {
                Nud_productividadMDE.Enabled = true;
                Nud_productividadAE.Enabled = true;
                Nud_productividadME.Enabled = true;
                Nud_productividadS.Enabled = true;
            }
        }
    }
}
