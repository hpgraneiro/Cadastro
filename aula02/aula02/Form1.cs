using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class Form1 : Form
    {
        private object lb_aviso;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text == string.Empty)
            {
                lb_nome.ForeColor = Color.Red;
            }
            else
            {
                lb_nome.ForeColor = Color.Navy;
            }

            if (tb_sobrenome.Text == string.Empty)
            {
                lb_sobrenome.ForeColor = Color.Red;
            }
            else
            {
                lb_sobrenome.ForeColor = Color.Navy;
            }

            if (mtb_cpf.MaskFull == false)
            {
                lb_cpf.ForeColor = Color.Red;
            }
            else
            {
                lb_cpf.ForeColor = Color.Navy;
            }

            if (cb_estado.Text == "")
            {
                lb_estado.ForeColor = Color.Red;
            }
            else
            {
                lb_estado.ForeColor = Color.Navy;
            }

            if (rb_casado.Checked == false && rb_solteiro.Checked == false && rb_divorciado.Checked == false)
            {
                lb_estadocivil.ForeColor = Color.Red;
            }
            else
            {
                lb_estadocivil.ForeColor = Color.Navy;
            }

            if (tb_cidade.Text == string.Empty)
            {
                lb_cidade.ForeColor = Color.Red;
            }
            else
            {
                lb_cidade.ForeColor = Color.Navy;
            }

            if (mtb_celular.MaskFull == false)
            {
                lb_celular.ForeColor = Color.Red;
            }
            else
            {
                lb_celular.ForeColor = Color.Navy;
            }

            if (tb_endereco.Text == string.Empty)
            {
                lb_endereco.ForeColor = Color.Red;
            }
            else
            {
                lb_endereco.ForeColor = Color.Navy;
            }

            if (mtb_rg.MaskFull == false)
            {
                lb_rg.ForeColor = Color.Red;
            }
            else
            {
                lb_rg.ForeColor = Color.Navy;
            }

            if (tb_numero.Text == string.Empty)
            {
                lb_numero.ForeColor = Color.Red;
            }
            else
            {
                lb_numero.ForeColor = Color.Navy;
            }

            if (tb_complemento.Text == string.Empty)
            {
                lb_complemento.ForeColor = Color.Red;
            }
            else
            {
                lb_complemento.ForeColor = Color.Navy;
            }

            if ((String.Equals(tb_email.Text, tb_remail.Text)))
            {
                lb_aviso2.Text = "E-mail está incorreto.";
                lb_aviso2.Visible = false;
                lb_email.ForeColor = Color.Navy;
                lb_remail.ForeColor = Color.Navy;

            }
            else
            {
                lb_email.ForeColor = Color.Red;
                lb_remail.ForeColor = Color.Red;
                lb_aviso2.Visible = true;
            }
            if (tb_email.Text == string.Empty)
            {
                lb_email.ForeColor = Color.Red;
            }

            if (tb_remail.Text == string.Empty)
            {
                lb_remail.ForeColor = Color.Red;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_sobre sobre = new win_sobre();
            sobre.Show();
        }
    }
}
