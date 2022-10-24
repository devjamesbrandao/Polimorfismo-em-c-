namespace polimorfismo.Models
{
    public abstract class Veiculo
    {
        private string tipo;
        public string Tipo { get; set; }

        public Veiculo(string tipoVeiculo)
        {
            this.tipo = tipoVeiculo;
        }

        public abstract void Mover();

        public abstract void Parar();
    }
}
