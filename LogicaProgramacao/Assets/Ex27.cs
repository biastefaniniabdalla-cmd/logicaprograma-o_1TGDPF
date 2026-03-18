using UnityEngine;

public class Ex27 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vidaPersona = 150;
        int danos = 20 + 35 + 15;
        print("vida restante : " + (vidaPersona - danos));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
