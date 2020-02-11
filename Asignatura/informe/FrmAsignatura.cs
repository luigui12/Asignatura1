using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignatura.informe
{
    public partial class FrmAsignatura : Form
    {
        public FrmAsignatura()
        {
            InitializeComponent();
        }

        private void FrmAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAsignatura.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.dsAsignatura.Asignatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
