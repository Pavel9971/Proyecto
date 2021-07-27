
namespace Proyecto
{
    partial class Frm_AgregarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.cbx_tipousuario = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(247, 70);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(224, 20);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(247, 114);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(224, 20);
            this.txt_clave.TabIndex = 5;
            // 
            // cbx_tipousuario
            // 
            this.cbx_tipousuario.FormattingEnabled = true;
            this.cbx_tipousuario.Location = new System.Drawing.Point(247, 162);
            this.cbx_tipousuario.Name = "cbx_tipousuario";
            this.cbx_tipousuario.Size = new System.Drawing.Size(224, 21);
            this.cbx_tipousuario.TabIndex = 6;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(262, 226);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(104, 30);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // Frm_AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 319);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cbx_tipousuario);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AgregarUsuario";
            this.Text = "Frm_AgregarUsuario";
            this.Load += new System.EventHandler(this.Frm_AgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.ComboBox cbx_tipousuario;
        private System.Windows.Forms.Button btn_registrar;
    }
}