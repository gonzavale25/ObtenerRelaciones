using Dapper;
using ObtenerSolucionesMicroservice.Entities;
using ObtenerSolucionesMicroservice.Entities.Filter;
using ObtenerSolucionesMicroservice.Entities.Model;
using ObtenerSolucionesMicroservice.Repository;
using ObtenerSolucionesMicroservice.Infraestructure;
using ObtenerSolucionesMicroservice.Repository;

namespace ObtenerSolucionesMicroservice.Infraestructure
{
    public class ejemploRepository : BaseRepository, IejemploRepository
    {
        #region Constructor 
        public ejemploRepository(IConnectionFactory cn) : base(cn)
        {
        }
        #endregion
        #region Public Methods
        public async Task<long> Insert(ejemploEntity item)
         => await this.Create("", new DynamicParameters(new Dictionary<string, object>
         {
             //{ "@Nombre", item.Nombre},
             //{ "@Edad", item.Edad},
             //{ "@Email", item.Email},
         }));
        public async Task<bool> Update(ejemploEntity item) =>
            await this.UpdateOrDelete("", new DynamicParameters(new Dictionary<string, object>
            {
                //{"@ID", item.ID },
                //{"@Nombre",item.Nombre},
                //{"@Edad",item.Edad },
                //{"@Email",item.Email}
            }));
        public async Task<bool> Delete(long id) =>
            await this.UpdateOrDelete("", new DynamicParameters(new Dictionary<string, object>
            {
                //{ "@ID",id }
            }));

        public async Task<ejemploEntity> GetItem(ejemploFilter filter, ejemploFilterItemType filterType)
        {
            ejemploEntity itemfound = null;
            switch (filterType)
            {
                case ejemploFilterItemType.ByItemxID:
                    itemfound = await this.obtenerejemploxID(filter);
                    break;
            }
            return itemfound;
        }
        public async Task<IEnumerable<ejemploEntity>> GetLstItem(ejemploFilter filter, ejemploFilterListType filterType, Pagination pagination)
        {
            IEnumerable<ejemploEntity> lstItemFound = new List<ejemploEntity>();
            switch (filterType)
            {
                case ejemploFilterListType.ListItemejemplo:
                    lstItemFound = await this.getByList();
                    break;
                default:
                    break;
            }
            return lstItemFound;
        }
        #endregion
        #region Private Methods
        private async Task<ejemploEntity?> obtenerejemploxID(ejemploFilter filter)
        //{
        //    string query = "ObtenerRegistroPorID";
        //    var param = new DynamicParameters();
        //    param.Add("@ID", filter.ID);
        //    return (await this.LoadData<ejemploEntity>(query, param)).FirstOrDefault();
        //}
        => (await this.LoadData<ejemploEntity>("", new DynamicParameters(new Dictionary<string, object>
        {
            //{ "@ID", filter.ID}
        }))).FirstOrDefault() ?? null;

        private async Task<IEnumerable<ejemploEntity>> getByList() =>
            await this.LoadData<ejemploEntity>("", new DynamicParameters());

        #endregion
    }
}
