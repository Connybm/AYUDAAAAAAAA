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
            TotEficiencia = Nud_eficienciaDE.Value + Nud_eficienciaAE.Value + Nud_eficienciaME.Value +
                    Nud_eficienciaS.Value + Nud_eficienciaMDE.Value;

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

        decimal TotOrganizacion = 0;

        decimal orgMDE;
        decimal orgDE;
        decimal orgAE;
        decimal orgME;
        decimal orgS;

        public void regularOrganizacion()
        {
            TotOrganizacion = Nud_organizacionDE.Value + Nud_organizacionAE.Value + Nud_organizacionME.Value +
                    Nud_organizacionS.Value + Nud_organizacionMDE.Value;

            if (TotOrganizacion == 3)
            {
                // guardar datos actuales
                orgDE = Nud_organizacionDE.Value;
                orgAE = Nud_organizacionAE.Value;
                orgME = Nud_organizacionME.Value;
                orgS = Nud_organizacionS.Value;
                orgMDE = Nud_organizacionMDE.Value;
            }
            else if (TotOrganizacion < 3)
            {

            }
            else if (TotOrganizacion > 3)
            {
                Nud_organizacionDE.Value = orgDE;
                Nud_organizacionAE.Value = orgAE;
                Nud_organizacionME.Value = orgME;
                Nud_organizacionS.Value = orgS;
                Nud_organizacionMDE.Value = orgMDE;
            }
        }

        decimal TotAprendizajeyDesarrollo = 0;

        decimal aydMDE;
        decimal aydDE;
        decimal aydAE;
        decimal aydME;
        decimal aydS;

        public void regularAprendizajeyDesarrollo()
        {
            TotAprendizajeyDesarrollo = Nud_aprendizajeydesarrolloDE.Value + Nud_aprendizajeydesarrolloAE.Value +
                    Nud_aprendizajeydesarrolloME.Value + Nud_aprendizajeydesarrolloS.Value +
                    Nud_aprendizajeydesarrolloMDE.Value;

            if (TotAprendizajeyDesarrollo == 3)
            {
                // guardar datos actuales
                aydDE = Nud_aprendizajeydesarrolloDE.Value;
                aydAE = Nud_aprendizajeydesarrolloAE.Value;
                aydME = Nud_aprendizajeydesarrolloME.Value;
                aydS = Nud_aprendizajeydesarrolloS.Value;
                aydMDE = Nud_aprendizajeydesarrolloMDE.Value;
            }
            else if (TotAprendizajeyDesarrollo < 3)
            {

            }
            else if (TotAprendizajeyDesarrollo > 3)
            {
                Nud_aprendizajeydesarrolloDE.Value = aydDE;
                Nud_aprendizajeydesarrolloAE.Value = aydAE;
                Nud_aprendizajeydesarrolloME.Value = aydME;
                Nud_aprendizajeydesarrolloS.Value = aydS;
                Nud_aprendizajeydesarrolloMDE.Value = aydMDE;
            }
        }

        decimal TotComunicacion = 0;

        decimal comuMDE;
        decimal comuDE;
        decimal comuAE;
        decimal comuME;
        decimal comuS;

        public void regularComunicacion()
        {
            TotComunicacion = Nud_comunicacionDE.Value + Nud_comunicacionAE.Value + Nud_comunicacionME.Value +
                    Nud_comunicacionS.Value + Nud_comunicacionMDE.Value;

            if (TotComunicacion == 3)
            {
                // guardar datos actuales
                comuDE = Nud_comunicacionDE.Value;
                comuAE = Nud_comunicacionAE.Value;
                comuME = Nud_comunicacionME.Value;
                comuS = Nud_comunicacionS.Value;
                comuMDE = Nud_comunicacionMDE.Value;
            }
            else if (TotComunicacion < 3)
            {

            }
            else if (TotComunicacion > 3)
            {
                Nud_comunicacionDE.Value = comuDE;
                Nud_comunicacionAE.Value = comuAE;
                Nud_comunicacionME.Value = comuME;
                Nud_comunicacionS.Value = comuS;
                Nud_comunicacionMDE.Value = comuMDE;
            }
        }

        decimal TotRelacionesInterpersonales = 0;

        decimal reinMDE;
        decimal reinDE;
        decimal reinAE;
        decimal reinME;
        decimal reinS;

        public void regularRelacionesInterpersonales()
        {
            TotRelacionesInterpersonales = Nud_relacionesinterpersonalesDE.Value + Nud_relacionesinterpersonalesAE.Value +
                    Nud_relacionesinterpersonalesME.Value + Nud_relacionesinterpersonalesS.Value +
                    Nud_relacionesinterpersonalesMDE.Value;

            if (TotRelacionesInterpersonales == 3)
            {
                // guardar datos actuales
                reinDE = Nud_relacionesinterpersonalesDE.Value;
                reinAE = Nud_relacionesinterpersonalesAE.Value;
                reinME = Nud_relacionesinterpersonalesME.Value;
                reinS = Nud_relacionesinterpersonalesS.Value;
                reinMDE = Nud_relacionesinterpersonalesMDE.Value;
            }
            else if (TotRelacionesInterpersonales < 3)
            {

            }
            else if (TotRelacionesInterpersonales > 3)
            {
                Nud_relacionesinterpersonalesDE.Value = reinDE;
                Nud_relacionesinterpersonalesAE.Value = reinAE;
                Nud_relacionesinterpersonalesME.Value = reinME;
                Nud_relacionesinterpersonalesS.Value = reinS;
                Nud_relacionesinterpersonalesMDE.Value = reinMDE;
            }
        }

        decimal TotAsistencia = 0;

        decimal asisMDE;
        decimal asisDE;
        decimal asisAE;
        decimal asisME;
        decimal asisS;

        public void regularAsistencia()
        {
            TotAsistencia = Nud_asistenciaDE.Value + Nud_asistenciaAE.Value + Nud_asistenciaME.Value +
                    Nud_asistenciaS.Value + Nud_asistenciaMDE.Value;

            if (TotAsistencia == 2)
            {
                // guardar datos actuales
                asisDE = Nud_asistenciaDE.Value;
                asisAE = Nud_asistenciaAE.Value;
                asisME = Nud_asistenciaME.Value;
                asisS = Nud_asistenciaS.Value;
                asisMDE = Nud_asistenciaMDE.Value;
            }
            else if (TotAsistencia < 2)
            {

            }
            else if (TotAsistencia > 2)
            {
                Nud_asistenciaDE.Value = asisDE;
                Nud_asistenciaAE.Value = asisAE;
                Nud_asistenciaME.Value = asisME;
                Nud_asistenciaS.Value = asisS;
                Nud_asistenciaMDE.Value = asisMDE;
            }
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

            decimal sumaAE = Nud_productividadAE.Value + Nud_eficienciaAE.Value + Nud_organizacionAE.Value +
                Nud_aprendizajeydesarrolloAE.Value + Nud_comunicacionAE.Value + Nud_relacionesinterpersonalesAE.Value +
                Nud_asistenciaAE.Value;
            Txt_TCAE.Text = sumaAE.ToString();

            decimal sumaME = Nud_productividadME.Value + Nud_eficienciaME.Value + Nud_organizacionME.Value +
                Nud_aprendizajeydesarrolloME.Value + Nud_comunicacionME.Value + Nud_relacionesinterpersonalesME.Value +
                Nud_asistenciaME.Value;
            Txt_TCME.Text = sumaME.ToString();

            decimal sumaS = Nud_productividadS.Value + Nud_eficienciaS.Value + Nud_organizacionS.Value +
                Nud_aprendizajeydesarrolloS.Value + Nud_comunicacionS.Value + Nud_relacionesinterpersonalesS.Value +
                Nud_asistenciaS.Value;
            Txt_TCS.Text = sumaS.ToString();
        }
        
        private void valorCambiado(object sender, EventArgs e)
        {
            regularProductividad();
            regularEficiencia();
            regularOrganizacion();
            regularAprendizajeyDesarrollo();
            regularComunicacion();
            regularRelacionesInterpersonales();
            regularAsistencia();
            sumaTC();
        }

        decimal Totalempleado;
        private void Txt_empleadosTotal_TextChanged(object sender, EventArgs e)
        {
            //Totalempleado = (Txt_PCMDE * Txt_TCMDE) + () +;
            Txt_empleadosTotal.Text = Totalempleado.ToString();
        }

        private void Txt_empleadosDesempeño_TextChanged(object sender, EventArgs e)
        {
            if ((Totalempleado >= 0) && (Totalempleado <= 21))
            {
                Txt_empleadosDesempeño.Text = "Muy debajo de las Expectativas";
            }
            else if ((Totalempleado >= 22) && (Totalempleado <= 40))
            {
                Txt_empleadosDesempeño.Text = "Debajo de las Expectativas";
            }
            else if ((Totalempleado >= 41) && (Totalempleado <= 60))
            {
                Txt_empleadosDesempeño.Text = "Alcanza Expectativas";
            }
            else if ((Totalempleado >= 61) && (Totalempleado <= 80))
            {
                Txt_empleadosDesempeño.Text = "Mejora Expectativas";
            }
            else if ((Totalempleado >= 81) && (Totalempleado <= 100))
            {
                Txt_empleadosDesempeño.Text = "Sobresaliente";
            }
        }
    }
}
