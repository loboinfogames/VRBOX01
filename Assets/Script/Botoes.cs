using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public void CarregarMENU()
    {
        SceneManager.LoadScene("MENU");
    }
    public void CarregarJOGO()
    {//Chama no Onclick do botao de menu
        SceneManager.LoadScene("JOGO");
    }

    public void CarregarCREDITOS()
    {

        SceneManager.LoadScene("CREDITOS");
    }
    public void CarregarGAMEOVER()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("GAMEOVER");
    }
    public void SAIRapp()
    {
        Application.Quit();
        Debug.Log("SAIR DO JOGO");
    }
        
}
