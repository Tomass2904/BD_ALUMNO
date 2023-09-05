/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 04/09/2023
 * Time: 20:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cronometro
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
			this.pic_1 = new System.Windows.Forms.PictureBox();
			this.pic_2 = new System.Windows.Forms.PictureBox();
			this.pic_3 = new System.Windows.Forms.PictureBox();
			this.pic_central = new System.Windows.Forms.PictureBox();
			this.pic_comparar = new System.Windows.Forms.PictureBox();
			this.btn_compara = new System.Windows.Forms.Button();
			this.lbl_ganadas = new System.Windows.Forms.Label();
			this.lbl_perdidas = new System.Windows.Forms.Label();
			this.lbl_empate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_comparar)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_1
			// 
			this.pic_1.Location = new System.Drawing.Point(12, 12);
			this.pic_1.Name = "pic_1";
			this.pic_1.Size = new System.Drawing.Size(199, 139);
			this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_1.TabIndex = 0;
			this.pic_1.TabStop = false;
			this.pic_1.Tag = "0";
			this.pic_1.Click += new System.EventHandler(this.func_click);
			// 
			// pic_2
			// 
			this.pic_2.Location = new System.Drawing.Point(12, 475);
			this.pic_2.Name = "pic_2";
			this.pic_2.Size = new System.Drawing.Size(199, 139);
			this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_2.TabIndex = 1;
			this.pic_2.TabStop = false;
			this.pic_2.Tag = "2";
			this.pic_2.Click += new System.EventHandler(this.func_click);
			// 
			// pic_3
			// 
			this.pic_3.Location = new System.Drawing.Point(12, 249);
			this.pic_3.Name = "pic_3";
			this.pic_3.Size = new System.Drawing.Size(199, 139);
			this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_3.TabIndex = 2;
			this.pic_3.TabStop = false;
			this.pic_3.Tag = "1";
			this.pic_3.Click += new System.EventHandler(this.func_click);
			// 
			// pic_central
			// 
			this.pic_central.Location = new System.Drawing.Point(331, 144);
			this.pic_central.Name = "pic_central";
			this.pic_central.Size = new System.Drawing.Size(315, 214);
			this.pic_central.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_central.TabIndex = 3;
			this.pic_central.TabStop = false;
			// 
			// pic_comparar
			// 
			this.pic_comparar.Location = new System.Drawing.Point(761, 144);
			this.pic_comparar.Name = "pic_comparar";
			this.pic_comparar.Size = new System.Drawing.Size(315, 214);
			this.pic_comparar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_comparar.TabIndex = 4;
			this.pic_comparar.TabStop = false;
			// 
			// btn_compara
			// 
			this.btn_compara.Location = new System.Drawing.Point(656, 401);
			this.btn_compara.Name = "btn_compara";
			this.btn_compara.Size = new System.Drawing.Size(87, 23);
			this.btn_compara.TabIndex = 8;
			this.btn_compara.Text = "COMPARAR";
			this.btn_compara.UseVisualStyleBackColor = true;
			this.btn_compara.Click += new System.EventHandler(this.func_click_compara);
			// 
			// lbl_ganadas
			// 
			this.lbl_ganadas.Location = new System.Drawing.Point(331, 452);
			this.lbl_ganadas.Name = "lbl_ganadas";
			this.lbl_ganadas.Size = new System.Drawing.Size(100, 23);
			this.lbl_ganadas.TabIndex = 9;
			this.lbl_ganadas.Text = "GANADAS:";
			// 
			// lbl_perdidas
			// 
			this.lbl_perdidas.Location = new System.Drawing.Point(331, 497);
			this.lbl_perdidas.Name = "lbl_perdidas";
			this.lbl_perdidas.Size = new System.Drawing.Size(100, 23);
			this.lbl_perdidas.TabIndex = 10;
			this.lbl_perdidas.Text = "PERDIDAS:";
			// 
			// lbl_empate
			// 
			this.lbl_empate.Location = new System.Drawing.Point(331, 545);
			this.lbl_empate.Name = "lbl_empate";
			this.lbl_empate.Size = new System.Drawing.Size(100, 23);
			this.lbl_empate.TabIndex = 11;
			this.lbl_empate.Text = "EMPATADAS:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 648);
			this.Controls.Add(this.lbl_empate);
			this.Controls.Add(this.lbl_perdidas);
			this.Controls.Add(this.lbl_ganadas);
			this.Controls.Add(this.btn_compara);
			this.Controls.Add(this.pic_comparar);
			this.Controls.Add(this.pic_central);
			this.Controls.Add(this.pic_3);
			this.Controls.Add(this.pic_2);
			this.Controls.Add(this.pic_1);
			this.Name = "MainForm";
			this.Text = "cronometro";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_comparar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_empate;
		private System.Windows.Forms.Label lbl_perdidas;
		private System.Windows.Forms.Label lbl_ganadas;
		private System.Windows.Forms.Button btn_compara;
		private System.Windows.Forms.PictureBox pic_comparar;
		private System.Windows.Forms.PictureBox pic_central;
		private System.Windows.Forms.PictureBox pic_3;
		private System.Windows.Forms.PictureBox pic_2;
		private System.Windows.Forms.PictureBox pic_1;
	}
}
