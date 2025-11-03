using System;
using UnityEngine;

public class jogador : personagem
{

    void Start()
    {

    }

    void update()
    {
        if (Input.GetKeyDown(KeyCode.A)) // esquerda
        {
            transform.position -= new Vector3(getvelocidade()*Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D)) //direita
        {
            transform.position += new Vector3(getvelocidade()*Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W)) // cima
        {
            transform.position += new Vector3(0, getvelocidade()*Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.S)) // baixo
        {
            transform.position -= new Vector3(getvelocidade()*Time.deltaTime, 0, 0);
        }
    }
}
