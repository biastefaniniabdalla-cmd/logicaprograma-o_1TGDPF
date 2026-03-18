using UnityEngine;

public class Lista3Ex4 : MonoBehaviour
{
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (num1 == num2)
        {
            print(" ambos são iguais");
        }
        else
        {
            print(" são numeros diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
