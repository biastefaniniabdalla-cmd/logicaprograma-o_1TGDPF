using UnityEngine;

public class Ex12 : MonoBehaviour
{
    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;
    void Start()
    {
        print("pontos:" + pontosBase);
        print("inimigos derrotados :" + inimigosDerrotados);
        print("bonus: " + bonus);
        int pontuacaoFinal = (pontosBase * inimigosDerrotados ) + bonus;
        print("pontuação final :" + pontuacaoFinal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
