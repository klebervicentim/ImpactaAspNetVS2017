﻿namespace Loja.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public virtual Categoria Categoria { get; set; }
        public bool Descontinuado { get; set; }
    }
}
