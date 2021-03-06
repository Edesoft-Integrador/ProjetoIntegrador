﻿using seq.Domain.Interface.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace seq.Domain.Entities
{
    [Table("tb_Integrado_Processo")]
    public class ProcessoModel : IBaseMovimentoDb
    {
        [Key]
        public long? ProcessoId { get; set;}
        public long TipoId { get; set;}
        
        public long Id { get; set;}
        public long LayoutId { get; set;}
        public long ClienteId { get; set;}
        public long ProdutoId { get; set;}
        public string Descricao { get; set;}
        public bool Coleta { get; set;}
        public string Host { get; set;}
        public string Usuario { get; set;}
        public string Senha { get; set;}
        public string HostDestino { get; set;}
        public string UsuarioDestino { get; set;}
        public string SenhaDestino { get; set;}
        public string PastaEntrada { get; set;}
        public string PastaLido { get; set;}
        public string PastaLidoParcial { get; set;}
        public string PastaErro { get; set;}
        public string MetedoGet { get; set;}
        public string MetedoPost { get; set;}
        public bool Exclusao { get; set;}
        public bool Ativo { get; set;}
        public DateTime? DataAlteracao { get; set;}
        public string UsuarioIdAlteracao { get; set;}
        public DateTime DataInclusao { get; set;}
        public string UsuarioIdInclusao { get; set;}
    }
}
