using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_Proyecto_final
{

    public partial class Operarvalores:Ioperaciones
    {
        public decimal cantsuma { get; set; }
        public decimal cantresta { get; set; }
        public decimal cantmultiplicacion { get; set; }
        public decimal cantdivision { get; set; }
 
        public void sumanumeros(string valor)
        {
            try
            {
            string val = valor;
            decimal resultado = 0;
            string[] cadnumeros = val.Split('+');
            for (int i = 0; i < cadnumeros.Length; i++)
            {
                if (!string.IsNullOrEmpty(cadnumeros[i]))
                    resultado = resultado + Convert.ToDecimal(cadnumeros[i]);
            }
            cantsuma = resultado;
            }
            catch (Exception mes) {Console.WriteLine(mes.Message);}

        }
        public void restanumeros(string valor)
        {
            try
            {
            string val = valor;
            decimal resultado = 0;
            string[] cadnumeros = val.Split('~');
            for (int i = 0; i < cadnumeros.Length; i++)
            {
                if (!string.IsNullOrEmpty(cadnumeros[i]))
                {
                    if (resultado !=0 )
                        resultado = resultado - Convert.ToDecimal(cadnumeros[i]);
                    else if(resultado==0)
                        resultado = Convert.ToDecimal(cadnumeros[i]);
                }
            }
            cantresta = resultado;
            }
            catch (Exception mes) {Console.WriteLine(mes.Message);}

        }
        public void multnumeros(string valor)
        {
            try
            {
            string val = valor;
            decimal resultado = 1 ;
            string[] cadnumeros = val.Split('x');
            for (int i = 0; i < cadnumeros.Length; i++)
            {
                if (!string.IsNullOrEmpty(cadnumeros[i]))
                {
                        resultado = resultado * Convert.ToDecimal(cadnumeros[i]);
                }

            }
            cantmultiplicacion = resultado;

            }
            catch (Exception mes) { Console.WriteLine(mes.Message); }

        }
        public void dividenumeros(string valor)
        {
            try
            {
            string val = valor;
            decimal resultado= 0 ;
            string[] cadnumeros = val.Split('÷');
            for (int i = 0; i < cadnumeros.Length; i++)
            {
                if (!string.IsNullOrEmpty(cadnumeros[i]))
                {
                    if (resultado != 0)
                        resultado = resultado / Convert.ToDecimal(cadnumeros[i]);
                }
            }
            cantdivision = resultado;
            }
            catch (Exception mes) { Console.WriteLine(mes.Message); }

        }

    }
}
