using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //definindo as variaveis
    public GameObject player;
    private Vector3 offset;
   // private Vector3 rotacaoCam;
   
    void Start()
    {
        offset = transform.position - player.transform.position;
       // rotacaoCam = transform.rotation - player.transform.rotation;
    }
       
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
       // transform.rotation = player.transform.rotation + rotacaoCam;
    }
}
