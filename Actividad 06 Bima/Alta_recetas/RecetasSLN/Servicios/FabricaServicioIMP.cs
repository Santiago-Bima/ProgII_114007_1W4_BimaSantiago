using RecetasSLN.Servicios.Implementaciones;
using RecetasSLN.Servicios.Interfaes;

namespace RecetasSLN.Servicios
{
    class FabricaServicioIMP : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
