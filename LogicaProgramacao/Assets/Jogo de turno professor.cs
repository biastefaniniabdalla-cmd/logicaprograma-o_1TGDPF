using UnityEngine;

public class Jogodeturnoprofessor : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private int jogadorVida;
    [SerializeField] private int jogadorAtaque;
    [SerializeField] private int jogadorDefesa;
    private int jogadorPontos;
    private bool jogadorChecarPontos;

    private int cpuVida;
    private int cpuAtaque;
    private int cpuDefesa;
    private int cpuPontos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ((jogadorVida + jogadorAtaque + jogadorDefesa) == 5)
        {
            jogadorChecarPontos = true;
        }

        cpuPontos = 5;
        cpuVida = Random.Range(1, cpuPontos + 1);

        if (cpuVida > 3)
        {
            cpuVida = 3;
        }
        cpuPontos = cpuPontos - cpuVida;
        if (cpuVida == 3)
        {


            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}

