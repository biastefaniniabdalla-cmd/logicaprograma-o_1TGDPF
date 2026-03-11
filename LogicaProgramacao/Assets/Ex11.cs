using UnityEngine;

public class Ex11 : MonoBehaviour
{
    [SerializeField]  public float velocidadeInicial;
    [SerializeField]  public float aceleracao;
    [SerializeField]  public float tempo;
    void Start()
    {
        float velocidadeFinal = velocidadeInicial + aceleracao * tempo;
        print("velocidade final é de : " + velocidadeFinal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
