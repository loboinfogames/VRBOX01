using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    [SerializeField]
    public float speed;         //velocidade de movimento, regula no Unity
    private Vector3 direction; //direção que o player vai andar
    
    void Start()
    {
        direction = Vector3.up;
    }
    void Update()
    {
        GetInput();  //tecla que você pressionar
        MOVE();      //executa o movimento de acordo com o IF
        
    }
    public void MOVE()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void GetInput()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))   // pode trocar o W pelo UpArrow, anda e fica com a animação up
        {
            direction += Vector3.up;;
        }
        if (Input.GetKeyUp(KeyCode.W))   //quando soltar o botão, fica só com a animação de parado ligada
        {

        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

        }
    }
}
