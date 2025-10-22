using UnityEngine;
using TMPro; 

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int moedas = 0;

    [Header("Referência ao texto da UI")]
    public TMP_Text TextoMoedas; 

    private void Awake()
    {
        
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        AtualizarHUD();
    }

    public void AdicionarMoeda(int quantidade)
    {
        moedas += quantidade;
        AtualizarHUD();
    }

    void AtualizarHUD()
    {
        TextoMoedas.text = "Moedas: " + moedas;
    }
}
    