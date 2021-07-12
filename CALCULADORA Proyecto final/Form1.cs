using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_Proyecto_final
{
    public partial class Form1 : Form
    {
        string cantidad=string.Empty;
        int escooperacion;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "1";
            cantidad = cantidad + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "2";
            cantidad = cantidad + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "3";
            cantidad = cantidad + "3";
        }
       
        private void btn4_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "4";
            cantidad = cantidad + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "5";
            cantidad = cantidad + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "6";
            cantidad = cantidad + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "7";
            cantidad = cantidad + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "8";
            cantidad = cantidad + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "9";
            cantidad = cantidad + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            habilitarbtnsO();
            textBox1.Text = textBox1.Text + "0";
            cantidad = cantidad + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            { 
            textBox1.Text = textBox1.Text + ",";
            cantidad = cantidad + ",";
            btnpunto.Enabled = false;
            }
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            deshabilitarbtns();
            escooperacion = 1;
            btnpunto.Enabled = true;
            Operarvalores operarvalores = new Operarvalores();
            cantidad = cantidad + "+";
            operarvalores.sumanumeros(cantidad);
            textBox1.Text = "";
            txtmostrardatos.Text = $"{cantidad}";
            btnpunto.Enabled = true;
            btnporcentaje.Enabled = true;
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            deshabilitarbtns();
            escooperacion = 2;
            btnpunto.Enabled = true;
            Operarvalores operarvalores = new Operarvalores();
            cantidad = cantidad + "~";
            operarvalores.restanumeros(cantidad);
            textBox1.Text = "";
            txtmostrardatos.Text = $"{cantidad}";
            btnpunto.Enabled = true;
            btnporcentaje.Enabled = true;
        }
        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            deshabilitarbtns();
            escooperacion = 3;
            btnpunto.Enabled = true;
            Operarvalores operarvalores = new Operarvalores();
            cantidad = cantidad + "x";
            operarvalores.multnumeros(cantidad);
            textBox1.Text = "";
            txtmostrardatos.Text = $"{cantidad}";
            btnpunto.Enabled = true;
            btnporcentaje.Enabled = true;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            deshabilitarbtns();
            escooperacion = 4;
            btnpunto.Enabled = true;
            Operarvalores operarvalores = new Operarvalores();
            cantidad = cantidad + "÷";
            operarvalores.dividenumeros(cantidad);
            textBox1.Text = "";
            txtmostrardatos.Text = $"{cantidad}";
            btnpunto.Enabled = true;
            btnporcentaje.Enabled = true;
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            realizaroperaciones();
        }
        private void realizaroperaciones()
        {
            Operarvalores operaciones = new Operarvalores();
            switch(escooperacion)
            { 
                case 1: 
                    operaciones.sumanumeros(cantidad);
                    textBox1.Text = $"{operaciones.cantsuma}";
                    txtmostrardatos.Text = $"{cantidad} = ";
                    break;
                case 2:
                    operaciones.restanumeros(cantidad);
                    textBox1.Text = $"{operaciones.cantresta}";
                    txtmostrardatos.Text = $"{cantidad} = ";
                    break;
                case 3:
                    operaciones.multnumeros(cantidad);
                    textBox1.Text = $"{operaciones.cantmultiplicacion}";
                    txtmostrardatos.Text = $"{cantidad} = ";
                    break;
                case 4:
                    operaciones.dividenumeros(cantidad);
                    textBox1.Text = $"{operaciones.cantdivision}";
                    txtmostrardatos.Text = $"{cantidad} = ";
                    break;
            }
            txtmostrardatos.Text = $"= {textBox1.Text} ";
        }

        private void btnborrarT_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            btnporcentaje.Enabled = false;
            cantidad = string.Empty;
            textBox1.Text = string.Empty;
            txtmostrardatos.Text = string.Empty;
            deshabilitarbtns();
        }

        private void btnborrarD_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            cantidad = string.Empty;
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            deshabilitarbtns();
            btnporcentaje.Enabled = false;
           
        }

        private void btnborrarI_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            string gdatos = textBox1.Text;
            if(!string.IsNullOrEmpty(textBox1.Text))
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            txtmostrardatos.Text = $"√({gdatos})";
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            string gdatos = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox1.Text))
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text),2));
            txtmostrardatos.Text = $"{gdatos}² ";
        }

        private void btnfraccion_Click(object sender, EventArgs e)
        {
            string gdatos = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox1.Text))
            textBox1.Text = Convert.ToString(1/Convert.ToDouble(textBox1.Text));
            txtmostrardatos.Text = $"1/{gdatos} ";
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            string por = cantidad,imprimirdatos=string.Empty;
            switch (escooperacion)
            {
                case 1:
                    string[] porcensuma = por.Split('+');
                    if (!string.IsNullOrEmpty(textBox1.Text))
                        imprimirdatos = Convert.ToString((Convert.ToDecimal(porcensuma[0]) * Convert.ToDecimal(textBox1.Text)) / 100);
                    cantidad = Convert.ToString(Convert.ToDecimal(porcensuma[0]) + Convert.ToDecimal(imprimirdatos));
                    txtmostrardatos.Text = porcensuma[0] + "+" + imprimirdatos;
                    textBox1.Text = $"{cantidad}";
                    break;
                case 2:
                    string[] porcenresta = por.Split('~');
                    if (!string.IsNullOrEmpty(textBox1.Text))
                        imprimirdatos = Convert.ToString((Convert.ToDecimal(porcenresta[0]) * Convert.ToDecimal(textBox1.Text)) / 100);
                    cantidad = Convert.ToString(Convert.ToDecimal(porcenresta[0]) - Convert.ToDecimal(imprimirdatos));
                    txtmostrardatos.Text = porcenresta[0] + "-" + imprimirdatos;
                    textBox1.Text = $"{cantidad}";
                    break;
                case 3:
                    string[] porcenmultiplicacion = por.Split('x');
                    if (!string.IsNullOrEmpty(textBox1.Text))
                        imprimirdatos = Convert.ToString(( Convert.ToDecimal(textBox1.Text)) / 100);
                    cantidad = Convert.ToString(Convert.ToDecimal(porcenmultiplicacion[0])*Convert.ToDecimal(imprimirdatos));
                    txtmostrardatos.Text = porcenmultiplicacion[0] + "x" + imprimirdatos;
                    textBox1.Text = $"{cantidad}";
                    break;
                case 4:
                    string[] porcendivision = por.Split('÷');
                    if (!string.IsNullOrEmpty(textBox1.Text))
                        imprimirdatos = Convert.ToString((Convert.ToDecimal(textBox1.Text)) / 100);
                    cantidad = Convert.ToString(Convert.ToDecimal(porcendivision[0]) / Convert.ToDecimal(imprimirdatos));
                    txtmostrardatos.Text = porcendivision[0] + "÷" + imprimirdatos;
                    textBox1.Text = $"{cantidad}";
                    break;

            }
        }

        private void btnposneg_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            cantidad = Convert.ToString(Convert.ToInt32(textBox1.Text) * (-1));
            textBox1.Text = $"{cantidad}";
            txtmostrardatos.Text = $"{cantidad}";
        }
        private void habilitarbtnsO()
        {
            btnsumar.Enabled = true;
            btnrestar.Enabled = true;
            btnmultiplicar.Enabled = true;
            btndividir.Enabled = true;
            btnraiz.Enabled = true;
            btnposneg.Enabled = true;
            btnpotencia.Enabled = true;
            btnfraccion.Enabled = true;
        }
        private void deshabilitarbtns()
        {
            btnsumar.Enabled = false;
            btnrestar.Enabled = false;
            btnmultiplicar.Enabled = false;
            btndividir.Enabled = false;
            btnraiz.Enabled = false;
            btnposneg.Enabled = false;
            btnpotencia.Enabled = false;
            btnfraccion.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
