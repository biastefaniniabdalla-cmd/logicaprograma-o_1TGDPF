using UnityEngine;

public class Lista3Ex3 : MonoBehaviour
{
    [SerializeField] private  int num ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ((num % 2)==0)
        {
            print(num + " É um numero par");
        }
        else
        {
            print(num + " É um numero impar");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
