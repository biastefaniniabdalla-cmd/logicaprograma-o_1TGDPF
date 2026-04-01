using UnityEngine;

public class JogoDeTurno : MonoBehaviour
{
    [SerializeField] public int VidaJogador;
    [SerializeField] public int DefesaJogador;
    [SerializeField] public int AtaqueJogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int VidaCPU = 1;
        int DefesaCPU = 1;
        int AtaqueCPU = 1;
        int destribuicaoV;
        int destribuicaoD;
        int destribuicaoA;

        destribuicaoV = Random.Range(0, 3);

        VidaCPU += destribuicaoV;
        if (VidaCPU < 3)
        {
            if (VidaCPU == 2)
            {
                destribuicaoD = Random.Range(0, 2);
                DefesaCPU += destribuicaoD;
                if (DefesaCPU == 1)
                {
                    destribuicaoA = Random.Range(0, 2);
                    AtaqueCPU += destribuicaoA;
                }
            }
            if (VidaCPU == 1)
                {
                    destribuicaoD = Random.Range(0, 3);
                    DefesaCPU += destribuicaoD;
                }
                if (DefesaCPU == 2)
                {
                    destribuicaoA = Random.Range(0, 2);
                    AtaqueCPU += destribuicaoA;
                    
                }
                if (DefesaCPU == 1)
                {
                    destribuicaoA = Random.Range(0, 3);
                    AtaqueCPU += destribuicaoA;
                }

                print (" vida " + VidaCPU + " defesa " + DefesaCPU + " ataque" + AtaqueCPU);
            // Update is called once per frame
            void Update()
                {

                }
            }
        }
    }


  

