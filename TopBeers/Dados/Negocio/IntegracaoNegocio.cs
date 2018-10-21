using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Negocio
{
    public class IntegracaoNegocio
    {
        private CervejariaNegocio _cervejariaNegocio;
        private CervejaNegocio _cervejaNegocio;
        private TipoCervejaNegocio _tipoCervejaNegocio;


        public CervejariaNegocio CervejariaNegocio
        {
            get
            {
                if (_cervejariaNegocio == null)
                {
                    _cervejariaNegocio =new CervejariaNegocio();
                }

                return _cervejariaNegocio;
            }
        }

        public CervejaNegocio CervejaNegocio
        {
            get
            {
                if (_cervejaNegocio == null)
                {
                    _cervejaNegocio = new CervejaNegocio();
                }

                return _cervejaNegocio;
            }
        }
        public TipoCervejaNegocio TipoCervejaNegocio
        {
            get
            {
                if (_tipoCervejaNegocio == null)
                {
                    _tipoCervejaNegocio = new TipoCervejaNegocio();
                }

                return _tipoCervejaNegocio;
            }
        }
    }
}
