/*
 * Created by SharpDevelop.
 * User: Dany
 * Date: 29/04/2014
 * Time: 01:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExamenPractica5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			string valores = "";
			int puntaje=0;
				
				if (this.checkBox1.Checked){
					puntaje=puntaje+1;
			}
								
			if (this.radioButton1.Checked){
				puntaje=puntaje+1;
			}
					
			if ( numericUpDown1.Value== 31 ){
				puntaje=puntaje+1;
			}
			
			if (checkBox4.Checked){
				puntaje=puntaje+1;
			}
			
			
			
			MessageBox.Show("Respuestas Correctas:"+ puntaje);
			
			
			 
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
		
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
