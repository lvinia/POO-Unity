using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private Player player;
    public float velocidadeDaAnimacao = 1;
    void Start()
    {
        player = GetComponent<Player>();
    }

   
    void Update()
    {
        animator.SetBool("Andando", player.andando);
        animator.speed = velocidadeDaAnimacao;
    }
}
