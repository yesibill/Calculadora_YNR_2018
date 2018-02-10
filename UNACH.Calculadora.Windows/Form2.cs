using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.Calculadora.Windows
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		bool secuencia = true, punto = true;
		string operacion ;

		private void btn1_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "1";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "1";
			}
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "3";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "3";
			}
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "4";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "4";
			}
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "5";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "5";
			}
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "6";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "6";
			}
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "7";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "7";
			}
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "8";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "8";
			}
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "9";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "9";
			}
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "0";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "0";
			}
		}

		private void btnmas_Click(object sender, EventArgs e)
		{
			operacion = "+";
			num1 = double.Parse(tbx.Text);
			secuencia = true;
		}

		private void btnmenos_Click(object sender, EventArgs e)
		{
			operacion = "-";
			num1 = double.Parse(tbx.Text);
			secuencia = true;
		}

		private void btnmulti_Click(object sender, EventArgs e)
		{
			operacion = "×";
			num1 = double.Parse(tbx.Text);
			secuencia = true;
		}

		private void btndivi_Click(object sender, EventArgs e)
		{
			operacion = "÷";
			num1 = double.Parse(tbx.Text);
			secuencia = true;
		}

		private void btnborrar_Click(object sender, EventArgs e)
		{
			
				tbx.Text = "0";
				num1 = 0;
				num2 = 0;
				secuencia = true;
			
		}

		private void btnigual_Click(object sender, EventArgs e)
		{

			num2 = double.Parse(tbx.Text);
			if (operacion == "+")
			{
				resultado = num1 + num2;
				tbx.Text = resultado.ToString();
				secuencia = true;
			}
			if (operacion == "-")
			{
				resultado = num1 - num2;
				tbx.Text = resultado.ToString();
				secuencia = true;
			}
			if (operacion == "×")
			{
				resultado = num1 * num2;
				tbx.Text = resultado.ToString();
				secuencia = true;
			}
			if (operacion == "÷")
			{
				resultado = num1 / num2;
				tbx.Text = resultado.ToString();
				secuencia = true;
			}
			if (operacion == "%")
			{
				resultado = num1 *(num2/100);
				tbx.Text = resultado.ToString();
				secuencia = true;
			}
		}

		private void btnporcent_Click(object sender, EventArgs e)
		{
			operacion = "%";
			num1 = double.Parse(tbx.Text);
			secuencia = true;
		}

		private void btnpunto_Click(object sender, EventArgs e)
		{
			if (punto == true)
			{
				tbx.Text = tbx.Text + ".";
				
			}
			else
			{
				punto = false;
			}
		}

		double num1, num2, resultado;

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void btn2_Click(object sender, EventArgs e)
		{
			if (secuencia == true)
			{
				tbx.Text = "";
				tbx.Text = "2";
				secuencia = false;
			}
			else
			{
				tbx.Text = tbx.Text + "2";
			}
		}
	}

	

		

		
	}

