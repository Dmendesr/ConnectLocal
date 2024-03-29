﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectLocal.Models
{
    [Table("Prestadores")]

    public class Prestador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomePrestador { get; set; }
        [Required]
        public TipoServico Tipo { get; set; }
        [Required]
        public string InfoServico { get; set; }
        [Required]
        public string EnderecoServico { get; set; }
        [Required]
        public string ContatoServico { get; set; }
        [Required]
        public string EmailServico { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public int ContratanteId { get; set; }

        public Contratante Contratante { get; set; }

    }

       public enum TipoServico
       {  
        Borracheiro,
        Eletricista,
        Encanador,
        Pintor,
       }
}