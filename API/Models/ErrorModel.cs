using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// / Modelo de erro.
    /// </summary>
    public class ErrorModel
    {
        /// <summary>
        /// Código do erro.
        /// </summary>
        [JsonProperty("codigo")]
        public int Code { get; set; }

        /// <summary>
        /// Descrição do erro.
        /// </summary>
        [JsonProperty("mensagem")]
        public string Description { get; set; }
    }
}
