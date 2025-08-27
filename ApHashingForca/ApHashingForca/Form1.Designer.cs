namespace ApHashingForca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTecnicas = new System.Windows.Forms.Label();
            this.btnBucketHash = new System.Windows.Forms.RadioButton();
            this.btnSgmLinear = new System.Windows.Forms.RadioButton();
            this.btnSdmQuadratica = new System.Windows.Forms.RadioButton();
            this.btnDuploHash = new System.Windows.Forms.RadioButton();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.gbTecnicas = new System.Windows.Forms.GroupBox();
            this.lsbListagem = new System.Windows.Forms.ListBox();
            this.gbTecnicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTecnicas
            // 
            this.lblTecnicas.AutoSize = true;
            this.lblTecnicas.Location = new System.Drawing.Point(39, 30);
            this.lblTecnicas.Name = "lblTecnicas";
            this.lblTecnicas.Size = new System.Drawing.Size(0, 13);
            this.lblTecnicas.TabIndex = 0;
            // 
            // btnBucketHash
            // 
            this.btnBucketHash.AutoSize = true;
            this.btnBucketHash.Location = new System.Drawing.Point(11, 20);
            this.btnBucketHash.Name = "btnBucketHash";
            this.btnBucketHash.Size = new System.Drawing.Size(87, 17);
            this.btnBucketHash.TabIndex = 1;
            this.btnBucketHash.TabStop = true;
            this.btnBucketHash.Text = "Bucket Hash";
            this.btnBucketHash.UseVisualStyleBackColor = true;
            // 
            // btnSgmLinear
            // 
            this.btnSgmLinear.AutoSize = true;
            this.btnSgmLinear.Location = new System.Drawing.Point(11, 40);
            this.btnSgmLinear.Name = "btnSgmLinear";
            this.btnSgmLinear.Size = new System.Drawing.Size(104, 17);
            this.btnSgmLinear.TabIndex = 2;
            this.btnSgmLinear.TabStop = true;
            this.btnSgmLinear.Text = "Sondagem linear";
            this.btnSgmLinear.UseVisualStyleBackColor = true;
            // 
            // btnSdmQuadratica
            // 
            this.btnSdmQuadratica.AutoSize = true;
            this.btnSdmQuadratica.Location = new System.Drawing.Point(11, 60);
            this.btnSdmQuadratica.Name = "btnSdmQuadratica";
            this.btnSdmQuadratica.Size = new System.Drawing.Size(129, 17);
            this.btnSdmQuadratica.TabIndex = 3;
            this.btnSdmQuadratica.TabStop = true;
            this.btnSdmQuadratica.Text = "Sondagem quadrática";
            this.btnSdmQuadratica.UseVisualStyleBackColor = true;
            // 
            // btnDuploHash
            // 
            this.btnDuploHash.AutoSize = true;
            this.btnDuploHash.Location = new System.Drawing.Point(11, 80);
            this.btnDuploHash.Name = "btnDuploHash";
            this.btnDuploHash.Size = new System.Drawing.Size(81, 17);
            this.btnDuploHash.TabIndex = 4;
            this.btnDuploHash.TabStop = true;
            this.btnDuploHash.Text = "Duplo Hash";
            this.btnDuploHash.UseVisualStyleBackColor = true;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(245, 49);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(46, 13);
            this.lblPalavra.TabIndex = 5;
            this.lblPalavra.Text = "Palavra:";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Location = new System.Drawing.Point(245, 80);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(32, 13);
            this.lblDica.TabIndex = 6;
            this.lblDica.Text = "Dica:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(245, 118);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(355, 118);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(465, 118);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(575, 118);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(42, 155);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(79, 13);
            this.lblLista.TabIndex = 13;
            this.lblLista.Text = "Lista de dados:";
            // 
            // gbTecnicas
            // 
            this.gbTecnicas.Controls.Add(this.btnDuploHash);
            this.gbTecnicas.Controls.Add(this.btnSdmQuadratica);
            this.gbTecnicas.Controls.Add(this.btnSgmLinear);
            this.gbTecnicas.Controls.Add(this.btnBucketHash);
            this.gbTecnicas.Location = new System.Drawing.Point(24, 41);
            this.gbTecnicas.Name = "gbTecnicas";
            this.gbTecnicas.Size = new System.Drawing.Size(200, 109);
            this.gbTecnicas.TabIndex = 14;
            this.gbTecnicas.TabStop = false;
            this.gbTecnicas.Text = "Técnicas de Hashing";
            this.gbTecnicas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lsbListagem
            // 
            this.lsbListagem.FormattingEnabled = true;
            this.lsbListagem.Location = new System.Drawing.Point(24, 175);
            this.lsbListagem.Name = "lsbListagem";
            this.lsbListagem.Size = new System.Drawing.Size(748, 264);
            this.lsbListagem.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbListagem);
            this.Controls.Add(this.gbTecnicas);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.lblTecnicas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTecnicas.ResumeLayout(false);
            this.gbTecnicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecnicas;
        private System.Windows.Forms.RadioButton btnBucketHash;
        private System.Windows.Forms.RadioButton btnSgmLinear;
        private System.Windows.Forms.RadioButton btnSdmQuadratica;
        private System.Windows.Forms.RadioButton btnDuploHash;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.GroupBox gbTecnicas;
        private System.Windows.Forms.ListBox lsbListagem;
    }
}

