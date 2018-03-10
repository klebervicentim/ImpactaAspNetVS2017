namespace Oficina.Dominio
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Marca Marca { get; set; }

        public class SelecionarPorMarca
        {
            private int v;

            public SelecionarPorMarca(int v)
            {
                this.v = v;
            }
        }
    }
}