
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_6
{
	
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		  
		 string codigo=cod.Text;
		 string nombre=nom.Text;
		 int aciertos=0;
		 
		 if (this.df.Checked==true){
		 	aciertos++;
		 }

		 
		 if(this.Portugal.Checked==true){
				aciertos ++;
			}
			if(this.ReyU.Checked==true){
				aciertos ++;
			}
			if(this.Macedonia.Checked==true){
				aciertos ++;
			}
			if(this.des.Text=="32"){
				aciertos ++;
			}
		 
			DateTime fech=calen.SelectionStart;
			
			if (fech.ToShortDateString()=="07/05/1945"){ 
				aciertos ++;
				
			}
		 
			MessageBox.Show("Codigo:"+cod.Text + "\nNombre:"+nom.Text +"\nAciertos:" + aciertos);
			
		}
	}
}
