
namespace Proyecto
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.Location = new System.Drawing.Point(96, 87);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(194, 26);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_clave.Location = new System.Drawing.Point(96, 178);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(194, 26);
            this.txt_clave.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_aceptar.Location = new System.Drawing.Point(41, 256);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(96, 32);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_registrar.Location = new System.Drawing.Point(187, 256);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(112, 32);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(27, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(27, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(344, 343);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_registrar;
    }
}