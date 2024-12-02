namespace DemoCocurrencia
{
    partial class FrmPatronSingleton
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
            BtnAsignar = new Button();
            BtnRecuperar = new Button();
            TxtCadenaConeccion = new TextBox();
            LblConeccion = new Label();
            LblCadenaConeccionRecuperar = new Label();
            SuspendLayout();
            // 
            // BtnAsignar
            // 
            BtnAsignar.Location = new Point(21, 154);
            BtnAsignar.Name = "BtnAsignar";
            BtnAsignar.Size = new Size(146, 52);
            BtnAsignar.TabIndex = 0;
            BtnAsignar.Text = "Asignar Cadena de Coneccion";
            BtnAsignar.UseVisualStyleBackColor = true;
            BtnAsignar.Click += BtnAsignar_Click;
            // 
            // BtnRecuperar
            // 
            BtnRecuperar.Location = new Point(21, 235);
            BtnRecuperar.Name = "BtnRecuperar";
            BtnRecuperar.Size = new Size(146, 55);
            BtnRecuperar.TabIndex = 1;
            BtnRecuperar.Text = "Obtener Cadena de coneccion";
            BtnRecuperar.UseVisualStyleBackColor = true;
            BtnRecuperar.Click += BtnRecuperar_Click;
            // 
            // TxtCadenaConeccion
            // 
            TxtCadenaConeccion.Location = new Point(21, 97);
            TxtCadenaConeccion.Name = "TxtCadenaConeccion";
            TxtCadenaConeccion.Size = new Size(571, 23);
            TxtCadenaConeccion.TabIndex = 2;
            // 
            // LblConeccion
            // 
            LblConeccion.AutoSize = true;
            LblConeccion.Location = new Point(46, 39);
            LblConeccion.Name = "LblConeccion";
            LblConeccion.Size = new Size(121, 15);
            LblConeccion.TabIndex = 3;
            LblConeccion.Text = "Cadena de coneccion";
            // 
            // LblCadenaConeccionRecuperar
            // 
            LblCadenaConeccionRecuperar.AutoSize = true;
            LblCadenaConeccionRecuperar.Location = new Point(46, 315);
            LblCadenaConeccionRecuperar.Name = "LblCadenaConeccionRecuperar";
            LblCadenaConeccionRecuperar.Size = new Size(16, 15);
            LblCadenaConeccionRecuperar.TabIndex = 4;
            LblCadenaConeccionRecuperar.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblCadenaConeccionRecuperar);
            Controls.Add(LblConeccion);
            Controls.Add(TxtCadenaConeccion);
            Controls.Add(BtnRecuperar);
            Controls.Add(BtnAsignar);
            Name = "FrmPatronSingleton";
            Text = "Demostracion de Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAsignar;
        private Button BtnRecuperar;
        private TextBox TxtCadenaConeccion;
        private Label LblConeccion;
        private Label LblCadenaConeccionRecuperar;
    }
}