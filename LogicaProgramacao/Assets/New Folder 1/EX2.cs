using UnityEngine;

public class EX2 : MonoBehaviour

{

    string[] nomes = new string[] { "jonas", "airton", "Ian" ,"sena", "fabio" };
    
    void Start()
    {
        print("nomes escolhidos ");
        foreach (string n in nomes)
        {
        
           print(n);
          
        }

        print(" nomes em caixa alta");
        
        foreach (string n in nomes)
        {

            print(n.ToUpper());
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
