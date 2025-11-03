namespace ProjetoAppEscola
{
    partial class CadastroAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSerie3 = new System.Windows.Forms.RadioButton();
            this.rdbSerie1 = new System.Windows.Forms.RadioButton();
            this.rdbSerie2 = new System.Windows.Forms.RadioButton();
            this.dtgAluno = new System.Windows.Forms.DataGridView();
            this.rdbByID = new System.Windows.Forms.RadioButton();
            this.rdbByName = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Série:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turma:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(122, 360);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(228, 360);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(342, 360);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(456, 360);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(579, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(129, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(514, 111);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(159, 20);
            this.txtIdade.TabIndex = 13;
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbTurma.Location = new System.Drawing.Point(518, 173);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(155, 21);
            this.cmbTurma.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFloresta);
            this.panel1.Controls.Add(this.rdbBarroca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(103, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 48);
            this.panel1.TabIndex = 15;
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(103, 23);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rdbFloresta.TabIndex = 4;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(12, 23);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rdbBarroca.TabIndex = 3;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSerie3);
            this.panel2.Controls.Add(this.rdbSerie1);
            this.panel2.Controls.Add(this.rdbSerie2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(324, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 48);
            this.panel2.TabIndex = 16;
            // 
            // rdbSerie3
            // 
            this.rdbSerie3.AutoSize = true;
            this.rdbSerie3.Location = new System.Drawing.Point(118, 25);
            this.rdbSerie3.Name = "rdbSerie3";
            this.rdbSerie3.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie3.TabIndex = 6;
            this.rdbSerie3.TabStop = true;
            this.rdbSerie3.Text = "3ª";
            this.rdbSerie3.UseVisualStyleBackColor = true;
            // 
            // rdbSerie1
            // 
            this.rdbSerie1.AutoSize = true;
            this.rdbSerie1.Location = new System.Drawing.Point(9, 24);
            this.rdbSerie1.Name = "rdbSerie1";
            this.rdbSerie1.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie1.TabIndex = 4;
            this.rdbSerie1.TabStop = true;
            this.rdbSerie1.Text = "1ª";
            this.rdbSerie1.UseVisualStyleBackColor = true;
            // 
            // rdbSerie2
            // 
            this.rdbSerie2.AutoSize = true;
            this.rdbSerie2.Location = new System.Drawing.Point(67, 25);
            this.rdbSerie2.Name = "rdbSerie2";
            this.rdbSerie2.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie2.TabIndex = 5;
            this.rdbSerie2.TabStop = true;
            this.rdbSerie2.Text = "2ª";
            this.rdbSerie2.UseVisualStyleBackColor = true;
            // 
            // dtgAluno
            // 
            this.dtgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluno.Location = new System.Drawing.Point(103, 219);
            this.dtgAluno.Name = "dtgAluno";
            this.dtgAluno.Size = new System.Drawing.Size(570, 124);
            this.dtgAluno.TabIndex = 17;
            this.dtgAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAluno_CellContentClick);
            // 
            // rdbByID
            // 
            this.rdbByID.AutoSize = true;
            this.rdbByID.Location = new System.Drawing.Point(3, 4);
            this.rdbByID.Name = "rdbByID";
            this.rdbByID.Size = new System.Drawing.Size(95, 17);
            this.rdbByID.TabIndex = 18;
            this.rdbByID.TabStop = true;
            this.rdbByID.Text = "Ordenar por ID";
            this.rdbByID.UseVisualStyleBackColor = true;
            // 
            // rdbByName
            // 
            this.rdbByName.AutoSize = true;
            this.rdbByName.Location = new System.Drawing.Point(3, 25);
            this.rdbByName.Name = "rdbByName";
            this.rdbByName.Size = new System.Drawing.Size(113, 17);
            this.rdbByName.TabIndex = 19;
            this.rdbByName.TabStop = true;
            this.rdbByName.Text = "Ordenar por nome ";
            this.rdbByName.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbByName);
            this.panel3.Controls.Add(this.rdbByID);
            this.panel3.Location = new System.Drawing.Point(435, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 46);
            this.panel3.TabIndex = 16;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgAluno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.RadioButton rdbSerie1;
        private System.Windows.Forms.RadioButton rdbSerie2;
        private System.Windows.Forms.DataGridView dtgAluno;
        private System.Windows.Forms.RadioButton rdbSerie3;
        private System.Windows.Forms.RadioButton rdbByID;
        private System.Windows.Forms.RadioButton rdbByName;
        private System.Windows.Forms.Panel panel3;
    }
}

