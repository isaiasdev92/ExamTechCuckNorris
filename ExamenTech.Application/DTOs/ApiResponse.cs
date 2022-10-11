using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTech.Application.DTOs
{
    public class ApiResponse<T> where T : class
    {

        public ApiResponse() { }

        public ApiResponse(T data)
        {
            Data = data;
        }

        [JsonProperty("status")]
        public string Status { get; set; }


        /// <summary>
        /// This object return: Success, NoData, Error
        /// </summary>
        /// <example>null</example>
        [JsonProperty("data")]
        public T? Data { get; set; }

    }
}
