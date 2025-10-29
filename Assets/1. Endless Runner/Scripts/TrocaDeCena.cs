using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeCena : MonoBehaviour
{
    // M�todo que ser� chamado pelo bot�o
    public void CarregarCena(string Plataforma)
    {
        SceneManager.LoadScene(Plataforma);
    }

    // Se quiser tamb�m um bot�o para sair do jogo:
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
