using UnityEngine;

public class EX3 : MonoBehaviour
{

    int[] notas = new int [] {10, 4, 2, 9, 8, 6, 1, 0 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("notas dos alunos ");

        foreach (int n in notas)
        {
            print(n);
        }

        for (int i = 0; i < notas.Length ; i++)
        {
            if (notas[i] < 6)
            {
                print (notas[i]);
                print("---------------------");
                print ("aluno reprovou");
            }
            else if (notas[i] >= 6)
            {
                print (notas[i]);
                print("---------------------");
                print("o aluno esta aprovado");
            }
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
