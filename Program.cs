double glicemia;

string estado;

Console.WriteLine("Qual aquantidade de glicemia em mg/dl: ");

glicemia = Convert.ToDouble(Console.ReadLine());

if (glicemia >= 92)
{
    estado = "Compatível com Diabetes Gestacional";
}
else
{
    if (glicemia > 126)
    {
        estado = "Diabetes Mellitus na gravidez";
    }
    else
    {
        estado = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
    }
}


Console.WriteLine($"{estado}");
