using System.Data;
namespace ObtenerSolucionesMicroservice.Repository
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection(string connectionId = "Default");
    }
}

