using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

class Rescatar
{
    static private int rd {get; set;}
    
    public static int generarRandom(){
        Random r = new Random();
        rd = r.Next(1,51);
        return rd;
    }
    public static int ReturnRD()
    {
        return rd;
    }
    public static string devolverRespuesta (int intento){
        string rta;        
        if (intento>50 || intento<1) rta="Te fuiste de rango";
        else if (intento>rd) rta="El número a adivinar es menor";
        else if (intento<rd) rta="El número a adivinar es mayor";
        else rta="El número a adivinar es igual";
        return rta;
    }
    
}