using UnityEngine;

public class Ex9 : MonoBehaviour
{
    [SerializeField]  private int numero;
    void Start()
    {
        float dobronum = numero * 2;
        float metadnum = numero / 2;
        print(numero + " tem o dobro como :" + dobronum);
        print(numero + " tem a metade como :" + metadnum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
