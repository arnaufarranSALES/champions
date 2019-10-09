namespace Splash
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.textb_user = new System.Windows.Forms.TextBox();
            this.textb_pass = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(173, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // textb_user
            // 
            this.textb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_user.Location = new System.Drawing.Point(254, 76);
            this.textb_user.Name = "textb_user";
            this.textb_user.Size = new System.Drawing.Size(130, 20);
            this.textb_user.TabIndex = 1;
            this.textb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // textb_pass
            // 
            this.textb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_pass.Location = new System.Drawing.Point(254, 115);
            this.textb_pass.Name = "textb_pass";
            this.textb_pass.PasswordChar = '*';
            this.textb_pass.Size = new System.Drawing.Size(130, 20);
            this.textb_pass.TabIndex = 2;
            this.textb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.Location = new System.Drawing.Point(309, 154);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 243);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.textb_pass);
            this.Controls.Add(this.textb_user);
            this.Controls.Add(this.pic_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(476, 282);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(476, 282);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox textb_user;
        private System.Windows.Forms.TextBox textb_pass;
        private System.Windows.Forms.Button btn_entrar;
    }
}

