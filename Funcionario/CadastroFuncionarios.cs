using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        //Método para cadastrar funcionário no banco de dados.
        public bool cadastrarFuncionarios()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open();

                string insert = $" insert into funcionarios (nome,email,cpf,endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //Mensagem de erro do banco de dados quando não for possivel cadastrar usuários ou funcionários no banco 
                //erro ligado ao banco de dados

                MessageBox.Show("Erro de conexão com o Banco de Dados - Método cadastrarFuncionario : " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open();

                //Select é a função utilizada para localizar os dados do banco de dados
                string select = $"select id, nome, email, cpf, endereco from funcionarios where cpf = '{cpf}';";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados - Método localizarFuncionario : " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
