using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atlas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string [] vector;
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
			vector = new string [8];
			vector[0]=@"e:/tierra.png";
			vector[1]=@"e:/saturno.png";
			vector[2]=@"e:/neptuno.png";
			vector[3]=@"e:/jupiter.png";
			vector[4]=@"e:/venus.png";
			vector[5]=@"e:/urano.png";
			vector[6]=@"e:/mercurio.png";
			vector[7]=@"e:/marte.png";
			pic_1.Image=Image.FromFile(vector[0]);
			pic_2.Image=Image.FromFile(vector[1]);
			pic_3.Image=Image.FromFile(vector[2]);
			pic_4.Image=Image.FromFile(vector[3]);
			pic_5.Image=Image.FromFile(vector[4]);
			pic_6.Image=Image.FromFile(vector[5]);
			pic_7.Image=Image.FromFile(vector[6]);
			pic_8.Image=Image.FromFile(vector[7]);
		}
		void func_click (object sender, EventArgs e){
			PictureBox pic_aux;
			pic_aux = (PictureBox) sender;
			pic_central.Image=pic_aux.Image;
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			func_cargarDatos();
		}
	}
}
