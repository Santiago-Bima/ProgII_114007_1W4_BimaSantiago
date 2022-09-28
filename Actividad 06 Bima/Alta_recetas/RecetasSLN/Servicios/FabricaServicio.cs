using RecetasSLN.Servicios.Interfaes;

namespace RecetasSLN.Servicios
{
    abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
