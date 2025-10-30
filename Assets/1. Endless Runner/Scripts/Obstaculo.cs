using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float velocidade = 0.6f;
    public float variacaoY;

    private void Awake()
    {
        // Varia��o na posi��o Y
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));

        // Rota��o inicial aleat�ria no eixo Z
        float rotacaoZ = Random.Range(0f, 180f);
        transform.rotation = Quaternion.Euler(0f, 0f, rotacaoZ);
    }

    void Update()
    {
        // Movimento para a esquerda
        transform.Translate(Vector3.left * velocidade * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destruir();
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
