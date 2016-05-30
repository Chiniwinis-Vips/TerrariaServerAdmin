using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerrariaServerAdmin
{
    public partial class Inicio : Form
    {
        private int lang = 1;
        private string mapa = null;
        private string ignoreplugin = null;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string dir = Environment.SpecialFolder.MyDocuments+@"/My Games/Terraria/Worlds/";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = dir;
            openFileDialog.Filter = "Terraria World|*.wld";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_buscarmapa.Text = openFileDialog.FileName;
                mapa = openFileDialog.FileName;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_buscarmapa.Text))
            {
                MessageBox.Show("Tiene que escoger un mapa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!File.Exists("TerrariaServer.exe"))
                {
                    MessageBox.Show("Error no se pudo encontrar 'TerrariaServer.exe'", "Error Ejecutable no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("TerrariaServer.exe");
                psi.Arguments = "-lang "+lang+" -world "+ mapa+ " "+ignoreplugin;
                p.StartInfo = psi;
                p.Start();
                Hide();
                p.WaitForExit();
                Show();
            }
        }

        private void ck_ignoreversion_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ignoreversion.Checked)
            {
                MessageBox.Show("En algunos casos puede dar problemas");
                ignoreplugin = "-ignoreversion";
                return;
            }
            else
                ignoreplugin = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _lang = comboBox1.Text;
            if ((string.Compare(_lang, "1:Inglés", StringComparison.Ordinal) == 0))
            {
                lang = 1;
                return;
            }
            if ((string.Compare(_lang, "2:Alemán", StringComparison.Ordinal) == 0))
            {
                lang = 2;
                return;
            }
            if ((string.Compare(_lang, "3:Italiano", StringComparison.Ordinal) == 0))
            {
                lang = 3;
                return;
            }
            if ((string.Compare(_lang, "4:Francés", StringComparison.Ordinal) == 0))
            {
                lang = 4;
                return;
            }
            if ((string.Compare(_lang, "5:Español", StringComparison.Ordinal) == 0))
            {
                lang = 5;
                return;
            }
        }
    }
}
