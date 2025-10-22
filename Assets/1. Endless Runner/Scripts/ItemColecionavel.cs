using UnityEngine;

public class ItemColecionavel : MonoBehaviour
{
    public string nomeItem = "Moeda";
    public int valor = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bateu");
            // Adiciona moedas ao gerenciador
            CoinManager.instance.AdicionarMoeda(valor);

            // Log opcional
            Debug.Log($"{valor} moeda(s) coletada(s)!");

            // Destroi o objeto
            Destroy(gameObject);
        }
    }
}
