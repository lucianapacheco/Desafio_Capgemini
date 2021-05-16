
namespace Anuncios {
    partial class Relatorios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblRelatorioAnuncio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckDtFinal = new System.Windows.Forms.CheckBox();
            this.ckDtInicio = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblIntervaloTempo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtRelatorio = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblRelatorioAnuncio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Azure;
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.Location = new System.Drawing.Point(12, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(26, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRelatorioAnuncio
            // 
            this.lblRelatorioAnuncio.AutoSize = true;
            this.lblRelatorioAnuncio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRelatorioAnuncio.ForeColor = System.Drawing.Color.Azure;
            this.lblRelatorioAnuncio.Location = new System.Drawing.Point(256, 9);
            this.lblRelatorioAnuncio.Name = "lblRelatorioAnuncio";
            this.lblRelatorioAnuncio.Size = new System.Drawing.Size(287, 37);
            this.lblRelatorioAnuncio.TabIndex = 0;
            this.lblRelatorioAnuncio.Text = "Relatórios de Anúncios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ckDtFinal);
            this.panel2.Controls.Add(this.ckDtInicio);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.dtTermino);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.lblIntervaloTempo);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 256);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Término";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Habilitar";
            // 
            // ckDtFinal
            // 
            this.ckDtFinal.AutoSize = true;
            this.ckDtFinal.Location = new System.Drawing.Point(22, 173);
            this.ckDtFinal.Name = "ckDtFinal";
            this.ckDtFinal.Size = new System.Drawing.Size(15, 14);
            this.ckDtFinal.TabIndex = 8;
            this.ckDtFinal.UseVisualStyleBackColor = true;
            this.ckDtFinal.CheckedChanged += new System.EventHandler(this.ckDtFinal_CheckedChanged);
            // 
            // ckDtInicio
            // 
            this.ckDtInicio.AutoSize = true;
            this.ckDtInicio.Location = new System.Drawing.Point(22, 129);
            this.ckDtInicio.Name = "ckDtInicio";
            this.ckDtInicio.Size = new System.Drawing.Size(15, 14);
            this.ckDtInicio.TabIndex = 7;
            this.ckDtInicio.UseVisualStyleBackColor = true;
            this.ckDtInicio.CheckedChanged += new System.EventHandler(this.ckDtInicio_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Azure;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFiltrar.Location = new System.Drawing.Point(154, 208);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 25);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtTermino
            // 
            this.dtTermino.Location = new System.Drawing.Point(54, 169);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(200, 23);
            this.dtTermino.TabIndex = 4;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(54, 126);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 23);
            this.dtInicio.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(54, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(200, 23);
            this.txtCliente.TabIndex = 2;
            // 
            // lblIntervaloTempo
            // 
            this.lblIntervaloTempo.AutoSize = true;
            this.lblIntervaloTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntervaloTempo.ForeColor = System.Drawing.Color.Azure;
            this.lblIntervaloTempo.Location = new System.Drawing.Point(54, 90);
            this.lblIntervaloTempo.Name = "lblIntervaloTempo";
            this.lblIntervaloTempo.Size = new System.Drawing.Size(144, 21);
            this.lblIntervaloTempo.TabIndex = 1;
            this.lblIntervaloTempo.Text = "Intervalo de tempo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.Azure;
            this.lblCliente.Location = new System.Drawing.Point(54, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // dtRelatorio
            // 
            this.dtRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRelatorio.Location = new System.Drawing.Point(297, 64);
            this.dtRelatorio.Name = "dtRelatorio";
            this.dtRelatorio.RowTemplate.Height = 25;
            this.dtRelatorio.Size = new System.Drawing.Size(545, 230);
            this.dtRelatorio.TabIndex = 2;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(869, 309);
            this.Controls.Add(this.dtRelatorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Relatorios";
            this.Text = "Relatórios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRelatorioAnuncio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblIntervaloTempo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckDtFinal;
        private System.Windows.Forms.CheckBox ckDtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}