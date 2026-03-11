using UnityEngine;

public class Ex1 : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;

    void Start()
    {
        float resultadoFinal = a + b;
        print ( a + "+" + b + "=" + resultadoFinal);
        
    }

}
