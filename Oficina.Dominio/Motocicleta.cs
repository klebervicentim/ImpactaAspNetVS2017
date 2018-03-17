using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    class Motocicleta : Veiculo
    {
        public TipoChassi TipoChassi { get; set; }

        public override List<string> Validar()
        {
            var erros = base.ValidaBase();
            if (!Enum.IsDefined(typeof(TipoChassi), TipoChassi))
                erros.Add($"O tipo de chassi informado ({TipoChassi}) não é válido");
            return erros;
        }
    }
}
