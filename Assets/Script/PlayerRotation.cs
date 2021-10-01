using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public bool travarMouse = true;//controla se o cursor do mouse é exibido
    public float sensibilidade = 2.0f;//controla a sensibilidade do mouse
    private float mouseX = 0.0f, mouseY = 0.0f;//variavel q controla a rotação do mouse

    void Start()
    {
        if (!travarMouse) {
            return;
        }
        Cursor.visible = false; //oculta o cursor do mouse
        Cursor.lockState = CursorLockMode.Locked;//trava o cursor no centro
    }
    
    void Update()
    {
        mouseX += Input.GetAxis("MouseX") * sensibilidade;// Incrementa o valor do eixo X e multiplica pela sensibilidade
        mouseY -= Input.GetAxis("MouseY") * sensibilidade;

        transform.eulerAngles = new Vector3(0, mouseX, 0);//Executa a rotação da câmera de acordo com os eixos
    }
}
