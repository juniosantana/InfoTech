using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = true;

            // O código abaixo deverá ser utilizado caso optem por usar banco de dados.
            //using (var conexao = new SqlConnection())
            //{
            //    conexao.ConnectionString = 
            //    conexao.Open();
            //    using (var command = new SqlCommand())
            //    {
            //        command.Connection = conexao;
            //        command.CommandText = string.Format("SELECT COUNT(*) FROM USUARIO WHERE login='{0}' AND senha='{1}'", login, senha);
            //        ret = ((int)command.ExecuteScalar() > 0);
            //    }
            //}
            return ret;
        }
    }
}