using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserInimigo : MonoBehaviour
{
    public float laserVelocidade;
    public int danoDoLaserInimigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LaserMovimento();
    }
    private void LaserMovimento()
    {
        transform.Translate(Vector3.left * laserVelocidade * Time.deltaTime);
    }
    

    private void OnTriggerEnter2D(Collider2D other) //DETECTOR DE COLISÃO DO ATAQUE
    {
        if (other.gameObject.CompareTag("Player")) //verificar se foi o player que colidiu
        {
            other.gameObject.GetComponent<playerVida>().Dano(danoDoLaserInimigo); //ACESSA O GAMEOBJECT QUE COLIDIU; ACESSA O SCRIPT VIDA DO PLAYER E EM SEGUIDA ATIVA O METODO PARA DAR DANO 
            Destroy(this.gameObject);
        }
        
    }

    
}
