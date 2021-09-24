using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    
    void Start()
    {
        gameObject.tag = "bala";
        Destroy(this.gameObject, 7);
    }

    
    void Update()
    {
        
    }
}
