using System;
using System.Data.SqlClient;
using TrabalhoLP.Properties.Model;

namespace TrabalhoLP.Properties.DAO
{
    public class UsuarioDAO
    {
        private ConnectionSQL db = new ConnectionSQL();

        public void Inserir(Usuario usuario)
        {
            string sql = $"INSERT INTO Usuarios (Nome, CPF, Telefone, Email, Endereco) VALUES ('{usuario.Nome}', '{usuario.CPF}', '{usuario.Telefone}', '{usuario.Email}', '{usuario.Endereco}')";
            db.MountQuery(sql);
        }
    }
}