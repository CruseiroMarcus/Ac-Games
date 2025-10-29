using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    public float velocidade = 0.6f;   
    public float variacaoY = 1.0f;   

    private void Awake()
    {
      
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    void Update()
    {
      
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
