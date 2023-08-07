
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login_2._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	
	public partial class MainForm : Form
	{
		usuario objusu;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Btn_inicioClick(object sender, EventArgs e)
		{
			int idx=-1;
			for (int i = 0; i < 5; i++) {
				if(txt_usuario.Text == objusu.usu[i]) {
					idx=i;
				}
			}
			if (idx != -1) {
				if (txt_contraseña.Text== objusu.contra[idx]) {
					MessageBox.Show("BIENVENIDO");
				}else {
					MessageBox.Show("Contraseña incorrecta");
				}
				
			}else{
				MessageBox.Show("Usuario incorrecto");
			}
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			objusu = new usuario();
			objusu.datos();
			
		}
		
	}
}
//
//if(txt_usuario.Text == usu[i]){
//					if(txt_contraseña.Text == contra[i]) {
//						MessageBox.Show("BIENVENIDO");
//					}
//					else if (txt_contraseña.Text != contra[i] ) {
//						MessageBox.Show("Contraseña incorrecta");
//					}
//				}
//				else if (txt_usuario.Text != usu[i]) {
//					MessageBox.Show("Usuario incorrecto");
//				}
//				else if ((txt_usuario.Text != usu[i]) && (txt_contraseña.Text != contra[i])) {
//					MessageBox.Show("Usuario y contraseña incorrectos");
//				}



