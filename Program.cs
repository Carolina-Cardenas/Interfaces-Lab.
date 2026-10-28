namespace InterfacesLab;

internal class Program
{
    private static void Main()
    {
        ProgramOne firstProgram = new ProgramOne();
        // ↑ Crea UN objeto de ProgramOne.
        // firstProgram permite acceder a ese objeto.

        IStartable startableProgram = firstProgram;
        // ↑ Accede al MISMO objeto mediante IStartable.
        // Desde esta variable podemos llamar a Start().

        IStoppable stoppableProgram = firstProgram;
        // ↑ Accede al MISMO objeto mediante IStoppable.
        // Desde esta variable podemos llamar a Stop().
        // Estas asignaciones no crean objetos nuevos.

        IStartable secondProgram = new ProgramTwo();
        // ↑ Crea un objeto de ProgramTwo.

        // Llamadas originales desactivadas:
        // firstProgram.Run();
        // secondProgram.Go();

        startableProgram.Start();
        // ↑ Ejecuta ProgramOne.Start().

        secondProgram.Start();
        // ↑ Ejecuta ProgramTwo.Start().

        stoppableProgram.Stop();
        // ↑ Ejecuta ProgramOne.Stop().
    }
}