namespace GalletaFortuna
{
    partial class Galleta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galleta));
            this.btnMensaje = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(240)))), ((int)(((byte)(228)))));
            this.btnMensaje.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMensaje.Location = new System.Drawing.Point(486, 131);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(231, 67);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Fortuna";
            this.btnMensaje.UseVisualStyleBackColor = false;
            this.btnMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(432, 250);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(354, 23);
            this.mensaje.TabIndex = 1;
            this.mensaje.Text = "Presione el botón para tener su fortuna";
            this.mensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // Galleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 415);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.btnMensaje);
            this.DoubleBuffered = true;
            this.Name = "Galleta";
            this.Text = "Galleta de la Fortuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMensaje;
        private Label mensaje;
    }
}