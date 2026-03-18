using UnityEngine;

public class Lista3Ex2 : MonoBehaviour
{
    [SerializeField] private int idade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (idade >= 18){
            print("é maior de idade");

        }
        else
        {
            print("é menor de idade");
        }
        
           
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
