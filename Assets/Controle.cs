using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
    public GameObject explosao;
    public GameObject gameCamera;
    public static int garrafasAtingidas = 0;

    // Use this for initialization
    void Start()
    {
        garrafasAtingidas = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Método responsável pelo Botão Atirar 
    public void Atirar()
    {
        RaycastHit raycastHit;

        // Verifica todos os objetos que estão no raio de direção da câmera	
        if (Physics.Raycast(gameCamera.transform.position, gameCamera.transform.forward, out raycastHit))
        {
            // Se existir algum objeto com o nome Garrafa, ele é destruido
            if (raycastHit.transform.name == "Garrafa")
            {
                Destroy(raycastHit.transform.gameObject);

                // Adiciona o efeito de explosão após destruir o objeto
                GameObject gameObject = Instantiate(explosao, raycastHit.point, Quaternion.LookRotation(raycastHit.normal));

                // Salva o total de garrafas atingidas
                garrafasAtingidas = garrafasAtingidas + 1;
            }
        }
    }

    // Método responsável pelo Botão Reiniciar
    public void Reiniciar()
    {
        // Reinicia a cena que está ativa
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Método responsável pelo Botão Sair
    public void Sair()
    {
        // Fecha o aplicativo
        Application.Quit();
    }
}
