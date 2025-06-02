using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;
    public bool andando = false;
    
    private void Start()
    {
        velocidade = GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 posicao = transform.position;
        
        andando = false;

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,45,0);
            andando = true;
        }
        else
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,135,0);
            andando = true;
        }
        else
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,-45,0);
            andando = true;
        }
        else
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,-135,0);
            andando = true;
        }
        else 
            //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,-90,0);
            andando = true;
        }
        else
        
        //direita X+

        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,90,0);
            andando = true;
        }
        else
        //cima Z+
        
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,0);
            andando = true;
        }
        else
        //baixo Z-
        
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,180,0);
            andando = true;
        }
        
        transform.position = posicao;
    }
}
