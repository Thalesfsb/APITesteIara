﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTesteIara.Models
{
    public class CotacaoModel
    {
        [Required]
        public string CNPJComprador { get; set; }
        [Required]
        public string CNPJFornecedor { get; set; }
        [Required]
        public int NumeroCotacao { get; set; }
        [Required]
        public DateTime DataCotacao { get; set; }
        [Required]
        public DateTime DataEntregaCotacao { get; set; }
        [Required]
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Observacao { get; set; }
        public ICollection<CotacaoItemModel> CotacaoItems { get; set; }
    }
}
