using System;

namespace InterfacesLab;

public class ProgramOne : IStartable, IStoppable
//                      ↑ Implementa DOS interfaces.
// La coma separa sus nombres.
// Debe proporcionar Start() y Stop().
{
    // Método original desactivado:
    // public void Run()
    // {
    //     Console.WriteLine("Now running program 1.");
    // }

    public void Start()
    // ↑ Cumple la exigencia de IStartable.
    {
        Console.WriteLine("Now running program 1.");
    }

    public void Stop()
    // ↑ Cumple la exigencia de IStoppable.
    {
        Console.WriteLine("Program 1 stopped.");
    }
}