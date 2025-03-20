public class Enlazada{
    private Nodo primero;
    private int contador;

    public Enlazada(){
        primero = null;
        contador = 0;
    }

    //Agregar elementos a la lista

    public void AgregarFinal(object codigo,object tipo){
        Nodo nuevoNodo = new Nodo(codigo,tipo);
        if(primero == null){ //cuando la lista este vacia se agrega el valor al primer elemento
            primero = nuevoNodo; // va a tener los valores que le pusimos a nuevoNodo
        }else{
            Nodo actual = primero; // nodo auxiliar copia el primer elemento de la lista
            while(actual.Siguiente != null){
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        contador++;
    }//agregar al final

    //Enlistar todos los elementos
    public void enlistar(){
        Nodo actual = primero;  
        Console.WriteLine("  Codigo del Carro \t\t Tipo de Carro");

        Console.WriteLine("----------\t\t ---------------");
        while(actual != null){
            Console.WriteLine($"{actual.Valor1} \t\t {actual.Valor2}");
            actual = actual.Siguiente;
        }
    }//enlistar

    public int contarElementos(){
        return contador;
    }

    public void agregarEnIndice(object tipo,object codigo, int indice){
        if(indice >=0 && indice < contador){
            Nodo nuevoNodo = new Nodo(tipo,codigo);
            if(indice == 0){
                nuevoNodo.Siguiente = primero;
                primero = nuevoNodo;
                contador++;
                return;
            }else{
                Nodo actual = primero;
                for(int i = 0; i < indice-1; i++){
                    actual = actual.Siguiente;
                }
                nuevoNodo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevoNodo;
                contador++;  
            }

        }else{
            Console.WriteLine("Indice fuera de rango");
        }

    }
    //eliminar un elemento por valor
    public void eliminarPorValor(object valor){
        if(primero == null)return;

        if(primero.Valor1.Equals(valor)){
            primero = primero.Siguiente;
            contador--;
            return;
        }
        Nodo actual = primero;
        while (actual.Siguiente != null && !actual.Siguiente.Valor1.Equals(valor)){
            actual = actual.Siguiente;

        }
        if (actual.Siguiente != null){
            actual.Siguiente = actual.Siguiente.Siguiente;
            
        }
        contador--;
    }

    //eliminar un elemento por indice
    public void eliminarPorIndice(int indice){
        if(indice >=0 && indice < contador){
            if(indice == 0){
                if (primero != null){
                    primero = primero.Siguiente;
                    contador--;
                    return;
                }
            }
            Nodo actual = primero;
            for(int i = 0; i < indice -1; i++){
                actual = actual.Siguiente;
            }
            if (actual.Siguiente != null){
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            contador--;
        }else{
            Console.WriteLine("Indice fuera de rango");
        }
    }

    //eliminar todos los elementos
    public void eliminarTodos(){
        primero = null;
        contador = 0;
    }

    //buscar un elemento por valor
   public (object,object) buscarPorValor(int indice){
      if(indice >=0 && indice < contador){
       Nodo actual = primero;
       for(int i = 0; i < indice; i++){
           actual = actual.Siguiente;
       }//for
       return actual != null? (actual.Valor1,actual.Valor2) : (null,null);
   }else
   {
    Console.WriteLine("Indice fuera de rango");
    return (null,null);
   }
   }

   // buscar un elemento por valor
   public bool buscarPorValor(object valor){
    
Nodo actual = primero;
while (actual != null){
    if(actual.Valor1.Equals(valor))return true;
    actual = actual.Siguiente;
    }
    return false;
   }
}//Class