using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

class Quiz
{
    static private int nivel {get; set;} = 1;
    static private int puntos {get; set;} = 0;
    static private string[] respuestas { get; set; } = { "steve harris"};

    public static void iniciar (){
        nivel=1;
        puntos=0;
    }

    public static bool comprobar (string rta, int nivel){
        bool verificar = false;
        rta=rta.ToLower();
        if(rta==respuestas[nivel-1]){
            verificar=true;
            nivel++;
            puntos+=3000;
        }
        return verificar;
    }

    public static int VerNivel(){
        return nivel;
    }
    public static int VerPuntos(){
        return puntos;
    }
}