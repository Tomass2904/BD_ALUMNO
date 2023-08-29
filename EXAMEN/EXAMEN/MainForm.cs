using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN
{
	public partial class MainForm : Form
	{
		public string [] imagen;
		public string [] label;
		public int tagnum;
		public int igual, distinto;
		public MainForm()
		{
			InitializeComponent();
		}
		void cargar_datos(){
			imagen = new string[5];
			label = new string[5];
			imagen[0]=@"E:\gato.jpg";
			imagen[1]=@"E:\perro.jpg";
			imagen[2]=@"E:\pez.jpg";
			imagen[3]=@"E:\tortuga.jpg";
			imagen[4]=@"E:\ave.jpg";
			pic_1.Image=Image.FromFile(imagen[0]);
			pic_2.Image=Image.FromFile(imagen[1]);
			pic_3.Image=Image.FromFile(imagen[2]);
			pic_4.Image=Image.FromFile(imagen[3]);
			pic_5.Image=Image.FromFile(imagen[4]);
			label[0]="GATO";
			label[1]="PERRO";
			label[2]="PEZ";
			label[3]="TORTUGA";
			label[4]="AVE";
			lbl_1.Text=label[0];
			lbl_2.Text=label[1];
			lbl_3.Text=label[2];
			lbl_4.Text=label[3];
			lbl_5.Text=label[4];
		}
		
		void func_click(object sender, EventArgs e){
			PictureBox pic_aux;
			pic_aux=(PictureBox) sender;
			tagnum= int.Parse(pic_aux.Tag.ToString());
			pic_central.Image=Image.FromFile(imagen[tagnum]);
			lbl_central.Text=""+label[tagnum];
		}
		
		void func_click_Label(object sender, EventArgs e){
			Label lbl_aux;
			lbl_aux=(Label) sender;
			tagnum= int.Parse(lbl_aux.Tag.ToString());
			pic_central.Image=Image.FromFile(imagen[tagnum]);
			lbl_central.Text=""+label[tagnum];
		}
		
		void func_click_compara(object sender, EventArgs e){
			Random comp = new Random();
			int pic_aux=comp.Next(5);
			pic_central_ran.Image=Image.FromFile(imagen[pic_aux]);
			lbl_comparar.Text=""+label[pic_aux];
			if (pic_aux == tagnum) {
				MessageBox.Show("SON IGUALES");
				igual++;
				lbl_iguales.Text="IGUALES= "+igual;
			}else{
				MessageBox.Show("SON DISTINTOS");
				distinto++;
				lbl_distintos.Text="DISTINTOS= "+distinto;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cargar_datos();
		}
	}
}

