internal class Program
{
    static void Main(string[] args)
    {
        Inicio();

        Console.ReadKey();
    }
    public static void Inicio()
    {
        Console.Clear();
        escribir("================================\n");
        escribir("Tienda de Don Lucas\n");
        escribir("================================\n");
        escribir("1: Registrar venta\n");
        escribir("2: Registrar devolución\n");
        escribir("3: Cerrar Caja\n");
        escribir("================================\n");
        escribir("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: RegistrarVenta(); break;
            case 2: RegistrarDevolucion(); break;
            case 3: CerrarCaja(); break;
        }
    }

    public static void RegistrarVenta()
    {
        Console.Clear();
        escribir("================================\n");
        escribir("Registrar Venta de:\n");
        escribir("================================\n");
        escribir("1: Limpieza\n");
        escribir("2: Abarrotes\n");
        escribir("3: Golosinas\n");
        escribir("4: Electrónicos\n");
        escribir("5: <- Regresar\n");
        escribir("================================\n");
        escribir("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        string objeto;
        switch (opcion)
        {
            case 1: objeto = "Limpieza"; break;
            case 2: objeto = "Abarrotes"; break;
            case 3: objeto = "Golosinas"; break;
            case 4: objeto = "Electrónicos"; break;
            case 5: Inicio(); break;
        }
    }

    public static void RegistrarDevolucion()
    {
        Console.Clear();
        escribir("================================\n");
        escribir("Registrar devolución de:\n");
        escribir("================================\n");
        escribir("1: Limpieza\n");
        escribir("2: Abarrotes\n");
        escribir("3: Golosinas\n");
        escribir("4: Electrónicos\n");
        escribir("5: <- Regresar\n");
        escribir("================================\n");
        escribir("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        string objeto;
        switch (opcion)
        {
            case 1: objeto = "Limpieza"; break;
            case 2: objeto = "Abarrotes"; break;
            case 3: objeto = "Golosinas"; break;
            case 4: objeto = "Electrónicos"; break;
            case 5: Inicio(); break;
        }
    }
    public static void CerrarCaja()
    {
        escribir("================================\r\n " +
        "Tienda de Don Lucas\r\n" +
        "================================\r\n" +
        "1: Registrar venta\r\n" +
        "2: Registrar devolución\r\n" +
        "3: Cerrar Caja\r\n" +
        "================================\r\n" +
        "Cerrando Caja\r\n" +
        "================================\r\n" +
        "Totales\r\n" +
        "================================\r\n" +
        "          | 15 vendidos\r\n" +
        "Limpieza  | 10 devueltos\r\n" +
        "          | 5 en total\r\n" +
        "          | S/ 35.00 en caja\r\n" +
        "================================\r\n" +
        "          | 4 vendidos\r\n" +
        "Abarrotes | 0 devueltos\r\n" +
        "          | 4 en total\r\n" +
        "          | S/ 12.00 en caja\r\n" +
        "================================\r\n" +
        "          | 6 vendidos\r\n" +
        "Golosinas | 2 devueltos\r\n" +
        "          | 4 en total\r\n" +
        "          | S/ 8.00 en caja\r\n" +
        "================================\r\n" +
        "          | 6 vendidos\r\n" +
        "Eletro    | 0 devueltos\r\n" +
        "          | 6 en total\r\n " +
        "         | S/ 89.00 en caja\r\n" +
        "================================\r\n" +
        "Queda en caja S/144.00");
    }
    public static void escribir(string txt)
    {
        Console.Write(txt);
    }
}