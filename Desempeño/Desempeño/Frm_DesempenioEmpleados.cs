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

        decimal TotProductividad = 0;

        decimal prodMDE;
        decimal prodDE;
        decimal prodAE;
        decimal prodME;
        decimal prodS;

        public void regularProductividad()
        {
            TotProductividad = Nud_productividadDE.Value +
                    Nud_productividadAE.Value +
                    Nud_productividadME.Value +
                    Nud_productividadS.Value +
                    Nud_productividadMDE.Value;

            if (TotProductividad == 3)
            {
                // guardar datos actuales
                prodDE = Nud_productividadDE.Value;
                prodAE = Nud_productividadAE.Value;
                prodME = Nud_productividadME.Value;
                prodS = Nud_productividadS.Value;
                prodMDE = Nud_productividadMDE.Value;
            }
            else if (TotProductividad < 3)
            {

            }
            else if (TotProductividad > 3)
            {
                Nud_productividadDE.Value = prodDE;
                Nud_productividadAE.Value = prodAE;
                Nud_productividadME.Value = prodME;
                Nud_productividadS.Value = prodS;
                Nud_productividadMDE.Value = prodMDE;

            }
        }

        decimal TotEficiencia = 0;

        decimal efiMDE;
        decimal efiDE;
        decimal efiAE;
        decimal efiME;
        decimal efiS;

        public void regularEficiencia()
        {
            TotEficiencia = Nud_eficienciaDE.Value +
                    Nud_eficienciaAE.Value +
                    Nud_eficienciaME.Value +
                    Nud_eficienciaS.Value +
                    Nud_eficienciaMDE.Value;

            if (TotEficiencia == 3)
            {
                // guardar datos actuales
                efiDE = Nud_eficienciaDE.Value;
                efiAE = Nud_eficienciaAE.Value;
                efiME = Nud_eficienciaME.Value;
                efiS = Nud_eficienciaS.Value;
                efiMDE = Nud_eficienciaMDE.Value;
            }
            else if (TotEficiencia < 3)
            {

            }
            else if (TotEficiencia > 3)
            {
                Nud_eficienciaDE.Value = efiDE;
                Nud_eficienciaAE.Value = efiAE;
                Nud_eficienciaME.Value = efiME;
                Nud_eficienciaS.Value = efiS;
                Nud_eficienciaMDE.Value = efiMDE;

            }
        }

        private void Nud_productividadAE_ValueChanged(object sender, EventArgs e)
        {
         regularProductividad();
            sumaTC();

        }

        public void sumaTC()
        {
            decimal sumaMDE = Nud_productividadMDE.Value + Nud_eficienciaMDE.Value + Nud_organizacionMDE.Value + 
                Nud_aprendizajeydesarrolloMDE.Value + Nud_comunicacionMDE.Value + Nud_relacionesinterpersonalesMDE.Value + 
                Nud_asistenciaMDE.Value;
            Txt_TCMDE.Text = sumaMDE.ToString();


            decimal sumaDE = Nud_productividadDE.Value + Nud_eficienciaDE.Value + Nud_organizacionDE.Value +
                Nud_aprendizajeydesarrolloDE.Value + Nud_comunicacionDE.Value + Nud_relacionesinterpersonalesDE.Value + 
                Nud_asistenciaDE.Value;
            Txt_TCDE.Text = sumaDE.ToString();
        }
        
        private void valorCambiado(object sender, EventArgs e)
        {
            regularProductividad();
            regularEficiencia();
            sumaTC();
        }
    }
}
