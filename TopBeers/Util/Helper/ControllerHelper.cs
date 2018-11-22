using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopBeers.Dados.Negocio;

namespace TopBeers.Util.Helper
{
    public class ControllerHelper
    {
        public static string ObterCervejariaPorId(int? idCervejaria)
        {
            var negocio = new CervejariaNegocio();
            var cervejarias = negocio.GetById(idCervejaria);
            if (cervejarias != null)
            {
                return cervejarias.Nome;
            }

            return string.Empty;
        }
    }
}
