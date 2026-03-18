using UnityEngine;

public class desafodejogo : MonoBehaviour
{
    int jogDois;
    int jogUm;
    int dadoum;
    int dadodois;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            dadoum = Random.Range(1, 7);
            dadodois = Random.Range(1, 7);

            print("dado um  rodou :" + dadoum);
            print("dado dois  rodou: " + dadodois);

            if (dadoum > dadodois)
            {
                print("jogador um ganha um ponto");
                jogUm = jogUm + 1;
            }
            else if (dadodois > dadoum)
            {
                print("jogador dois ganha um ponto");
                jogDois = jogDois + 1;
            }
            else
            {
                print("ninguem ganhou");
            }

            if (jogUm >= 3)
            {
                print("jogador um ganhou com :" + jogUm + " pontos");

            }
            if (jogDois >= 3)
            {
                print("jogador dois ganhou com :" + jogDois + " pontos");
            }

        }
       
    }
}
