using UnityEngine;

public class Ex23 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    int manaInicial = 100;
        int manaUsada = 30 + 20 + 25;
        print("mana restante: " + (manaInicial - manaUsada));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
