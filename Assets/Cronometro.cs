using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public float cronometro = 0;

    // Use this for initialization
    void Start()
    {
        cronometro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Atualiza o cronometro até que todas as garrafas sejam atingidas
        cronometro += Time.deltaTime;

        // Verifica se destruiu todas as garrafas
        if (Controle.garrafasAtingidas != 15)
        {
            // Exibe o valor atual do cronometro
            this.GetComponent<Text>().text = cronometro.ToString("f0");
        }
    }
}
