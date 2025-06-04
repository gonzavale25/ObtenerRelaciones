namespace ObtenerSolucionesMicroservice.Entities.Filter
{
    public record class ejemploFilter(int ID);
    public record class ejemploCreateDto
    {
        public string Nombre { get; init; }
        public int Edad { get; init; }
        public string Email { get; init; }
    };
    public record class ejemploUpdateDto
    {
        public string Nombre { get; init; }
        public int Edad { get; init; }
        public string Email { get; init; }
    }



}
