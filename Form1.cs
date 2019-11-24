using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Form1 : Form
    {
        int evidences = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMassMove_Click(object sender, EventArgs e)
        {
            evidences = evidences + 2;
            lblID.Text = "+2 evidencias!";
            txtContador.Text = evidences.ToString();
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            evidences = evidences + 2;
            lblID.Text = "+2 evidencias!";
            txtContador.Text = evidences.ToString();
        }

        private void btnWarn_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            evidences = Convert.ToInt32(txtInicializador.Text);
            txtContador.Text = evidences.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTp_Click(object sender, EventArgs e)
        {
            evidences = evidences + 1;
            lblID.Text = "+1 evidencia!";
            txtContador.Text = evidences.ToString();
        }
    }
}
