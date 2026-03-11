using UnityEngine;

public class Ex10 : MonoBehaviour
{
    [SerializeField] private float salario = 1000f;
    void Start()
    {
        float salarioFinal = salario + (salario * 0.10f);
        print("salário com 10% de aumento :" + salarioFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
