﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopBeers.Dados.Entities
{
    public class TipoCerveja
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Tipo { get; set; }
        [MaxLength(255)]
        public string DescricaoTipo { get; set; }

        public ICollection<Cerveja> Cervejas { get; set; }
    }
}
