using System;
namespace Programacion_dos.RegistroVentas
{
    public class Contabilidad
    {
        Vendedor[] Vendedor= new Vendedor[10];
        int vendedorcont = 0;

        Producto[] Producto = new Producto[10];
        int productocont = 0;

        Venta[] Venta = new Venta[10];
        int ventacont = 0;


        public void AgregarVendedor(Vendedor vendedor)
        {

            Vendedor[vendedorcont] = vendedor;
            vendedorcont++;


        }

        public void AgregarVenta(Venta venta)
        {
           Venta[ventacont] = venta;
           ventacont++;
        }

        public void AgregarProducto(Producto producto)
        {
            Producto[productocont] = producto;
            productocont++;
        }



    }
}
