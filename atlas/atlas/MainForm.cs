using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atlas
{
	
	public partial class MainForm : Form
	{
		public string [] planetas;
		public string [] info;
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void func_cargarDatos(){
			planetas = new string [8];
			info = new string[8];
			planetas[0]=@"e:/tierra.png";
			planetas[1]=@"e:/saturno.png";
			planetas[2]=@"e:/neptuno.png";
			planetas[3]=@"e:/jupiter.png";
			planetas[4]=@"e:/venus.png";
			planetas[5]=@"e:/urano.png";
			planetas[6]=@"e:/mercurio.png";
			planetas[7]=@"e:/marte.png";
			pic_1.Image=Image.FromFile(planetas[0]);
			pic_2.Image=Image.FromFile(planetas[1]);
			pic_3.Image=Image.FromFile(planetas[2]);
			pic_4.Image=Image.FromFile(planetas[3]);
			pic_5.Image=Image.FromFile(planetas[4]);
			pic_6.Image=Image.FromFile(planetas[5]);
			pic_7.Image=Image.FromFile(planetas[6]);
			pic_8.Image=Image.FromFile(planetas[7]);
			info[0]="La Tierra: es el tercer planeta del sistema solar comenzando a contar desde el Sol, ubicado entre Venus y Marte. Según nuestro conocimiento actual, es el único que alberga vida en todo el sistema solar. Se la designa astronómicamente con el símbolo ♁.";
			info[1]="Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra. Su nombre proviene del dios romano Saturno. Forma parte de los denominados planetas exteriores o gaseosos.";
			info[2]="Neptuno es muy parecido a Urano. Está compuesto de una espesa mezcla de agua, amoniaco y metano sobre un centro sólido del tamaño de la Tierra.";
			info[3]="Júpiter es un gigante hecho de gas, y no tiene una superficie sólida, pero puede tener un núcleo interno sólido de aproximadamente el tamaño de la Tierra. Júpiter también tiene anillos, pero son demasiado tenues para verlos muy bien.";
			info[4]="Venus es pequeño y rocoso. Su atmósfera es densa: atrapa el calor y por eso es tan caluroso. Tiene una superficie activa, que incluye volcanes. Gira en dirección contraria a la Tierra y la mayoría de los planetas.";
			info[5]="Urano es un gigante de hielo, en lugar de un gigante de gas. Está compuesto, en su mayor parte, por hielo fluido sobre un núcleo sólido. Tiene una atmósfera densa hecha de metano, hidrógeno y helio. Es el único planeta que rota de lado.";
			info[6]="Mercurio es el planeta más pequeño de nuestro sistema solar. Simplemente, es un poco más grande que la Luna de la Tierra. Es el planeta más cercano al Sol, pero no es realmente el más cálido. Venus es el más cálido.";
			info[7]="Marte es un planeta desértico y frío. Es la mitad del tamaño de la Tierra, y también recibe el nombre de planeta rojo. Es rojo por el hierro oxidado que tiene en el suelo. Como la Tierra, Marte tiene estaciones, casquetes polares, volcanes, cañones y clima.";
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
		void func_click_label(object sender, EventArgs e)
		{
		int idx =0;
			if (sender == lbl_Tierra){
				idx = 0;
			}
			if (sender == lbl_saturno){
				idx = 1;
			}
			if (sender == lbl_neptuno){
				idx = 2;
			}
			if (sender == lbl_jupiter){
				idx = 3;
			}
			if (sender == lbl_venus){
				idx = 4;
			}
			if (sender == lbl_urano){
				idx = 5;
			}
			if (sender == lbl_mercurio){
				idx = 6;
			}
			if (sender == lbl_marte){
				idx = 7;
			}
			pic_central.Image= Image.FromFile(planetas[idx]);
			lbl_info.Text = info[idx];
			//MessageBox.Show(info[idx]);
		}
	}
}
