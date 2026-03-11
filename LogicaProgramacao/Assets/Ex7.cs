using UnityEngine;

public class Ex7 : MonoBehaviour
{
    [SerializeField] public int numero1;
    [SerializeField] public int numero2;
    void Start()
    {
        float somNums = numero1 + numero2;
        print("a soma de " + numero1 + "+" + numero2 + " é igual a " + somNums);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
