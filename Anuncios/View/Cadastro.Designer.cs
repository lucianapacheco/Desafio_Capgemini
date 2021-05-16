
namespace Anuncios {
    partial class Cadastro {
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
            this.lblNomeAnuncio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCadastroAnuncio = new System.Windows.Forms.Label();
            this.txtNomeAnuncio = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.lblInvestimento = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.txtInvestimento = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeAnuncio
            // 
            this.lblNomeAnuncio.AutoSize = true;
            this.lblNomeAnuncio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeAnuncio.Location = new System.Drawing.Point(12, 79);
            this.lblNomeAnuncio.Name = "lblNomeAnuncio";
            this.lblNomeAnuncio.Size = new System.Drawing.Size(141, 21);
            this.lblNomeAnuncio.TabIndex = 0;
            this.lblNomeAnuncio.Text = "Nome do anúncio: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblCadastroAnuncio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Azure;
            this.btnVoltar.Location = new System.Drawing.Point(12, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(26, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCadastroAnuncio
            // 
            this.lblCadastroAnuncio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroAnuncio.ForeColor = System.Drawing.Color.Azure;
            this.lblCadastroAnuncio.Location = new System.Drawing.Point(260, 9);
            this.lblCadastroAnuncio.Name = "lblCadastroAnuncio";
            this.lblCadastroAnuncio.Size = new System.Drawing.Size(280, 41);
            this.lblCadastroAnuncio.TabIndex = 0;
            this.lblCadastroAnuncio.Text = "Cadastro de Anúncios";
            // 
            // txtNomeAnuncio
            // 
            this.txtNomeAnuncio.Location = new System.Drawing.Point(192, 81);
            this.txtNomeAnuncio.Name = "txtNomeAnuncio";
            this.txtNomeAnuncio.Size = new System.Drawing.Size(290, 23);
            this.txtNomeAnuncio.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(12, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 21);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataInicio.Location = new System.Drawing.Point(12, 161);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(107, 21);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Data de início:";
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataTermino.Location = new System.Drawing.Point(12, 205);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(129, 21);
            this.lblDataTermino.TabIndex = 5;
            this.lblDataTermino.Text = "Data de término: ";
            // 
            // lblInvestimento
            // 
            this.lblInvestimento.AutoSize = true;
            this.lblInvestimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvestimento.Location = new System.Drawing.Point(12, 246);
            this.lblInvestimento.Name = "lblInvestimento";
            this.lblInvestimento.Size = new System.Drawing.Size(160, 21);
            this.lblInvestimento.TabIndex = 6;
            this.lblInvestimento.Text = "Investimento por dia: ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(192, 122);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(290, 23);
            this.txtCliente.TabIndex = 7;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(192, 161);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(290, 23);
            this.dtInicio.TabIndex = 8;
            // 
            // dtpTermino
            // 
            this.dtpTermino.Location = new System.Drawing.Point(192, 205);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(290, 23);
            this.dtpTermino.TabIndex = 9;
            // 
            // txtInvestimento
            // 
            this.txtInvestimento.Location = new System.Drawing.Point(192, 243);
            this.txtInvestimento.Name = "txtInvestimento";
            this.txtInvestimento.Size = new System.Drawing.Size(110, 23);
            this.txtInvestimento.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Azure;
            this.btnCadastrar.Location = new System.Drawing.Point(382, 237);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 32);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtInvestimento);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblInvestimento);
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNomeAnuncio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNomeAnuncio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAnuncio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeAnuncio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataTermino;
        private System.Windows.Forms.Label lblInvestimento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.TextBox txtInvestimento;
        private System.Windows.Forms.Label lblCadastroAnuncio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}