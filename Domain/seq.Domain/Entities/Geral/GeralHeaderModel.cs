﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace seq.Domain.Entities
{
    [Table("tb_Integrado_Header")]
    public class GeralHeaderModel
    {
        public GeralHeaderModel()
        {
           // Detalhes = new HashSet<GeralDetalheModel>();
        }

        [Key]
        public long HeaderId { get; set; }       
        public long RefHeader { get; set; }  
        public string Arquivo { get; set; }
        public int Linha { get; set; }
        public DateTime? Processado { get; set; }
        public string Descricao { get; set; }

        #region Campos
        public string Campo001 { get; set; }
        public string Campo002 { get; set; }
        public string Campo003 { get; set; }
        public string Campo004 { get; set; }
        public string Campo005 { get; set; }
        public string Campo006 { get; set; }
        public string Campo007 { get; set; }
        public string Campo008 { get; set; }
        public string Campo009 { get; set; }
        public string Campo010 { get; set; }
        public string Campo011 { get; set; }
        public string Campo012 { get; set; }
        public string Campo013 { get; set; }
        public string Campo014 { get; set; }
        public string Campo015 { get; set; }
        public string Campo016 { get; set; }
        public string Campo017 { get; set; }
        public string Campo018 { get; set; }
        public string Campo019 { get; set; }
        public string Campo020 { get; set; }
        public string Campo021 { get; set; }
        public string Campo022 { get; set; }
        public string Campo023 { get; set; }
        public string Campo024 { get; set; }
        public string Campo025 { get; set; }
        public string Campo026 { get; set; }
        public string Campo027 { get; set; }
        #endregion
    }
}
