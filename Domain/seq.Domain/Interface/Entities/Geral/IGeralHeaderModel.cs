using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Geral
{
    public interface IGeralHeaderModel
    {
        long? HearderId { get; set; }
        long? HeaderIdPai { get; set; }
        string Arquivo { get; set; }
        int? Linha { get; set; }
        DateTime Processado { get; set; }
        string Descricao { get; set; }
        string Campo001 { get; set; }
        string Campo002 { get; set; }
        string Campo003 { get; set; }
        string Campo004 { get; set; }
        string Campo005 { get; set; }
        string Campo006 { get; set; }
        string Campo007 { get; set; }
        string Campo008 { get; set; }
        string Campo009 { get; set; }
        string Campo010 { get; set; }
        string Campo011 { get; set; }
        string Campo012 { get; set; }
        string Campo013 { get; set; }
        string Campo014 { get; set; }
        string Campo015 { get; set; }
        string Campo016 { get; set; }
        string Campo017 { get; set; }
        string Campo018 { get; set; }
        string Campo019 { get; set; }
        string Campo020 { get; set; }
        string Campo021 { get; set; }
        string Campo022 { get; set; }
        string Campo023 { get; set; }
        string Campo024 { get; set; }
        string Campo025 { get; set; }
        string Campo026 { get; set; }
        string Campo027 { get; set; }
    }
}
