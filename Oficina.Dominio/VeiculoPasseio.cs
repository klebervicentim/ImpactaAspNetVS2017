﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO - Herança
    public class VeiculoPasseio : Veiculo
    {
        public TipoCarroceria Carroceria { get; set; }
        public override List<string> Validar()
        {
            var erros = base.ValidaBase();
            if (!Enum.IsDefined(typeof(TipoCarroceria), Carroceria))
                erros.Add($"A Carroceria informada({Carroceria}) não é válida");
                
            return erros;
        }
    }
}
