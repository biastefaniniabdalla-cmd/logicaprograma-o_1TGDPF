using UnityEngine;

public class ExemploDeProva : MonoBehaviour
{
     private int tentativa;
    [SerializeField] private int nume;
    private int randon;

    void Start()
    {
        randon = Random.Range(0, 101);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {


            if (randon > nume)
            {
                print(" muito baixo");
                tentativa++;

            }
            if (randon < nume)
            {
                print("muito alto");
                tentativa++;
            }
            if (randon == nume)
            {
                print("você acertou!!!!  Numero de tentativas : " + tentativa);
            }
        }
    }
}
