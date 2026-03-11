using UnityEngine;

public class Ex2 : MonoBehaviour
{
    void Start()
    {
        int vida = 100;
        int dano = 25;

        int novaVida = vida - dano;
        print("vida após o dano : " + novaVida); 
        
    }

    
}
