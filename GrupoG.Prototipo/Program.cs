using GrupoG.Prototipo;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Deposito;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion;
using GrupoG.Prototipo.Almacenes.Remito;
using GrupoG.Prototipo.Despacho;
using GrupoG.Prototipo.Extra.ConsultaMercaderia;
using GrupoG.Prototipo.Extra.Estados;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PantallaMenu());

            ClientesAlmacen.Grabar();
            DepositoAlmacen.Grabar();
            MercaderiasAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            OrdenSeleccionAlmacen.Grabar();
            OrdenEntregaAlmacen.Grabar();
            RemitoAlmacen.Grabar();
        }
    }
}