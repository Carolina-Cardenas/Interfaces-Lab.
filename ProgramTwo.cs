using System;

namespace InterfacesLab;

public class ProgramTwo : IStartable
//                      ↑ También debe cumplir IStartable.
{
    // Método anterior desactivado:
    // public void Go()
    // {
    //     Console.WriteLine("Now running program 2.");
    // }

    public void Start()
    //          ↑ Misma operación exigida: Start().
    // Esta clase escribe sus propias instrucciones.
    {
        Console.WriteLine("Now running program 2.");
    }
}