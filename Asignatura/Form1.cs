using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignatura
{
    public partial class FrmGuardar : Form
    {
        public FrmGuardar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar...  " + " Tenga buen dia :) ");
            this.Close();
        }

        private void FrmGuardar_Load(object sender, EventArgs e)
        {
            cargarGridAsignatura();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            //creamos instancia de la clase Estudiante
            Academico.Asignatura asignatura = new Academico.Asignatura();
            //pasamos los valores de la cajas de texto a cada items
            asignatura.codAsignatura = this.codigo.Text;
            asignatura.nombre = this.nombre.Text;
            asignatura.nivel = int.Parse(this.nivel.Text);
            asignatura.creditos = int.Parse(this.creditos.Text);
            asignatura.carrera = this.carrera.Text;
            try
            {
                x = Academico.AsignaturaDAO.guardar(asignatura);
                cargarGridAsignatura();
                MessageBox.Show("Filas agregadas: " + x.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void cargarGridAsignatura()
        {
            this.dataGridView1.DataSource = Academico.AsignaturaDAO.getDatos();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.codigo.Text = "";
            this.nombre.Text = "";
            this.nivel.Text = "";
            this.creditos.Text = "";
            this.carrera.Text = "";
        }
    }
}
