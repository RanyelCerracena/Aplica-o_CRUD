using MySql.Data.MySqlClient;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0 || txtEmail.Text.Length == 0 || txtCpf.Text.Length == 0 || txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Existe um ou mais campos vazios! Preencha-os por favor", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Digite o seu CPF completo!", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCpf.Text.Replace(".", "").Replace("-", "");
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastrado com sucesso!", "Cadastro Conluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar funcionário", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadasrar funcionário : " + ex.Message, "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.MaxLength = 14;
            var d = e.KeyChar.ToString();
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u0001')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar != '\b')
            {
                switch (txtBox.Text.Length)
                {
                    case 3:
                        txtBox.Text += ".";
                        txtBox.Select(txtBox.Text.Length, 0);
                        break;
                    case 7:
                        txtBox.Text += ".";
                        txtBox.Select(txtBox.Text.Length, 0);
                        break;
                    case 11:
                        txtBox.Text += "-";
                        txtBox.Select(txtBox.Text.Length, 0);
                        break;
                    case 13:
                        if (e.KeyChar != '\u0001')
                        {
                            txtEndereco.Focus();
                        }
                        break;
                }
            }

        }

        private void txtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.A)
            {
                return;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCpf.Text.Replace(".", "").Replace("-", "");

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["Id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado"); txtNome.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtCpf.Clear();
                            txtCpf.Focus();
                            lblId.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor preencha o campo CPF para realizar a pesquisa! ", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCpf.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";

                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar Funcionário : " + ex.Message, "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCpf.Clear();
            txtCpf.Focus();
            lblId.Text = "";
        }
    }
}
