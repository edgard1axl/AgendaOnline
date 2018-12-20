using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AgendaOnline.Application.Messages.Base
{
    [Serializable]
    public class Message
    {
        public Message()
        {

        }
        public Message(string content, MessageType typeMessage)
            : this("", content, typeMessage)
        {
        }

        public Message(string code, string content, MessageType typeMessage)
        {
            Content = content;
            TypeMessage = typeMessage;
            Code = code;
        }

        [DataMember(Name = "Codigo")]
        public string Code { get; set; }
        [DataMember(Name = "Conteudo")]
        public string Content { get; set; }
        [DataMember(Name = "Tipo")]
        public MessageType TypeMessage { get; set; }
    }
}
