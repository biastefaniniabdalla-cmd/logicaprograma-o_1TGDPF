using UnityEngine;

public class Ex21 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int enemip = 3;
        int enemiM = 2;
        int enemiG = 1;

        int enemxpp = 10;
        int enemixpm = 25;
        int enemixpg = 100;

        int personaXp = (enemip * enemxpp) + (enemiM * enemixpm) + (enemiG * enemixpg);
        print(" o xp do personagem final é igual a : " + personaXp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
