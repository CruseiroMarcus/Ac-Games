using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeCena : MonoBehaviour
{
    // Método que será chamado pelo botão
    public void CarregarCena(string Plataforma)
    {
        SceneManager.LoadScene(Plataforma);
    }

    // Se quiser também um botão para sair do jogo:
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
