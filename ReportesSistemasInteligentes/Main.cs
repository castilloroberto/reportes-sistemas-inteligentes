using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesSistemasInteligentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_reporteProductos_Click(object sender, EventArgs e)
        {
            var reportePts = new ReporteProductos();
            reportePts.ShowDialog();
            
        }

        private void btn_reporteFiltro_Click(object sender, EventArgs e)
        {
            
            var reporteFiltro = new ReporteProductosParametro(txt_parametro.Text);
            reporteFiltro.ShowDialog();
        }
    }
}
