using UnityEngine;

public class EX4 : MonoBehaviour
{
    int[] contagem = new int[20];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int pares = 0;

        while (i <= 20) 
        { 
           print(i);
            i++;

            if (i % 3 == 0)
            {
                pares++;
            }
            print(i);
            i++;
        }
        print ("quantidade de pares: " + pares);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
