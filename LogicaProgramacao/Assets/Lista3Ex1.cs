using UnityEngine;

public class Lista3Ex1 : MonoBehaviour
{
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (num1 >= num2) 
        {
            print(num1 + " é maior que " + num2);
        }
        else
        {
            print(num2 + " é maior que " + num1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
