using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

class Rescatar
{
    static private int rd {get; set;}
    
    public static int generarRandom(){
        Random r = new Random();
        rd = r.Next(1,101);
        return rd;
    }
    public static string devolverRespuesta (int intento){
        string rta;
        if (intento>rd){
            rta="Es menor";
        }
        else if (intento<rd){
            rta="Es mayor";
        }
        else rta="Es igual";
        return rta;
    }
    
}