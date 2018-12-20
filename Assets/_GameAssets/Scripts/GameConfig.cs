/**
 *  Contiene informacion de contexto del Juego
 * */
public class GameConfig {
    private static bool jugando = true;
    public static bool IsPlaying()
    {
        return jugando;
    }
    public static void ArrancaJuego()
    {
        jugando = true;
    }
    public static void ParaJuego()
    {
        jugando = false;
    }
}
