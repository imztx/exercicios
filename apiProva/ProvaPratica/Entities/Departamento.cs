namespace ProvaPratica.Entities
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FuncionarioID { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
