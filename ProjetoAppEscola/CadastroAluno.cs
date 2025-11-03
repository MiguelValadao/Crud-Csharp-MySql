using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAppEscola
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            exibirDados();
        }

        // Variaveis globais
        const string table = "tblAlunos";
        ConexaoAluno db = new ConexaoAluno();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try { 
            string insert;
            string unidade = rdbBarroca.Checked ? "B" : "F";
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cmbTurma.Text;
            int idade;
            if (int.TryParse(txtIdade.Text, out idade) && !string.IsNullOrEmpty(txtNome.Text))
            {
                insert = string.Format($"INSERT INTO {table} VALUES (NULL, '{txtNome.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')");
                db.executarComandos(insert);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                exibirDados();
            } else
            {
                MessageBox.Show("Informação inválida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
             } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearText()
        {
            lblID.Text = "";
            txtNome.Clear();
            txtIdade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdbSerie1.Checked = false;
            rdbSerie2.Checked = false;
            rdbSerie3.Checked = false;
            cmbTurma.Text = "";
            rdbByID.Checked = false;
            rdbByName.Checked = false;
            txtNome.Focus();
        }

        private void exibirDados()
        {
            string dados;
            if (rdbByID.Checked == true)
            {
                dados = ($"SELECT * FROM {table} ORDER BY id");
            }
            else
            {
                dados = ($"SELECT * FROM {table} ORDER BY nome");
            }
            DataTable dt = db.ExecutarConsulta(dados);
            dtgAluno.DataSource = dt.AsDataView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            exibirDados();
            clearText();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string excluir;
                DialogResult result = MessageBox.Show("Deseja excluir os dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (!string.IsNullOrEmpty(lblID.Text))
                {
                    
                    if(result == DialogResult.Yes)
                    {
                        excluir = string.Format($"DELETE FROM {table} WHERE id = '{lblID.Text}'  ");
                        db.executarComandos(excluir);
                        exibirDados();
                        clearText();
                        MessageBox.Show("Dados excluidos com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Informação inválida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIdade.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
                string unidade = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
                string serie = dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbTurma.Text = dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
                rdbBarroca.Checked = unidade == "B" ? true : false;
                rdbFloresta.Checked = unidade == "F" ? true : false;
                rdbSerie1.Checked = serie == "1" ? true : false;
                rdbSerie2.Checked = serie == "2" ? true : false;
                rdbSerie3.Checked = serie == "3" ? true : false;
            }catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Clique em uma célula válida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try {
            string alterar;
            string unidade = rdbBarroca.Checked ? "B" : "F";
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cmbTurma.Text;
            int idade;
            if (int.TryParse(txtIdade.Text, out idade) && !string.IsNullOrEmpty(txtNome.Text))
            {
                alterar = string.Format($"UPDATE {table} SET nome = '{txtNome.Text}', idade = '{txtIdade.Text}', unidade = '{unidade}', serie = '{serie}', turma = '{turma}' WHERE id = '{lblID.Text}'  ");
                db.executarComandos(alterar);
                exibirDados();
                clearText();
                MessageBox.Show("Dados alterados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Informação inválida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você quer sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}