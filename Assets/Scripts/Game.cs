using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI proxPalpite;
    int palpite;

    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        ProxPalpite();
    }

    public void OnClickMais()
    {
        min = palpite;
        ProxPalpite();
    }

    public void OnClickMenos()
    {
        max = palpite;
        ProxPalpite();
    }

    public void ProxPalpite()
    {
        palpite = Random.Range(min, max +1);
        proxPalpite.text = palpite.ToString();// Dizendo que os valores que o campo proximo palpite receber vai ser convertido para String;
    }
}
