namespace DemoCocurrencia
{
    partial class FrmBloqueos
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
            splitContainer1 = new SplitContainer();
            BtnDisminuir = new Button();
            LblContador = new Label();
            BtnIncrementar = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 38);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnDisminuir);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(771, 448);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 3;
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.BackColor = Color.FromArgb(192, 255, 255);
            BtnDisminuir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDisminuir.Location = new Point(12, 98);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(171, 73);
            BtnDisminuir.TabIndex = 5;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = false;
            BtnDisminuir.Click += button1_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.BackColor = Color.Teal;
            LblContador.Font = new Font("Franklin Gothic Medium", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(50, 217);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(107, 120);
            LblContador.TabIndex = 4;
            LblContador.Text = "0";
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.BackColor = Color.FromArgb(192, 255, 255);
            BtnIncrementar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIncrementar.Location = new Point(12, 15);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(171, 66);
            BtnIncrementar.TabIndex = 3;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = false;
            BtnIncrementar.Click += button2_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.FromArgb(192, 255, 255);
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(510, 448);
            TxtResultado.TabIndex = 1;
            TxtResultado.TabStop = false;
            TxtResultado.TextChanged += TxtResultado_TextChanged;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(802, 504);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Bloqueos";
            Load += FrmBloqueos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnDisminuir;
        private Label LblContador;
        private Button BtnIncrementar;
        private TextBox TxtResultado;
    }
}