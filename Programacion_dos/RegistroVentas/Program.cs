using System;
using Programacion_dos.RegistroVentas;


namespace Programacion_dos.RegistroVentas
{
    public class Program
    {

    static void Main(String []args)
        {


            Contabilidad contabilidad = new Contabilidad();

            Vendedor vendedor1 = new Vendedor();
            vendedor1.Nombre = "Carlos";
            vendedor1.Edad = 25;
            contabilidad.AgregarVendedor(vendedor1);

            Vendedor vendedor2 = new Vendedor();
            vendedor2.Nombre = "Alberto";
            vendedor2.Edad = 20;
            contabilidad.AgregarVendedor(vendedor2);

            Vendedor vendedor3 = new Vendedor();
            vendedor3.Nombre = "Juan";
            vendedor3.Edad = 30;
            contabilidad.AgregarVendedor(vendedor3);

            Vendedor vendedor4 = new Vendedor();
            vendedor4.Nombre = "Pedro";
            vendedor4.Edad = 35;
            contabilidad.AgregarVendedor(vendedor4);


            Vendedor vendedor5 = new Vendedor();
            vendedor5.Nombre = "Cristian";
            vendedor5.Edad = 27;
            contabilidad.AgregarVendedor(vendedor5);

            Producto producto1 = new Producto();
            producto1.Nombre = "camiseta";
            producto1.Precio = 15000;
            contabilidad.AgregarProducto(producto1);

            Producto producto2 = new Producto();
            producto2.Nombre = "pantalon";
            producto2.Precio = 50000;
            contabilidad.AgregarProducto(producto2);


            Producto producto3 = new Producto();
            producto3.Nombre = "chaqueta";
            producto3.Precio = 80000;
            contabilidad.AgregarProducto(producto3);
            
            Producto producto4 = new Producto();
            producto4.Nombre = "bolso";
            producto4.Precio =40000;
            contabilidad.AgregarProducto(producto4);

            Producto producto5 = new Producto();
            producto5.Nombre = "zapatos";
            producto5.Precio = 90000;
            contabilidad.AgregarProducto(producto5);


            Venta venta1 = new Venta();
            venta1.Vendedor = vendedor1;
            venta1.Producto = producto2;
            contabilidad.AgregarVenta(venta1);


            Venta venta2=new Venta();
            venta2.Vendedor= vendedor3;
            venta2.Producto = producto2;
            contabilidad.AgregarVenta(venta2);
            

            Venta venta3 = new Venta();
            venta3.Vendedor= vendedor1;
            venta3.Producto= producto2;
            contabilidad.AgregarVenta(venta3);

            int TotalVentas = venta1.Producto.Precio + venta2.Producto.Precio + venta3.Producto.Precio;
            Console.WriteLine("El total de ventas es:" + TotalVentas);





        }

    }
}
