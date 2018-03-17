using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO - Abstração ou Classes
    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        //ToDo: OO - Encapsular com Get e Set
        private string _placa;
        public string Placa
        {
            get
            {
                return _placa.ToUpper();
            }
            set
            {
                _placa = value.ToUpper();
            }
        }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Cor Cor { get; set; }
        public Modelo Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        
        protected List<string> ValidaBase()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(Placa))
                erros.Add("A placa é obrigatória");
            return erros;
        }
        public abstract List<string> Validar();

        //ToDo: OO - Poliformismo por substituição (Override no filho, Virtual no pai)
        public override string ToString()
        {
            return $"Modelo: {Modelo.Nome}, Cor: {Cor.Nome}, Placa: {Placa}";
        }
    }
}
