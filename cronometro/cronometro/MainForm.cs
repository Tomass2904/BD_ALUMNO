using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cronometro
{

	public partial class MainForm : Form
	{
		public string [] imagen;
		public int tagnum;
		public int ganada, perdida, empatada;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void cargar_datos(){
			imagen = new string[3];
			imagen[0]=@"C:\Users\Lab-01\Desktop\img\papel.png";
			imagen[1]=@"C:\Users\Lab-01\Desktop\img\tijera.png";
			imagen[2]=@"C:\Users\Lab-01\Desktop\img\piedra.png";
			pic_1.Image=Image.FromFile(imagen[0]);
			pic_2.Image=Image.FromFile(imagen[2]);
			pic_3.Image=Image.FromFile(imagen[1]);
			
		}
		void func_click(object sender, EventArgs e){
			PictureBox pic_aux;
			pic_aux=(PictureBox) sender;
			tagnum= int.Parse(pic_aux.Tag.ToString());
			pic_central.Image=Image.FromFile(imagen[tagnum]);
		}
		void func_click_compara(object sender, EventArgs e){
			Random comp = new Random();
			int pic_aux=comp.Next(3);
			pic_comparar.Image=Image.FromFile(imagen[pic_aux]);
			if (pic_aux == tagnum) {
				MessageBox.Show("EMPATE");
				empatada++;
				lbl_empate.Text="EMPATE= "+empatada;
			}
			 if (pic_aux != tagnum && tagnum == 0){
				MessageBox.Show("GANASTE");
				ganada++;
				lbl_ganadas.Text="GANADAS= "+ganada;
			}
			 if (pic_aux != tagnum && tagnum == 1){
				MessageBox.Show("PERDISTE");
				perdida++;
				lbl_perdidas.Text="PERDIDAS= "+perdida;
			}
//			 if (pic_aux != tagnum && tagnum == 2){
//				MessageBox.Show("GANASTE");
//				ganada++;
//				lbl_ganadas.Text="GANADAS= "+ganada;
//			}
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cargar_datos();
		}
	}
}
