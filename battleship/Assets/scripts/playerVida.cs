using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerVida : MonoBehaviour
{
    public Slider lifeBar;
    public int vidaMax;
    public int vidaAtual;
    public bool haEscudo;
    public GameObject escudoDoPlayer;
    public int escudoVidaMax;
    public int escudoVidaAtual;
    


    void Start()
    {
        vidaAtual = vidaMax;

        lifeBar.maxValue = vidaMax;

        lifeBar.value = vidaAtual;
        
        escudoDoPlayer.SetActive(true);
        
        escudoVidaAtual = escudoVidaMax;
    }
    
    void Update()
    {
        
    }

    public void EscudoActive()
    {
        escudoDoPlayer.SetActive(true);
        haEscudo = true;

        
    }

    public void PoweUpVida(int vidaExtra)
    {
        if (vidaAtual + vidaExtra <= vidaMax)
        {
            vidaAtual += vidaExtra; //parei aqui!!
        }
    }

    public void Dano(int danoAReceber) 
    {
        if (haEscudo == false)
        {
            vidaAtual -= danoAReceber;
                    
            lifeBar.value = vidaAtual;
                    
            if (vidaAtual <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("GAME OVER");
            }
        }
        else
        {
            escudoVidaAtual -= danoAReceber;
            if (escudoVidaAtual <= 0)
            {
                escudoDoPlayer.SetActive(false);
                haEscudo = false;
            }
        }
    }



}
