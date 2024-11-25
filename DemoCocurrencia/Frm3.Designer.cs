namespace DemoCocurrencia
{
    partial class Frm3
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
            LblContador = new Label();
            BtnCancelarPedido = new Button();
            BtnRegistrarPedido = new Button();
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
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnCancelarPedido);
            splitContainer1.Panel1.Controls.Add(BtnRegistrarPedido);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Location = new Point(104, 165);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(13, 15);
            LblContador.TabIndex = 0;
            LblContador.Text = "0";
            // 
            // BtnCancelarPedido
            // 
            BtnCancelarPedido.Location = new Point(43, 78);
            BtnCancelarPedido.Name = "BtnCancelarPedido";
            BtnCancelarPedido.Size = new Size(142, 23);
            BtnCancelarPedido.TabIndex = 1;
            BtnCancelarPedido.Text = "Cancelar Pedido";
            BtnCancelarPedido.UseVisualStyleBackColor = true;
            BtnCancelarPedido.Click += BtnCancelarPedido_Click;
            // 
            // BtnRegistrarPedido
            // 
            BtnRegistrarPedido.Location = new Point(43, 34);
            BtnRegistrarPedido.Name = "BtnRegistrarPedido";
            BtnRegistrarPedido.Size = new Size(142, 23);
            BtnRegistrarPedido.TabIndex = 0;
            BtnRegistrarPedido.Text = "Registrar Pedido";
            BtnRegistrarPedido.UseVisualStyleBackColor = true;
            BtnRegistrarPedido.Click += BtnRegistrarPedido_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.FromArgb(192, 255, 255);
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(530, 450);
            TxtResultado.TabIndex = 2;
            TxtResultado.TabStop = false;
            TxtResultado.TextChanged += TxtResultado_TextChanged;
            // 
            // Frm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Frm3";
            Text = "Frm3";
            Load += Frm3_Load;
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
        private Button BtnCancelarPedido;
        private Button BtnRegistrarPedido;
        private Label LblContador;
        private TextBox TxtResultado;
    }
}