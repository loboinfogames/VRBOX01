using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    float _velocidadeFrente;
    float _velocidadeTras;
    //float _velocidadeGirar;

    void Start() {
        _velocidadeFrente = 10;
        _velocidadeTras = 5;
       // _velocidadeGirar = 60;
    }

    void Update() {
        if (Input.GetKey("w")) {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }

        if (Input.GetKey("s")) {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }

        if (Input.GetKey("a")) {
            transform.Translate((-7 * Time.deltaTime),0,0);
        }

        if (Input.GetKey("d")) {
            transform.Translate((7 * Time.deltaTime),0,0);
        }
    }
}