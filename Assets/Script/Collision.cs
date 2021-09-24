using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject EsseObjeto;
    public GameObject OutroObjeto;
    void Start() {
    
    gameObject.tag = "bala";
    }

/*public void OnTriggerEnter(Collider other) {
    
    if (other.tag == "bala") {
        
        
        
    }
}
     void OnCollisionEnter2D(Collision2D Collision) {
         if (Collision.gameObject.tag == "Player") {
             Destroy(OtherGameObject);
         }
     }*/
         
    void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.name == "box") {
                        
            Destroy(EsseObjeto);
        }

        
        if (collision.gameObject.tag == "box") {
            
            Destroy(OutroObjeto);
        }
    }
}