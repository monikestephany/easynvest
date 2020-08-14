using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// Modelo de erro.
    /// </summary>
    public class ErrorsModel
    {
        /// <summary>
        /// Lista de erros.
        /// </summary>
        [JsonProperty("erros")]
        public IEnumerable<ErrorModel> Errors { get; set; }
    }
}
