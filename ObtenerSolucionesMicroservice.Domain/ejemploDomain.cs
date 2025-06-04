using System.Transactions;
using ObtenerSolucionesMicroservice.Entities;
using ObtenerSolucionesMicroservice.Entities.Model;
using ObtenerSolucionesMicroservice.Entities.Filter;
using ObtenerSolucionesMicroservice.Exceptions;
using ObtenerSolucionesMicroservice.Repository;
namespace ObtenerSolucionesMicroservice.Domain
{
    public class ejemploDomain
    {
        #region Interfaces

        private IejemploRepository _ejemploRepository;
        #endregion

        #region Constructor 
        public ejemploDomain(IejemploRepository ejemplo)
        {
            _ejemploRepository = ejemplo ?? throw new ArgumentNullException(nameof(ejemplo));
        }
        #endregion
        #region Method Publics 
        public async Task<ItemResponseDT> Createejemplo(ejemploCreateDto ejemplo)
        {
            ItemResponseDT item = new ItemResponseDT() { Item = false };
            using var tx = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            long id = 0;//await _ejemploRepository.Insert(new ejemploEntity().ConvertToejemploCreate(ejemplo));
            if (id == 0)
            {
                throw new ejemploAddHeaderException();
            }
            item.Item = true;
            tx.Complete();
            return item;

        }
        public async Task<ItemResponseDT> Editejemplo(ejemploEntity ejemplo)
        {
            ItemResponseDT item = new ItemResponseDT() { Item = false };

            using var tx = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            if (!await _ejemploRepository.Update(ejemplo))
            {
                throw new ejemploEditHeaderException();
            }
            tx.Complete();
            item.Item = true;
            return item;

        }
        public async Task<ItemResponseDT> Deleteejemplo(ejemploEntity ejemplo)
        {
            ItemResponseDT item = new ItemResponseDT() { Item = false };
            item.Item = await _ejemploRepository.Delete(1);//ejemplo.ID);
            return item;
        }
        public async Task<ItemResponseDT> GetByItem(ejemploFilter filter, ejemploFilterItemType filterType)
        {
            ItemResponseDT ejemplo = new ItemResponseDT();
            ejemplo.Item = await _ejemploRepository.GetItem(filter, filterType);
            return ejemplo;
        }

        public async Task<ItemResponseDTLst> GetByList(ejemploFilter filter, ejemploFilterListType filterType, Pagination pagination)
        {
            ItemResponseDTLst lst = new ItemResponseDTLst();
            lst.LstItem = await _ejemploRepository.GetLstItem(filter, filterType, pagination);
            return lst;
        }
        #endregion
    }
}
