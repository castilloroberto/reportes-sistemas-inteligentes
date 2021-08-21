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
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemasIDBDataSet.sp_rptProductros' Puede moverla o quitarla según sea necesario.
            this.sp_rptProductrosTableAdapter.Fill(this.SistemasIDBDataSet.sp_rptProductros);

            this.reportViewer1.RefreshReport();
        }
    }
}
