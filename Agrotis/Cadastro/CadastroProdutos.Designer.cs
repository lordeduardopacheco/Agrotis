
namespace Agrotis.Cadastro
{
    partial class CadastroProdutos
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label peso_liquidoLabel;
            System.Windows.Forms.Label preco_unitarioLabel;
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.peso_liquidoTextBox = new System.Windows.Forms.TextBox();
            this.preco_unitarioTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            peso_liquidoLabel = new System.Windows.Forms.Label();
            preco_unitarioLabel = new System.Windows.Forms.Label();
            this.tabPadrao.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPadrao
            // 
            this.tabPadrao.Controls.Add(codigoLabel);
            this.tabPadrao.Controls.Add(this.codigoTextBox);
            this.tabPadrao.Controls.Add(descricaoLabel);
            this.tabPadrao.Controls.Add(this.descricaoTextBox);
            this.tabPadrao.Controls.Add(peso_liquidoLabel);
            this.tabPadrao.Controls.Add(this.peso_liquidoTextBox);
            this.tabPadrao.Controls.Add(preco_unitarioLabel);
            this.tabPadrao.Controls.Add(this.preco_unitarioTextBox);
            this.tabPadrao.Size = new System.Drawing.Size(755, 247);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Location = new System.Drawing.Point(0, 273);
            this.gbOpcoes.Size = new System.Drawing.Size(763, 70);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(674, 3);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(375, 3);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(451, 3);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(527, 3);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(600, 3);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Modelo.Produtos);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(26, 20);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(26, 46);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao:";
            // 
            // peso_liquidoLabel
            // 
            peso_liquidoLabel.AutoSize = true;
            peso_liquidoLabel.Location = new System.Drawing.Point(26, 72);
            peso_liquidoLabel.Name = "peso_liquidoLabel";
            peso_liquidoLabel.Size = new System.Drawing.Size(67, 13);
            peso_liquidoLabel.TabIndex = 4;
            peso_liquidoLabel.Text = "Peso liquido:";
            // 
            // preco_unitarioLabel
            // 
            preco_unitarioLabel.AutoSize = true;
            preco_unitarioLabel.Location = new System.Drawing.Point(26, 98);
            preco_unitarioLabel.Name = "preco_unitarioLabel";
            preco_unitarioLabel.Size = new System.Drawing.Size(75, 13);
            preco_unitarioLabel.TabIndex = 6;
            preco_unitarioLabel.Text = "Preco unitario:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(107, 17);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(107, 43);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(642, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // peso_liquidoTextBox
            // 
            this.peso_liquidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Peso_liquido", true));
            this.peso_liquidoTextBox.Location = new System.Drawing.Point(107, 69);
            this.peso_liquidoTextBox.Name = "peso_liquidoTextBox";
            this.peso_liquidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.peso_liquidoTextBox.TabIndex = 5;
            // 
            // preco_unitarioTextBox
            // 
            this.preco_unitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Preco_unitario", true));
            this.preco_unitarioTextBox.Location = new System.Drawing.Point(107, 95);
            this.preco_unitarioTextBox.Name = "preco_unitarioTextBox";
            this.preco_unitarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.preco_unitarioTextBox.TabIndex = 7;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 343);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produtos.";
            this.tabPadrao.ResumeLayout(false);
            this.tabPadrao.PerformLayout();
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox peso_liquidoTextBox;
        private System.Windows.Forms.TextBox preco_unitarioTextBox;
    }
}