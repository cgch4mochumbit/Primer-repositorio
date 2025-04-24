using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question ) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string AppPath = Application.StartupPath;
            MessageBox.Show(AppPath+"\\", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
            ClaFUN.Loadvars(Application.StartupPath + "\\config.ini");
            MessageBox.Show(ClaFUN.Getvars("PATH_IMG"), "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(ClaFUN.Getvars("PATH_HTML"), "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
