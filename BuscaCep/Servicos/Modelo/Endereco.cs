﻿using System;
namespace BuscaCep
{
    public class Endereco
    {
        public Endereco()
        {
        }
    
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String complemento { get; set; }
        public String bairro { get; set; }
        public String localidade { get; set; }
        public String uf { get; set; }
        public String ibge { get; set; }      
        public String gia { get; set; }
        public String ddd { get; set; }
        public String siafi { get; set; }
    }
}
