namespace VegaJuego
{
    partial class PantallaInicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Programador = new Label();
            BotonInicio = new Button();
            bindingSource1 = new BindingSource(components);
            checkSonido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 204);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox2.Location = new Point(493, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 83);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Programador
            // 
            Programador.AutoSize = true;
            Programador.BackColor = Color.Transparent;
            Programador.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Programador.ForeColor = Color.SkyBlue;
            Programador.Location = new Point(547, 35);
            Programador.Name = "Programador";
            Programador.Size = new Size(106, 17);
            Programador.TabIndex = 2;
            Programador.Text = "Creado por Jota";
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.Black;
            BotonInicio.BackgroundImage = Properties.Resources.Boton;
            BotonInicio.BackgroundImageLayout = ImageLayout.None;
            BotonInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BotonInicio.ForeColor = Color.Gold;
            BotonInicio.Location = new Point(493, 184);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(211, 53);
            BotonInicio.TabIndex = 3;
            BotonInicio.Text = "Comienza la aventura";
            BotonInicio.TextAlign = ContentAlignment.MiddleRight;
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSonido.Location = new Point(12, 436);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(113, 19);
            checkSonido.TabIndex = 4;
            checkSonido.Text = "Sonido On / Off";
            checkSonido.UseVisualStyleBackColor = false;
            checkSonido.CheckedChanged += checkSonido_CheckedChanged;
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(806, 467);
            Controls.Add(checkSonido);
            Controls.Add(BotonInicio);
            Controls.Add(Programador);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Programador;
        private Button BotonInicio;
        private BindingSource bindingSource1;
        private CheckBox checkSonido;
    }
}