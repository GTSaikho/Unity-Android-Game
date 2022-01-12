using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float Velocidade; //Velocidade do projétil
    public GameObject alvo; //Seleciona qual será o alvo do projétil
    private Transform alvoT; //Posição que vai receber a posição do alvo
    

    // Start is called before the first frame update
    void Start()
    {
        
        alvoT = alvo.transform;

    }

    // Update is called once per frame
    void Update()
    {
        float VelocidadeConstante = Velocidade * Time.deltaTime;


        transform.position = Vector3.MoveTowards(transform.position, alvoT.position, VelocidadeConstante/10);
        transform.right = alvoT.position - transform.position;

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Heart") || collision.gameObject.CompareTag("Shield"))
        {
            Destroy(gameObject);
        }

    }
    
}
