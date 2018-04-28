using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Loja.Mvc.Validacoes;

namespace Loja.Mvc.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [IdadeMinima(18)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Remote("VerificarDisponibilidadedeEmail", "Clientes", HttpMethod = "POST", ErrorMessage = "E-mail já está sendo utilizado")]
        [RegularExpression(@"^[a-zA-Z0-9.-_]{1,50}@[\w]+(\.[a-Z]{2,3}){1,2}$", ErrorMessage = "Formato inválido de e-mail")]
        //[EmailAddress]
        public string Email { get; set; }

        /*
        EXPLICAÇÃO DO REGEX
        
        ^	    indica o começo da string/linha
        [ ]	    indica um intervalo de caracteres permitidos
        a-z	    indica que dentre os caracteres permitidos estão todos os caracteres de a a z minusculo
        A-Z	    indica que dentre os caracteres permitidos estão todos os caracteres de A a Z maiusculo
        0-9	    indica que dentre os caracteres permitidos estão todos os números de 0 a 9
        .-_	    indica que adicionalmente são permitidos caracteres ponto, hífen e underscore
        {1,50}	indica que o tamanho mínimo da cadeia de caracteres anterior pode ser min 1 max 50
        @	    indica que a expressão deve conter um arroba na posição indicada
        [\w]    indica que serão permitidos todos os caracteres com exceção dos alfa-numéricos
        +	    indica um acréscimo de regra na posição indicada
        \.[a-Z]	indica um trecho de string que deve começar com ponto, sendo de a a z
        {2,3}	indica que o trecho acima pode ter no minimo 2 caracteres e no máximo 3
        (){1,2}	indica que o bloco dentro dos parênteses pode repetir no mínimo 1 vez, no máx 2
        $	    indica o final da expressão regular
        */
    }
}