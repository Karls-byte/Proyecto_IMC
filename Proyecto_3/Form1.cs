using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        static Conversición op = new Conversición();
        static Form2 Regresar = new Form2();

        public Form1()
        {​​​​​​​
            InitializeComponent();
        }​​​​​​​
 
        private void label1_Click(object sender, EventArgs e)
        {​​​​​​​
 
        }​​​​​​​ 
 
        private void lblresul_Click(object sender, EventArgs e)
        {​​​​​​​
 
        }​​​​​​​
 
        private void txtestatura_TextChanged(object sender, EventArgs e)
        {​​​​​​​
 
        }​​​​​​​
 
        private void cmdresultado_Click(object sender, EventArgs e)

        {​​​​​​​
           
            lblresul.Text = (op.IMC(double.Parse(txtpeso.Text), double.Parse(txtestatura.Text))).ToString();
            Regresar.Show();


        }​​​​​​​
 
        private void Form1_Load(object sender, EventArgs e)
        {​​​​​​​
 
        }
    }
}
