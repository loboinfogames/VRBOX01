using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimeno : MonoBehaviour
{
    public float velocidade = 5f;
    public float veloRotacao = 200f;

    void Start()
    {
        
    }

    
    void Update()
    {
        //movimento do player
        transform.Translate(0f, 0f, Input.GetAxis("vertical") * velocidade * Time.deltaTime);

        //rotação do player via mouse em script PlayerRotationS

    }
}
