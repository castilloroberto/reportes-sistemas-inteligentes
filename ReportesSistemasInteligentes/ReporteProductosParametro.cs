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
    public partial class ReporteProductosParametro : Form
    {
        private string _parametro; 
        public ReporteProductosParametro(string parametro)
        {
            InitializeComponent();
            _parametro = parametro;
        }

        private void ReporteProductosParametro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemasIDBDataSet.sp_rptProductrosFiltro' Puede moverla o quitarla según sea necesario.
            this.sp_rptProductrosFiltroTableAdapter.Fill(this.SistemasIDBDataSet.sp_rptProductrosFiltro,_parametro);

            this.reportViewer1.RefreshReport();
        }
    }
}
