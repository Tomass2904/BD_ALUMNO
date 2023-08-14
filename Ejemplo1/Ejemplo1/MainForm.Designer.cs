/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 14/08/2023
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejemplo1
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
			this.picCentral = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCentral)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_1
			// 
			this.pic_1.Location = new System.Drawing.Point(540, 89);
			this.pic_1.Name = "pic_1";
			this.pic_1.Size = new System.Drawing.Size(100, 50);
			this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_1.TabIndex = 0;
			this.pic_1.TabStop = false;
			this.pic_1.Click += new System.EventHandler(this.func_click);
			// 
			// pic_2
			// 
			this.pic_2.Location = new System.Drawing.Point(540, 169);
			this.pic_2.Name = "pic_2";
			this.pic_2.Size = new System.Drawing.Size(100, 50);
			this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_2.TabIndex = 1;
			this.pic_2.TabStop = false;
			this.pic_2.Click += new System.EventHandler(this.func_click);
			// 
			// pic_3
			// 
			this.pic_3.Location = new System.Drawing.Point(540, 245);
			this.pic_3.Name = "pic_3";
			this.pic_3.Size = new System.Drawing.Size(100, 50);
			this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_3.TabIndex = 2;
			this.pic_3.TabStop = false;
			this.pic_3.Click += new System.EventHandler(this.func_click);
			// 
			// pic_4
			// 
			this.pic_4.Location = new System.Drawing.Point(540, 325);
			this.pic_4.Name = "pic_4";
			this.pic_4.Size = new System.Drawing.Size(100, 50);
			this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_4.TabIndex = 3;
			this.pic_4.TabStop = false;
			this.pic_4.Click += new System.EventHandler(this.func_click);
			// 
			// pic_5
			// 
			this.pic_5.Location = new System.Drawing.Point(540, 396);
			this.pic_5.Name = "pic_5";
			this.pic_5.Size = new System.Drawing.Size(100, 50);
			this.pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_5.TabIndex = 4;
			this.pic_5.TabStop = false;
			this.pic_5.Click += new System.EventHandler(this.func_click);
			// 
			// picCentral
			// 
			this.picCentral.Location = new System.Drawing.Point(108, 89);
			this.picCentral.Name = "picCentral";
			this.picCentral.Size = new System.Drawing.Size(390, 357);
			this.picCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCentral.TabIndex = 5;
			this.picCentral.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 540);
			this.Controls.Add(this.picCentral);
			this.Controls.Add(this.pic_5);
			this.Controls.Add(this.pic_4);
			this.Controls.Add(this.pic_3);
			this.Controls.Add(this.pic_2);
			this.Controls.Add(this.pic_1);
			this.Name = "MainForm";
			this.Text = "Ejemplo1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCentral)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picCentral;
		private System.Windows.Forms.PictureBox pic_5;
		private System.Windows.Forms.PictureBox pic_4;
		private System.Windows.Forms.PictureBox pic_3;
		private System.Windows.Forms.PictureBox pic_2;
		private System.Windows.Forms.PictureBox pic_1;
	}
}
