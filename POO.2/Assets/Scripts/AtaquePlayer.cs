using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Personagem personagem;
    private int ataque;
    

    public int AtaqueDoPersonagem()
    {
        ataque = personagem.ForcaAtaque(); 
        return ataque;
    }
}