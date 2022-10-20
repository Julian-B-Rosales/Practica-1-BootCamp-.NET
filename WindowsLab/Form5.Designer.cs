namespace WindowsLab
{
    partial class Form5
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.txtUsertype = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los siguientes datos: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(160, 139);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(397, 136);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Location = new System.Drawing.Point(49, 195);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(316, 16);
            this.lblUsertype.TabIndex = 3;
            this.lblUsertype.Text = "Tipo de usuario (Administrador, Estandar o Invitado)";
            // 
            // txtUsertype
            // 
            this.txtUsertype.Location = new System.Drawing.Point(397, 189);
            this.txtUsertype.Name = "txtUsertype";
            this.txtUsertype.Size = new System.Drawing.Size(100, 22);
            this.txtUsertype.TabIndex = 4;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(118, 258);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(214, 16);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Sexo (Masculino, Femenino u Otro)";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(397, 252);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 22);
            this.txtSex.TabIndex = 6;
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(330, 347);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(125, 33);
            this.Validar.TabIndex = 7;
            this.Validar.Text = "Validar Datos";
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.Validar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtUsertype);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.TextBox txtUsertype;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Button Validar;
    }
}