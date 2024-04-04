using Pou;

public class personagem
{
    private int fome;
    protected int sede;
    protected int passear;
    public int banho;

    public personagem()
    {       
    fome = 0;
    sede = 0;
    passear = 0;
    banho = 0;
    }
 public void  SetFome(int f)
 {
    if (f <=1 && f >= 0)
        fome=f ;
    else if ( f > 1)
        fome = 1;
    else
      fome = 0;
 }


}
