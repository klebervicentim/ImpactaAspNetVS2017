//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loja.Repositorios.SqlServer.EFModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdutoImagem
    {
        public int Produto_Id { get; set; }
        public byte[] Property1 { get; set; }
    
        public virtual Produtos Produto { get; set; }
    }
}
