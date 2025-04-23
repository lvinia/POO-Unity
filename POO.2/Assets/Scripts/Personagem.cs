using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private float forca_do_pulo;
    private float velocidade;
    private int numero_de_pes;
    private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string NomeDoPersonagem()
    {
        return this.nome;
    }
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }
    public void AtribuirForcaAtaque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int ForcaAtaque()
    {
        return this.forca_ataque;
    }
    public void AtribuirForcaPulo(float forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public float ForcaPulo()
    {
        return this.forca_do_pulo;
    }
    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }
    public void AtribuirNumeroPes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }

    public int NumeroDePes()
    {
        return this.numero_de_pes;
    }
    public void AtribuirNumeroMaos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }

    public int NumeroDeMaos()
    {
        return this.numero_de_maos;
    }
    
    
    
    

}
