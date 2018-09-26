using TopBeers.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;




namespace TopBeers.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        //public bool ValidarLogin()
        //{
        //    string sql = $"SELECT * FROM USUARIO WHERE EMAIL = '{Email}' AND SENHA = '{Senha}'";
        //    DAL objDAL = new DAL();
        //    DataTable dt = objDAL.RetDataTable(sql);

        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count == 1)
        //        {
        //            Id = int.Parse(dt.Rows[0]["ID"].ToString());
        //            Nome = dt.Rows[0]["NOME"].ToString();
        //            DataNascimento = DateTime.Parse(dt.Rows[0]["DATANASCIMENTO"].ToString());
        //            return true;
        //        }
        //    }
        //    return false;
        //}

    }

}
