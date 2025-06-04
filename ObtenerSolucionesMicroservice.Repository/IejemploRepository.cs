using ObtenerSolucionesMicroservice.Entities;
using ObtenerSolucionesMicroservice.Entities.Filter;
using ObtenerSolucionesMicroservice.Entities.Model;
using ObtenerSolucionesMicroservice.Repository;

namespace ObtenerSolucionesMicroservice.Repository
{
    public interface IejemploRepository : IDeleteLongRepository, IInsertRepository<ejemploEntity>, IUpdateRepository<ejemploEntity>
    {
        Task<ejemploEntity> GetItem(ejemploFilter filter, ejemploFilterItemType filterType);
        Task<IEnumerable<ejemploEntity>> GetLstItem(ejemploFilter filter, ejemploFilterListType filterType, Pagination pagination);
    }
}
