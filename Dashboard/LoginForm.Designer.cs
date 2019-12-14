namespace Dashboard
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(261, 59);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(223, 22);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(261, 104);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(223, 22);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(138, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(409, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(366, 170);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(158, 17);
            this.LinkLabel.TabIndex = 6;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "¿Olvido su contraseña?";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(556, 289);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Bienvenido al sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.LinkLabel LinkLabel;
    }
}

