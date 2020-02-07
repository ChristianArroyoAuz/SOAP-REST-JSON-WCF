namespace ClienteWcf
{
    partial class Form1
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
            this.btnBienvenido = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBienvenido
            // 
            this.btnBienvenido.Location = new System.Drawing.Point(56, 38);
            this.btnBienvenido.Name = "btnBienvenido";
            this.btnBienvenido.Size = new System.Drawing.Size(100, 23);
            this.btnBienvenido.TabIndex = 0;
            this.btnBienvenido.Text = "Bienvenido";
            this.btnBienvenido.UseVisualStyleBackColor = true;
            this.btnBienvenido.Click += new System.EventHandler(this.btnBienvenido_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 74);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBienvenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBienvenido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

