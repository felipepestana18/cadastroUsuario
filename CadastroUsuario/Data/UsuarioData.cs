using CadastroUsuario.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Data
{
    public class UsuarioData : Data
    {
        public void Create(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"cadPessoa @nome, @sobrenome, @cpf, @salario, @cep, @bairro, @logradouro";
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", usuario.SobreNome);
            cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
            cmd.Parameters.AddWithValue("@salario", usuario.Salario);
            cmd.Parameters.AddWithValue("@cep", usuario.Cep);
            cmd.Parameters.AddWithValue("@bairro", usuario.Bairro);
            cmd.Parameters.AddWithValue("@logradouro", usuario.Logradouro);
            cmd.ExecuteNonQuery();
        }

        public List<Usuario> Read()
        {
            List<Usuario> lista = new List<Usuario>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = "SELECT * FROM v_pessoa";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = (int)reader["id"];
                usuario.Nome = (string)reader["nome"];
                usuario.SobreNome = (string)reader["sobrenome"];
                usuario.Salario = (decimal)reader["salario"];
                usuario.Cpf = (string)reader["cpf"];
                usuario.Cep = (string)reader["cep"];
                usuario.Bairro = (string)reader["bairro"];
                usuario.Logradouro = (string)reader["logradouro"];
     
                lista.Add(usuario);
            }
            return lista;
        }
    }
}
