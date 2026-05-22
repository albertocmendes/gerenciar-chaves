using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciar_chaves
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Botão confirmar
        private void BTN_confirmar_Click(object sender, EventArgs e)
        {
            if (TXT_login.Text != "1734" || TXT_login.Text == "123")
            {
                MessageBox.Show(this, "Login inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_login.Focus();
                return;
            }
            else
            {
                this.Hide();
                FrmChaves frm = new FrmChaves();
                frm.ShowDialog();
                this.Close();
            }
        }

        //Ao digitar senha
        private void TXT_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_confirmar.Focus();
            }
        }

        //Botão cancelar
        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

   
