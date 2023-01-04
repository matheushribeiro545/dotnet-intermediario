using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dotnet_intermediario.Models
{
    public class Venda
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // Quando o Json possui item com nome diferente
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}