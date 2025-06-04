namespace ObtenerSolucionesMicroservice.Entities.Filter
{
    public enum ejemploFilterItemType : byte
    {
        Add,
        Edit,
        Update,
        Delete,
        Itemejemplo,
        ByItemxID,
        Undefined,
        BycPerCodigo
    }
    public enum ejemploFilterListType : byte
    {
        Undefined,
        ByList,
        ListItemejemplo,
        ByPagination,
        ByCabecera,
        ByDependencia
    }
}
