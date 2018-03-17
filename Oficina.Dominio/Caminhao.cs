using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    class Caminhao : Veiculo
    {
        public QuantidadeEixos QuantidadeEixos { get; set; }

        public override List<string> Validar()
        {
            var erros = base.ValidaBase();
            if (!Enum.IsDefined(typeof(QuantidadeEixos), QuantidadeEixos))
                erros.Add($"O valor de eixos ({QuantidadeEixos}) não é válido");
            return erros;
        }
    }
}
