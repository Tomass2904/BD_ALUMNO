/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 14/08/2023
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejemplo1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string [] vector ;
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
		void func_cargarDatos(){
			vector = new string [5];
			vector[0]=@"D:/7mo/imagen1.jpg";
			vector[1]=@"D:/7mo/imagen2.jpg";
			vector[2]=@"D:/7mo/imagen3.jpg";
			vector[3]=@"D:/7mo/imagen4.jpg";
			vector[4]=@"D:/7mo/imagen5.jpg";
			pic_1.Image=Image.FromFile(vector[0]);
			pic_2.Image=Image.FromFile(vector[1]);
			pic_3.Image=Image.FromFile(vector[2]);
			pic_4.Image=Image.FromFile(vector[3]);
			pic_5.Image=Image.FromFile(vector[4]);
		}
		
		void func_click (object sender, EventArgs e){
			PictureBox pic_aux;
			pic_aux = (PictureBox) sender;
			picCentral.Image=pic_aux.Image;
		}
		
//		void Pic_1Click(object sender, EventArgs e)
//		{
//
//			pic_1.Image=Image.FromFile(@"e:/ben10.jpg");
////			pic_2.Image=Image.FromFile(@"e:/c rie.jpg");
////			pic_3.Image=Image.FromFile(@"e:/muerciegalo.jpg");
////			pic_4.Image=Image.FromFile(@"e:/papa.jpg");
////			pic_5.Image=Image.FromFile(@"e:/PERRO.jpg");
////
//		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			func_cargarDatos();
		}
	}
}
