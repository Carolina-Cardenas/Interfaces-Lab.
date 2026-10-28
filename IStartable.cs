namespace InterfacesLab;

public interface IStartable
//     ↑ INTERFAZ: la reconoces por la palabra interface.
// IStartable es su nombre.
// La I inicial es una convención para identificar interfaces.
{
    void Start();
    // ↑ EXIGENCIA: las clases que implementen esta interfaz
    // deberán proporcionar un método llamado Start.
    //
    // void: no devuelve un valor.
    // (): no recibe datos.
    // ;: termina la declaración.
    //
    // Aquí no escribimos las instrucciones de Start.
    // Cada clase escribirá qué hace su propio Start.
}