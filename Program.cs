using System;
public class Queue
{
    private int maxSize;     // Tamaño máximo de la cola
    private int front;       // Índice del frente de la cola
    private int rear;        // Índice del final de la cola
    private int[] queueArray; // Arreglo que almacena los elementos de la cola

    public Queue(int size)
    {
        maxSize = size;              // Inicializa el tamaño máximo
        queueArray = new int[maxSize]; // Crea el arreglo con el tamaño especificado
        front = 0;                   // Inicializa el índice del frente en 0
        rear = -1;                   // Inicializa el índice del final en -1 (cola vacía)
    }

    public bool IsEmpty()
    {
        return (rear == -1); // Comprueba si la cola está vacía (índice del final en -1)
    }

    public bool IsFull()
    {
        return (rear == maxSize - 1); // Comprueba si la cola está llena (índice del final igual al tamaño máximo - 1)
    }

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede insertar más elementos.");
        }
        else
        {
            queueArray[++rear] = item; // Inserta un elemento en la posición del final y luego incrementa el índice del final
            Console.WriteLine($"Se insertó {item} en la cola.");
        }
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede realizar la operación Dequeue.");
            return -1;
        }
        else
        {
            int dequeuedItem = queueArray[front++]; // Obtiene el elemento en el frente de la cola y luego incrementa el índice del frente
            if (front > rear)
            {
                front = 0;
                rear = -1;
            }
            Console.WriteLine($"Se retiró {dequeuedItem} de la cola.");
            return dequeuedItem;
        }
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede realizar la operación Peek.");
            return -1;
        }
        else
        {
            return queueArray[front]; // Retorna el elemento en el frente de la cola sin modificar el índice del frente
        }
    }
}

class Program
{
    static void Main()
    {
        Queue queue = new Queue(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        int peekedItem = queue.Peek();
        Console.WriteLine($"Elemento en el frente de la cola: {peekedItem}");

        int dequeuedItem = queue.Dequeue();
        Console.WriteLine($"Elemento retirado de la cola: {dequeuedItem}");
    }
}