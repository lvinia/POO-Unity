using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O "+ fusca.NomeDoCarro());
        
        gol.AtribuirNome("Gol do Faustão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O "+ gol.NomeDoCarro());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
