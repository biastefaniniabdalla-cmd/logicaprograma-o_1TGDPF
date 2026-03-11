using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string Nome;
    [SerializeField] private int Horas;
    [SerializeField] private float ValorHoras;



    void Start()
    {
        float salarioFinal = (ValorHoras * Horas);
        print("funcionário: " + (Nome) + " trabalha " + (Horas) + " horas, e recebe " + (ValorHoras) + " por hora, ao final do dia recebe: " + (salarioFinal));
    }

    
}
