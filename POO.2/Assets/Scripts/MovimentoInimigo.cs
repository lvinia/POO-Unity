using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    public float velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;
    
    private SphereCollider _sphereCollider;
    private void Start()
    {
      _rigidbody = gameObject.GetComponent<Rigidbody>();
      velocidade = GetComponent<Inimigo>().Velocidade();
      _sphereCollider = gameObject.GetComponent<SphereCollider>();
          
      _player = GameObject.FindWithTag("Player");    
    }
    void Update()
    {
        _sphereCollider.radius = raioDeVisao;

        if (naVisao == true)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
    }
    void OnTriggerStay(Collider colisao)
{
    if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
            }
    }
    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
            {
                naVisao = false;
                }
        }
}
 
