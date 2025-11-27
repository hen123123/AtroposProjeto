using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoEstudio
{
    /// <summary>
    /// Interação lógica para Cadastropage.xam
    /// </summary>
    public partial class Cadastropage : Page
    {
        public Cadastropage()
        {
            InitializeComponent();


            //string sql = $"select * from perguntas where PerguntasID = {idx}";
            //MySqlCommand cmd = new MySqlCommand(sql, ConexaoDB.Conexao);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    if (perguntasUsadas.Contains(reader["PerguntasID"].ToString()))
            //    {
            //        reader.Close();
            //        update_pergunta();  // Chama recursivamente para obter uma nova pergunta
            //    }
            //    else
            //    {
            //        lab_per1.Content = $" Pergunta {_perguntaNum++}";
            //        perguntasUsadas.Add(reader["PerguntasID"].ToString());
            //    }

            //    respostaCorreta = reader["respostaCorreta"].ToString().Replace(" ", "");
            //    txt_pergunta.Text = reader["Pergunta"].ToString();
            //    alternativa_A.Text = reader["opA"].ToString();
            //    alternativa_B.Text = reader["opB"].ToString();
            //    alternativa_C.Text = reader["opC"].ToString();
            //    alternativa_D.Text = reader["opD"].ToString();
            //}
            //reader.Close();
        }
        private void InserirDados(string usuario, string telefone, string senha, DateTime agenda)
        {
            try
            {
                string sql = "INSERT INTO cadastro (usuario, telefone, senha, agenda) VALUES (@usuario, @telefone, @senha, @agenda)";
                using (var cmdados = new MySqlCommand(sql, ConexaoBanco.Conexao))
                {
                    cmdados.Parameters.AddWithValue("@usuario", usuario);
                    cmdados.Parameters.AddWithValue("@telefone", telefone);
                    cmdados.Parameters.AddWithValue("@senha", senha);
                    cmdados.Parameters.AddWithValue("@agenda", agenda);
                    cmdados.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
            }
        }
        private void BtnVoltar_Click(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new Home());
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            InserirDados(Txtusuario.Text, TxtTelefone.Text, txt_senha.Password,DateTime.Now);
            MessageBox.Show("Cadastro realizado com sucesso!");

            Txtusuario.Clear();
            TxtTelefone.Clear();
            txt_senha.Clear();
            PwdConfirmPassword.Clear();
        }
    }
}
