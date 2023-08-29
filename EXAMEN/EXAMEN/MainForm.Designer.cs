/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 28/08/2023
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EXAMEN
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
			this.pic_4 = new System.Windows.Forms.PictureBox();
			this.pic_5 = new System.Windows.Forms.PictureBox();
			this.pic_central = new System.Windows.Forms.PictureBox();
			this.lbl_1 = new System.Windows.Forms.Label();
			this.lbl_2 = new System.Windows.Forms.Label();
			this.lbl_3 = new System.Windows.Forms.Label();
			this.lbl_4 = new System.Windows.Forms.Label();
			this.lbl_5 = new System.Windows.Forms.Label();
			this.pic_central_ran = new System.Windows.Forms.PictureBox();
			this.btn_comparar = new System.Windows.Forms.Button();
			this.lbl_iguales = new System.Windows.Forms.Label();
			this.lbl_distintos = new System.Windows.Forms.Label();
			this.lbl_central = new System.Windows.Forms.Label();
			this.lbl_comparar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central_ran)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_1
			// 
			this.pic_1.Location = new System.Drawing.Point(45, 42);
			this.pic_1.Name = "pic_1";
			this.pic_1.Size = new System.Drawing.Size(100, 50);
			this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_1.TabIndex = 0;
			this.pic_1.TabStop = false;
			this.pic_1.Tag = "0";
			this.pic_1.Click += new System.EventHandler(this.func_click);
			// 
			// pic_2
			// 
			this.pic_2.Location = new System.Drawing.Point(45, 164);
			this.pic_2.Name = "pic_2";
			this.pic_2.Size = new System.Drawing.Size(100, 50);
			this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_2.TabIndex = 1;
			this.pic_2.TabStop = false;
			this.pic_2.Tag = "1";
			this.pic_2.Click += new System.EventHandler(this.func_click);
			// 
			// pic_3
			// 
			this.pic_3.Location = new System.Drawing.Point(45, 260);
			this.pic_3.Name = "pic_3";
			this.pic_3.Size = new System.Drawing.Size(100, 50);
			this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_3.TabIndex = 2;
			this.pic_3.TabStop = false;
			this.pic_3.Tag = "2";
			this.pic_3.Click += new System.EventHandler(this.func_click);
			// 
			// pic_4
			// 
			this.pic_4.Location = new System.Drawing.Point(45, 361);
			this.pic_4.Name = "pic_4";
			this.pic_4.Size = new System.Drawing.Size(100, 50);
			this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_4.TabIndex = 3;
			this.pic_4.TabStop = false;
			this.pic_4.Tag = "3";
			this.pic_4.Click += new System.EventHandler(this.func_click);
			// 
			// pic_5
			// 
			this.pic_5.Location = new System.Drawing.Point(45, 488);
			this.pic_5.Name = "pic_5";
			this.pic_5.Size = new System.Drawing.Size(100, 50);
			this.pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_5.TabIndex = 4;
			this.pic_5.TabStop = false;
			this.pic_5.Tag = "4";
			this.pic_5.Click += new System.EventHandler(this.func_click);
			// 
			// pic_central
			// 
			this.pic_central.Location = new System.Drawing.Point(257, 164);
			this.pic_central.Name = "pic_central";
			this.pic_central.Size = new System.Drawing.Size(435, 202);
			this.pic_central.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_central.TabIndex = 5;
			this.pic_central.TabStop = false;
			// 
			// lbl_1
			// 
			this.lbl_1.Location = new System.Drawing.Point(151, 69);
			this.lbl_1.Name = "lbl_1";
			this.lbl_1.Size = new System.Drawing.Size(100, 23);
			this.lbl_1.TabIndex = 6;
			this.lbl_1.Tag = "0";
			this.lbl_1.Text = "label1";
			this.lbl_1.Click += new System.EventHandler(this.func_click_Label);
			// 
			// lbl_2
			// 
			this.lbl_2.Location = new System.Drawing.Point(151, 191);
			this.lbl_2.Name = "lbl_2";
			this.lbl_2.Size = new System.Drawing.Size(100, 23);
			this.lbl_2.TabIndex = 7;
			this.lbl_2.Tag = "1";
			this.lbl_2.Text = "label2";
			this.lbl_2.Click += new System.EventHandler(this.func_click_Label);
			// 
			// lbl_3
			// 
			this.lbl_3.Location = new System.Drawing.Point(151, 287);
			this.lbl_3.Name = "lbl_3";
			this.lbl_3.Size = new System.Drawing.Size(100, 23);
			this.lbl_3.TabIndex = 8;
			this.lbl_3.Tag = "2";
			this.lbl_3.Text = "label3";
			this.lbl_3.Click += new System.EventHandler(this.func_click_Label);
			// 
			// lbl_4
			// 
			this.lbl_4.Location = new System.Drawing.Point(151, 388);
			this.lbl_4.Name = "lbl_4";
			this.lbl_4.Size = new System.Drawing.Size(100, 23);
			this.lbl_4.TabIndex = 9;
			this.lbl_4.Tag = "3";
			this.lbl_4.Text = "label4";
			this.lbl_4.Click += new System.EventHandler(this.func_click_Label);
			// 
			// lbl_5
			// 
			this.lbl_5.Location = new System.Drawing.Point(151, 515);
			this.lbl_5.Name = "lbl_5";
			this.lbl_5.Size = new System.Drawing.Size(100, 23);
			this.lbl_5.TabIndex = 10;
			this.lbl_5.Tag = "4";
			this.lbl_5.Text = "label5";
			this.lbl_5.Click += new System.EventHandler(this.func_click_Label);
			// 
			// pic_central_ran
			// 
			this.pic_central_ran.Location = new System.Drawing.Point(698, 164);
			this.pic_central_ran.Name = "pic_central_ran";
			this.pic_central_ran.Size = new System.Drawing.Size(435, 202);
			this.pic_central_ran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_central_ran.TabIndex = 11;
			this.pic_central_ran.TabStop = false;
			// 
			// btn_comparar
			// 
			this.btn_comparar.Location = new System.Drawing.Point(647, 444);
			this.btn_comparar.Name = "btn_comparar";
			this.btn_comparar.Size = new System.Drawing.Size(75, 23);
			this.btn_comparar.TabIndex = 12;
			this.btn_comparar.Text = "COMPARAR";
			this.btn_comparar.UseVisualStyleBackColor = true;
			this.btn_comparar.Click += new System.EventHandler(this.func_click_compara);
			// 
			// lbl_iguales
			// 
			this.lbl_iguales.Location = new System.Drawing.Point(440, 501);
			this.lbl_iguales.Name = "lbl_iguales";
			this.lbl_iguales.Size = new System.Drawing.Size(100, 23);
			this.lbl_iguales.TabIndex = 13;
			this.lbl_iguales.Text = "IGUALES=0";
			// 
			// lbl_distintos
			// 
			this.lbl_distintos.Location = new System.Drawing.Point(849, 501);
			this.lbl_distintos.Name = "lbl_distintos";
			this.lbl_distintos.Size = new System.Drawing.Size(100, 23);
			this.lbl_distintos.TabIndex = 14;
			this.lbl_distintos.Text = "DISTINTOS=0";
			// 
			// lbl_central
			// 
			this.lbl_central.Location = new System.Drawing.Point(393, 388);
			this.lbl_central.Name = "lbl_central";
			this.lbl_central.Size = new System.Drawing.Size(100, 23);
			this.lbl_central.TabIndex = 15;
			this.lbl_central.Text = "label1";
			// 
			// lbl_comparar
			// 
			this.lbl_comparar.Location = new System.Drawing.Point(813, 388);
			this.lbl_comparar.Name = "lbl_comparar";
			this.lbl_comparar.Size = new System.Drawing.Size(100, 23);
			this.lbl_comparar.TabIndex = 16;
			this.lbl_comparar.Text = "label2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(1166, 593);
			this.Controls.Add(this.lbl_comparar);
			this.Controls.Add(this.lbl_central);
			this.Controls.Add(this.lbl_distintos);
			this.Controls.Add(this.lbl_iguales);
			this.Controls.Add(this.btn_comparar);
			this.Controls.Add(this.pic_central_ran);
			this.Controls.Add(this.lbl_5);
			this.Controls.Add(this.lbl_4);
			this.Controls.Add(this.lbl_3);
			this.Controls.Add(this.lbl_2);
			this.Controls.Add(this.lbl_1);
			this.Controls.Add(this.pic_central);
			this.Controls.Add(this.pic_5);
			this.Controls.Add(this.pic_4);
			this.Controls.Add(this.pic_3);
			this.Controls.Add(this.pic_2);
			this.Controls.Add(this.pic_1);
			this.Name = "MainForm";
			this.Text = "EXAMEN";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central_ran)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_comparar;
		private System.Windows.Forms.Label lbl_central;
		private System.Windows.Forms.Label lbl_distintos;
		private System.Windows.Forms.Label lbl_iguales;
		private System.Windows.Forms.Button btn_comparar;
		private System.Windows.Forms.PictureBox pic_central_ran;
		private System.Windows.Forms.Label lbl_5;
		private System.Windows.Forms.Label lbl_4;
		private System.Windows.Forms.Label lbl_3;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.Label lbl_1;
		private System.Windows.Forms.PictureBox pic_central;
		private System.Windows.Forms.PictureBox pic_5;
		private System.Windows.Forms.PictureBox pic_4;
		private System.Windows.Forms.PictureBox pic_3;
		private System.Windows.Forms.PictureBox pic_2;
		private System.Windows.Forms.PictureBox pic_1;
	}
}
