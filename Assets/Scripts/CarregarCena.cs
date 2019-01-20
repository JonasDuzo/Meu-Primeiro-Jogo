using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
    public void CarregarProxCena()
    {
        int carregarCena = SceneManager.GetActiveScene().buildIndex; //Variavel para construir a construir a cena
        SceneManager.LoadScene(carregarCena + 1); //Carregar proxima cena
    }
    
    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
