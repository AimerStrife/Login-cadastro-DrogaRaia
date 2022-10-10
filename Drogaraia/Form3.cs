using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogaraia
{
    public partial class Form3 : Form
    {
        
        Dadocliente dclient = new Dadocliente();
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //salvar
            if ((textBox1.Text == null) || (textBox2.Text == null) || (textBox3.Text == null) || (textBox4.Text == null) ||
               (textBox5.Text == null) || (textBox6.Text == null) || (textBox7.Text == null))

            {
                MessageBox.Show("É obrigatório preencher todos os campos.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        



            else 
                dclient.setnome((textBox1.Text));
                dclient.setemail(textBox2.Text);
                dclient.setcpf(textBox3.Text);
                dclient.settelefone(textBox4.Text);
                dclient.setsenha(textBox5.Text);
                dclient.setdatanas(textBox7.Text);


                MessageBox.Show("Dados armazenados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            //Consultar 
            MessageBox.Show("\nNome:" + dclient.getnome() +
                              "\nEmail:" + dclient.getemail() +
                              "\nCPF:" + dclient.getcpf() +
                              "\nTelefone:" + dclient.gettelefone() +
                              "\nSenha:" + dclient.getsenha() +
                              "\nData Nascimento:" + dclient.getdatanas());
                       
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
    

