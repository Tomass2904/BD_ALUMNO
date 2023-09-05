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
			imagen[0]=@"E:\7mo Computacion\Tomas Giachello\CarpetaProtegida\tp\img\papel.png";
			imagen[1]=@"E:\7mo Computacion\Tomas Giachello\CarpetaProtegida\tp\img\tijera.png";
			imagen[2]=@"E:\7mo Computacion\Tomas Giachello\CarpetaProtegida\tp\img\piedra.png";
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
			//piedra gana a tijera
			if (tagnum == 2 && pic_aux == 1){
				MessageBox.Show("GANASTE");
				ganada++;
				lbl_ganadas.Text="GANADAS= "+ganada;
			}
			//piedra pierde contra papel
			if (tagnum == 2 && pic_aux == 0){
				MessageBox.Show("PERDISTE");
				perdida++;
				lbl_perdidas.Text="PERDIDAS= "+perdida;
			}
			//tijera gana a papel
			if (tagnum == 1 && pic_aux == 0){
				MessageBox.Show("GANASTE");
				ganada++;
				lbl_ganadas.Text="GANADAS= "+ganada;
			}
			//tijera pierde contra piedra
			if (tagnum == 1 && pic_aux == 2){
				MessageBox.Show("PERDISTE");
				perdida++;
				lbl_perdidas.Text="PERDIDAS= "+perdida;
			}
			//papel gana a piedra
			if (tagnum == 0 && pic_aux == 2){
				MessageBox.Show("GANASTE");
				ganada++;
				lbl_ganadas.Text="GANADAS= "+ganada;
			}
			//papel pierde contra tijera
			if (tagnum == 0 && pic_aux == 1){
				MessageBox.Show("PERDISTE");
				perdida++;
				lbl_perdidas.Text="PERDIDAS= "+perdida;
			}
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cargar_datos();
		}
	}
}
