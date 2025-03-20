/*
Martinez Morales Erick de Jesus
Martin Rojas Carlos Ariel
Sanchez Zagal German Dario
19 de marzo 2025
4C
Ejercicio 4. Carritos de Supermercado
*/
class Program{
    static void Main(string[] args){
        

        bool opcion = true;
       

        while(opcion){
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de carritos");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1. Agregar carrito");
            Console.WriteLine("2. Retirar carrito");
            Console.WriteLine("3. Carritos Totales");
            Console.WriteLine("4. Estadisticas");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            
            Console.Write("Opcion: ");
            string Seleccion = Console.ReadLine();
            switch(Seleccion){
                case "1":AgregarCarrito();
                return;
                case "2":
                return;
                case "3":
                return;
                case "4":
                return;
                case "5":
                opcion = Salir();
                return;
                default:
                Console.WriteLine("Opcion Incorrecta Escriba 1,2,3,4,5 para continuar");
                Console.ReadKey();
                break;
            }
        
        
        }
        
    }

public static void InicializarCarritosNormales()
    {
        // Configurar la consola para mostrar Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Emoji de carrito de compras
        string carrito = "\U0001F6D2";

        // Crear lista de carritos normales
        Enlazada Normales = new Enlazada();
        Normales.AgregarFinal("0001", $"{carrito}");
        Normales.AgregarFinal("0002", $"{carrito}");
        Normales.AgregarFinal("0003", $"{carrito}");
        Normales.AgregarFinal("0004", $"{carrito}");
        Normales.AgregarFinal("0005", $"{carrito}");
        Normales.AgregarFinal("0006", $"{carrito}");
        Normales.AgregarFinal("0007", $"{carrito}");
        Normales.AgregarFinal("0008", $"{carrito}");
        Normales.AgregarFinal("000", $"{carrito}");
        Normales.AgregarFinal("0002", $"{carrito}");

        // Mostrar resultados
        Normales.contarElementos();
        Normales.enlistar();
    }

public static void InicializarCarritosPequenos(){
       //Carritos Pequeños
       Carritos carritoP11 = new Carritos("0010", "Carrito Pequeño");
       Carritos carritoP12 = new Carritos("0011", "Carrito Pequeño");
       Carritos carritoP13 = new Carritos("0012", "Carrito Pequeño");
       Carritos carritoP14 = new Carritos("0013", "Carrito Pequeño");
       Carritos carritoP15 = new Carritos("0014", "Carrito Pequeño");
       Enlazada CarritosP = new Enlazada();
       CarritosP.AgregarFinal(carritoP11.Codigo, carritoP11.Tipo);
       CarritosP.AgregarFinal(carritoP12.Codigo, carritoP12.Tipo);
       CarritosP.AgregarFinal(carritoP13.Codigo, carritoP13.Tipo);
       CarritosP.AgregarFinal(carritoP14.Codigo, carritoP14.Tipo);  
       CarritosP.AgregarFinal(carritoP15.Codigo, carritoP15.Tipo);
       CarritosP.enlistar();    
       }

public static void InicializarCarritosPortabebe(){
       //Carritos con Porta Bebe
       Carritos carritoPB16 = new Carritos("0015", "Carrito con Porta Bebe");
       Carritos carritoPB17 = new Carritos("0016", "Carrito con Porta Bebe");
       Carritos carritoPB18 = new Carritos("0017", "Carrito con Porta Bebe");
       Carritos carritoPB19 = new Carritos("0018", "Carrito con Porta Bebe"); 
       Carritos carritoPB20 = new Carritos("0019", "Carrito con Porta Bebe");
       Enlazada carritosPB = new Enlazada();
        carritosPB.AgregarFinal(carritoPB16.Codigo, carritoPB16.Tipo);
        carritosPB.AgregarFinal(carritoPB17.Codigo, carritoPB17.Tipo);
        carritosPB.AgregarFinal(carritoPB18.Codigo, carritoPB18.Tipo);
        carritosPB.AgregarFinal(carritoPB19.Codigo, carritoPB19.Tipo);
        carritosPB.AgregarFinal(carritoPB20.Codigo, carritoPB20.Tipo);
        carritosPB.enlistar();
}

public static void AgregarCarrito(){
    Console.WriteLine("Seleccione el tipo de carrito");
    Console.WriteLine("1. Carrito pequeño");
    Console.WriteLine("2. Carrito normal");
    Console.WriteLine("3. Carrito con porta bebe");
    int tipo = int.Parse(Console.ReadLine());
    switch(tipo){
        case 1:
        bool Opcionn = true;
        while(Opcionn){
            Console.Clear();
            InicializarCarritosPequenos();
        Console.WriteLine("¿Desea agregar mas carritos?");
        Console.WriteLine("Porfavor escriba S para agregar mas carritos o N para salir");
        Opcionn = SoN();
        }
        return;

        case 2:
         bool Opcionn2 = true;
        while(Opcionn2){
            Console.Clear();
            InicializarCarritosNormales();
        Console.WriteLine("¿Desea agregar mas carritos?");
        Console.WriteLine("Porfavor escriba S para agregar mas carritos o N para salir");
        Opcionn = SoN();
        }
        return;
        case 3:
        bool Opcionn3 = true;
        while(Opcionn3){
            Console.Clear();
            InicializarCarritosPortabebe();
        Console.WriteLine("¿Desea agregar mas carritos?");
        Console.WriteLine("Porfavor escriba S para agregar mas carritos o N para salir");
        Opcionn = SoN();
        }
        return;
    }
}


static bool SoN()
    {
        while (true)
        {
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "S")
            {
                return true;
            }
            else if (respuesta == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor escriba S para continuar o N para salir.");
            }
        }
    }


public static void seleccion(){
    string opcion;
    Console.WriteLine("Seleccione una opcion");
    
}

public static bool Salir(){
    string opcion;
    Console.WriteLine("¿Quieres salir?");
    Console.WriteLine("Porfavor escriba Salir para salir");
    opcion = Console.ReadLine();
    if (opcion.ToUpper().Equals("SALIR")){
        return false;
    }else{
        Console.WriteLine("Opcion Incorrecta Escriba Salir para salir");
        return Salir();
    }

}


    public static void gotoxy(int x, int y){
        Console.SetCursorPosition(x, y);
    }


}