namespace DemoCocurrencia
{
    partial class FrmConcurrencia
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
            splitContainer1 = new SplitContainer();
            BtnCancelarProceso = new Button();
            BtnIniciarTarea = new Button();
            BtnIniciarHilo = new Button();
            BtnSecuencial = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.NavajoWhite;
            splitContainer1.Panel1.Controls.Add(BtnCancelarProceso);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(BtnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(583, 450);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCancelarProceso
            // 
            BtnCancelarProceso.BackColor = Color.FromArgb(192, 255, 192);
            BtnCancelarProceso.Location = new Point(40, 217);
            BtnCancelarProceso.Name = "BtnCancelarProceso";
            BtnCancelarProceso.Size = new Size(112, 48);
            BtnCancelarProceso.TabIndex = 2;
            BtnCancelarProceso.Text = "CANCELAR PROCESO";
            BtnCancelarProceso.UseVisualStyleBackColor = false;
            BtnCancelarProceso.Click += BtnCancelarhilo_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.BackColor = Color.FromArgb(192, 255, 192);
            BtnIniciarTarea.Location = new Point(40, 158);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(112, 44);
            BtnIniciarTarea.TabIndex = 0;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // BtnIniciarHilo
            // 
            BtnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilo.BackColor = Color.FromArgb(192, 255, 192);
            BtnIniciarHilo.Location = new Point(40, 101);
            BtnIniciarHilo.Name = "BtnIniciarHilo";
            BtnIniciarHilo.Size = new Size(112, 51);
            BtnIniciarHilo.TabIndex = 1;
            BtnIniciarHilo.Text = "Iniciar Hilo";
            BtnIniciarHilo.UseVisualStyleBackColor = false;
            BtnIniciarHilo.Click += BtnIniciarHilo_Click;
            // 
            // BtnSecuencial
            // 
            BtnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSecuencial.BackColor = Color.FromArgb(192, 255, 192);
            BtnSecuencial.Location = new Point(40, 42);
            BtnSecuencial.Name = "BtnSecuencial";
            BtnSecuencial.Size = new Size(112, 53);
            BtnSecuencial.TabIndex = 0;
            BtnSecuencial.Text = "IniciarSecuencial";
            BtnSecuencial.UseVisualStyleBackColor = false;
            BtnSecuencial.Click += BtnSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.FromArgb(192, 255, 255);
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(385, 450);
            TxtResultado.TabIndex = 0;
            TxtResultado.TextChanged += TxtResultado_TextChanged;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            Text = "Demostración de Concurrencia";
            Load += FrmConcurrencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnIniciarTarea;
        private Button BtnIniciarHilo;
        private Button BtnSecuencial;
        private TextBox TxtResultado;
        private Button BtnCancelarProceso;
    }
}
