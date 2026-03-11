using UnityEngine;

public class Ex8 : MonoBehaviour

{
    [SerializeField]  public int vida = 100;
    [SerializeField]  public int dano;

    void Start()
    {
        float vidaFinal = vida - dano;
        print( "vida final é de " + vidaFinal );
        
    }

    
}
