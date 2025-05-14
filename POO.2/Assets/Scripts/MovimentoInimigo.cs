using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    private GameObject _player;
    public GameObject ataqueObject;
    
    
    private Rigidbody _rigidbody;
    public float velocidade;

    public float raioDeVisao = 5;
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

        if (Vector3.Distance(transform.position, _player.transform.position) > raioDeVisao)
        {
            if (naVisao == true)
            {
                transform.LookAt(_player.transform.position);
                transform.position = Vector3.MoveTowards(transform.position, _player.transform.position,
                    velocidade * Time.deltaTime);
            }

            ataqueObject.SetActive(false);
        }
        else
        {
            ataqueObject.SetActive(true);
        }
        
        Debug.DrawLine(transform.position, _player.transform.position, Color.red);
        
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
 
