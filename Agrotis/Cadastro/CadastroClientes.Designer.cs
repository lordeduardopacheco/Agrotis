
namespace Agrotis.Cadastro
{
    partial class CadastroClientes
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
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label codigo_IBGELabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label uFLabel;
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.codigo_IBGETextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            bairroLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            codigo_IBGELabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            this.tabPadrao.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPadrao
            // 
            this.tabPadrao.AutoScroll = true;
            this.tabPadrao.Controls.Add(this.cepMaskedTextBox);
            this.tabPadrao.Controls.Add(bairroLabel);
            this.tabPadrao.Controls.Add(cEPLabel);
            this.tabPadrao.Controls.Add(this.bairroTextBox);
            this.tabPadrao.Controls.Add(cidadeLabel);
            this.tabPadrao.Controls.Add(this.cidadeTextBox);
            this.tabPadrao.Controls.Add(codigoLabel);
            this.tabPadrao.Controls.Add(this.codigoTextBox);
            this.tabPadrao.Controls.Add(codigo_IBGELabel);
            this.tabPadrao.Controls.Add(this.codigo_IBGETextBox);
            this.tabPadrao.Controls.Add(complementoLabel);
            this.tabPadrao.Controls.Add(this.complementoTextBox);
            this.tabPadrao.Controls.Add(logradouroLabel);
            this.tabPadrao.Controls.Add(this.logradouroTextBox);
            this.tabPadrao.Controls.Add(nomeLabel);
            this.tabPadrao.Controls.Add(this.nomeTextBox);
            this.tabPadrao.Controls.Add(uFLabel);
            this.tabPadrao.Controls.Add(this.uFTextBox);
            this.tabPadrao.Size = new System.Drawing.Size(628, 259);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Location = new System.Drawing.Point(0, 285);
            this.gbOpcoes.Size = new System.Drawing.Size(636, 68);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(551, 7);
            this.btnSair.TabIndex = 9;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(252, 7);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(328, 7);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(404, 7);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(477, 7);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Modelo.Clientes);
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(72, 91);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 2;
            bairroLabel.Text = "Bairro:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(75, 68);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 4;
            cEPLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(62, 159);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(64, 24);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 8;
            codigoLabel.Text = "Codigo:";
            // 
            // codigo_IBGELabel
            // 
            codigo_IBGELabel.AutoSize = true;
            codigo_IBGELabel.Location = new System.Drawing.Point(35, 204);
            codigo_IBGELabel.Name = "codigo_IBGELabel";
            codigo_IBGELabel.Size = new System.Drawing.Size(71, 13);
            codigo_IBGELabel.TabIndex = 10;
            codigo_IBGELabel.Text = "Codigo IBGE:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(35, 136);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(74, 13);
            complementoLabel.TabIndex = 12;
            complementoLabel.Text = "Complemento:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(45, 113);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(64, 13);
            logradouroLabel.TabIndex = 14;
            logradouroLabel.Text = "Logradouro:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(69, 46);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Nome:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(81, 179);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(24, 13);
            uFLabel.TabIndex = 18;
            uFLabel.Text = "UF:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(115, 88);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(218, 20);
            this.bairroTextBox.TabIndex = 3;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(115, 156);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.ReadOnly = true;
            this.cidadeTextBox.Size = new System.Drawing.Size(450, 20);
            this.cidadeTextBox.TabIndex = 6;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(115, 21);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // codigo_IBGETextBox
            // 
            this.codigo_IBGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Codigo_IBGE", true));
            this.codigo_IBGETextBox.Location = new System.Drawing.Point(115, 201);
            this.codigo_IBGETextBox.Name = "codigo_IBGETextBox";
            this.codigo_IBGETextBox.ReadOnly = true;
            this.codigo_IBGETextBox.Size = new System.Drawing.Size(100, 20);
            this.codigo_IBGETextBox.TabIndex = 8;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(115, 133);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(450, 20);
            this.complementoTextBox.TabIndex = 5;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(115, 110);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(450, 20);
            this.logradouroTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(115, 43);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(450, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(115, 178);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.ReadOnly = true;
            this.uFTextBox.Size = new System.Drawing.Size(42, 20);
            this.uFTextBox.TabIndex = 7;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cepMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CEP", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(115, 65);
            this.cepMaskedTextBox.Mask = "99999-999";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTextBox.TabIndex = 2;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cepMaskedTextBox.Validated += new System.EventHandler(this.cepMaskedTextBox_Validated);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 353);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes.";
            this.tabPadrao.ResumeLayout(false);
            this.tabPadrao.PerformLayout();
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox codigo_IBGETextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
    }
}