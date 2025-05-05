using UnityEngine;

public class TesteCodigo : MonoBehaviour
{
    public void Mensagem(string mensagem)
    {
        Debug.Log(mensagem);
        return;
    }

    public void IdadeDaPessoa(string nome, int idade)
    {
       // Debug.Log(" A pessoa de nome "+nome+" tem "+idade+" anos." );

       string frase = " A pessoa de nome " + nome + " tem " + idade + " anos.";
       
       Mensagem(frase);
    }
    
    void Start()
    {
        IdadeDaPessoa(nome:"João", idade:15);
        IdadeDaPessoa(nome:"Maria", idade:45);
        IdadeDaPessoa(nome:"José", idade:50);
        IdadeDaPessoa(nome:"Márcia", idade:65);
    }

    
    void Update()
    {
        
    }
}
