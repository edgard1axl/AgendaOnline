using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AgendaOnline.Application.Messages.Base
{
    public abstract class BaseResponse
    {
        public BaseResponse()
        {
            Messages = new List<Message>();
            Protocolo = Guid.NewGuid();
        }

        private bool? isValid;

        /// <summary>
        /// Retorna Verdadeiro se não houver nenhuma mensagem de erro
        /// </summary>
        [DataMember]
        public bool Valido
        {
            get
            {
                if (!isValid.HasValue)
                    return Messages.Count == 0;

                return isValid.Value;
            }
            set
            {
                isValid = value;
            }
        }

        [DataMember]
        public List<Message> Messages { get; set; }

        [DataMember]
        public Guid Protocolo { get; set; }

        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        public virtual void AddHeader(string key, string value)
        {
            if (!_headers.Contains(new KeyValuePair<string, string>(key, value)))
            {
                if (!_headers.ContainsKey(key))
                {
                    _headers.Add(key, value);
                }
                else
                {
                    _headers[key] = value;
                }
            }
        }
        public virtual string GetHeader(string key)
        {
            string outValue;

            if (_headers.TryGetValue(key, out outValue))
            {
                return outValue;
            }

            return string.Empty;
        }
        public virtual Dictionary<string, string> DefaultResponseHeaders
        {
            get
            {
                return _headers;
            }
        }

        /// <summary>
        /// Adiciona uma novas mensagems de erro.
        /// </summary>
        /// <param name="tipoMensagem">Tipo de Mensagem</param>
        /// <param name="conteudo">Conteudo</param>
        public void AdicionarMensagemErro(MessageType messageType, string content)
        {
            Messages.Add(new Message(content, messageType));
        }

        /// <summary>
        /// Adiciona uma novas mensagems de erro.
        /// </summary>
        /// <param name="tipoErro">Tipo de erro</param>
        /// <param name="mensagens">Resultado</param>
        public void AdicionarMensagemErro(List<Message> mensagens)
        {
            mensagens.ForEach(m => Messages.Add(m));
        }

        public void AdicionarMensagemErro(string codigo, string conteudo, MessageType tipoMensagem)
        {
            Messages.Add(new Message(codigo, conteudo, tipoMensagem));
        }

        public void AdicionarMensagemErro(Message message)
        {
            Messages.Add(message);
        }
    }
}
