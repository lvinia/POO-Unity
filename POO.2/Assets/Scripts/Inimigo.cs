using UnityEngine;

public class Inimigo : Personagem
{
    private string armadura;
    private string arma;

    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return this.arma;
    }


    public int DanoDoInimigo()
    {

        int dano = 0;

        switch (arma)
        {
            case "ESPADA":
                dano = ForcaAtaque() + 10;
                break;
            case "MACHADO":
                dano = ForcaAtaque() + 18;
                break;
            case "ADAGA":
                dano = ForcaAtaque() + 5;
                break;
        }

        return dano;
    }
}
