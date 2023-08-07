/*
 * Creado por SharpDevelop.
 * Usuario: PC.-01
 * Fecha: 04/08/2023
 * Hora: 19:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login_2._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_inicio;
		private System.Windows.Forms.Label lbl_usu;
		private System.Windows.Forms.Label lbl_contra;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		
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
			this.btn_inicio = new System.Windows.Forms.Button();
			this.lbl_usu = new System.Windows.Forms.Label();
			this.lbl_contra = new System.Windows.Forms.Label();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_inicio
			// 
			this.btn_inicio.Location = new System.Drawing.Point(69, 176);
			this.btn_inicio.Name = "btn_inicio";
			this.btn_inicio.Size = new System.Drawing.Size(134, 23);
			this.btn_inicio.TabIndex = 0;
			this.btn_inicio.Text = "Iniciar Sesion";
			this.btn_inicio.UseVisualStyleBackColor = true;
			this.btn_inicio.Click += new System.EventHandler(this.Btn_inicioClick);
			// 
			// lbl_usu
			// 
			this.lbl_usu.Location = new System.Drawing.Point(41, 45);
			this.lbl_usu.Name = "lbl_usu";
			this.lbl_usu.Size = new System.Drawing.Size(72, 23);
			this.lbl_usu.TabIndex = 1;
			this.lbl_usu.Text = "Usuario";
			// 
			// lbl_contra
			// 
			this.lbl_contra.Location = new System.Drawing.Point(41, 110);
			this.lbl_contra.Name = "lbl_contra";
			this.lbl_contra.Size = new System.Drawing.Size(72, 17);
			this.lbl_contra.TabIndex = 2;
			this.lbl_contra.Text = "Contraseña";
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(140, 45);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(100, 20);
			this.txt_usuario.TabIndex = 3;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(140, 107);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
			this.txt_contraseña.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.lbl_contra);
			this.Controls.Add(this.lbl_usu);
			this.Controls.Add(this.btn_inicio);
			this.Name = "MainForm";
			this.Text = "login 2.0";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
