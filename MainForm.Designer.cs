/*
 * Created by SharpDevelop.
 * User: Tania
 * Date: 01/11/2013
 * Time: 10:10 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.cod = new System.Windows.Forms.TextBox();
			this.NOMBRE = new System.Windows.Forms.Label();
			this.nom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.df = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.Portugal = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.ReyU = new System.Windows.Forms.CheckBox();
			this.Macedonia = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.des = new System.Windows.Forms.NumericUpDown();
			this.calen = new System.Windows.Forms.MonthCalendar();
			((System.ComponentModel.ISupportInitialize)(this.des)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "CODIGO";
			// 
			// cod
			// 
			this.cod.Location = new System.Drawing.Point(68, 15);
			this.cod.Name = "cod";
			this.cod.Size = new System.Drawing.Size(100, 20);
			this.cod.TabIndex = 1;
			// 
			// NOMBRE
			// 
			this.NOMBRE.Location = new System.Drawing.Point(193, 18);
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.Size = new System.Drawing.Size(55, 23);
			this.NOMBRE.TabIndex = 2;
			this.NOMBRE.Text = "NOMBRE";
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(258, 14);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(100, 20);
			this.nom.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "1.-CAPITAL DE MEXICO";
			// 
			// df
			// 
			this.df.Location = new System.Drawing.Point(28, 94);
			this.df.Name = "df";
			this.df.Size = new System.Drawing.Size(57, 24);
			this.df.TabIndex = 5;
			this.df.TabStop = true;
			this.df.Text = "D.F";
			this.df.UseVisualStyleBackColor = true;
			this.df.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(89, 94);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "GUADALAJARA";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(199, 94);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "MONTERREY";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "2.-Pais de Europa";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// Portugal
			// 
			this.Portugal.Location = new System.Drawing.Point(28, 173);
			this.Portugal.Name = "Portugal";
			this.Portugal.Size = new System.Drawing.Size(104, 24);
			this.Portugal.TabIndex = 9;
			this.Portugal.Text = "Portugal";
			this.Portugal.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(28, 203);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 10;
			this.checkBox2.Text = "Chile";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// ReyU
			// 
			this.ReyU.Location = new System.Drawing.Point(28, 233);
			this.ReyU.Name = "ReyU";
			this.ReyU.Size = new System.Drawing.Size(104, 24);
			this.ReyU.TabIndex = 11;
			this.ReyU.Text = "Reino Unido";
			this.ReyU.UseVisualStyleBackColor = true;
			// 
			// Macedonia
			// 
			this.Macedonia.Location = new System.Drawing.Point(28, 263);
			this.Macedonia.Name = "Macedonia";
			this.Macedonia.Size = new System.Drawing.Size(104, 24);
			this.Macedonia.TabIndex = 12;
			this.Macedonia.Text = "Macedonia";
			this.Macedonia.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(28, 293);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(104, 24);
			this.checkBox5.TabIndex = 13;
			this.checkBox5.Text = "Australia";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 354);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(266, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "3.-Cantidad de estados de los que se compone Mexico";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(238, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 37);
			this.label5.TabIndex = 19;
			this.label5.Text = "4.-Fecha en que termino la segunda guerra mundia:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(301, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "TERMINAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// des
			// 
			this.des.Location = new System.Drawing.Point(39, 389);
			this.des.Name = "des";
			this.des.Size = new System.Drawing.Size(120, 20);
			this.des.TabIndex = 21;
			// 
			// calen
			// 
			this.calen.Location = new System.Drawing.Point(235, 185);
			this.calen.Name = "calen";
			this.calen.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 453);
			this.Controls.Add(this.calen);
			this.Controls.Add(this.des);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.Macedonia);
			this.Controls.Add(this.ReyU);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.Portugal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.df);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.NOMBRE);
			this.Controls.Add(this.cod);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Thania (Practica 6)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.des)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MonthCalendar calen;
		private System.Windows.Forms.RadioButton df;
		private System.Windows.Forms.CheckBox Portugal;
		private System.Windows.Forms.NumericUpDown des;
		private System.Windows.Forms.CheckBox ReyU;
		private System.Windows.Forms.CheckBox Macedonia;
		private System.Windows.Forms.TextBox cod;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label NOMBRE;
		private System.Windows.Forms.Label label1;
	}
}
