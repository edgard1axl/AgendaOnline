using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AgendaOnline.Application.Messages.Base
{
    public enum MessageType
    {
        [EnumMember(Value = "Nenhum Erro")]
        NenhumErro,
        [EnumMember(Value = "Erro de Aplicação")]
        ErroAplicacao,
        [EnumMember(Value = "Erro de Negócio")]
        ErroNegocio,
        [EnumMember(Value = "Erro de Validação")]
        ErroValidacao,
        [EnumMember(Value = "Aplicação")]
        Aplicacao,
        [EnumMember(Value = "Negócio")]
        Negocio,
        [EnumMember(Value = "Validação")]
        Validacao
    }
}
