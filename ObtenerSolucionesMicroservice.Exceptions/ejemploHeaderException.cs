using ObtenerSolucionesMicroservice.Entities;
using ObtenerSolucionesMicroservice.Exceptions;

namespace ObtenerSolucionesMicroservice.Exceptions
{
    public class ejemploAddHeaderException : CustomException
    {
        public override EResponse EResponse => new EResponse() { cDescripcion = "Error al insertar la entidad ejemplo" };
    }
    public class ejemploEditHeaderException : CustomException
    {
        public override EResponse EResponse => new EResponse() { cDescripcion = "Error al actualizar la entidad ejemplo" };
    }
}
