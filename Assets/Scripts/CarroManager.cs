using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroManager : MonoBehaviour
{

    public GameObject carro_;

    float cooldown = 0.5f;

    // Update is called once per frame
    void Update()
    {
        SpawnCarroCooldown();
    }

    void SpawnCarro()
    {
        //Definimos uma tag para cada carro instanciado, para que pudessmos manipular livremente cada
        //um atraves do script MovimentCarro.cs
        Instantiate(carro_, new Vector3(10, -2.4f, 0), Quaternion.identity).gameObject.tag = "carToLeft";
        Instantiate(carro_, new Vector3(10, 0.2419999f, 0), Quaternion.identity).gameObject.tag = "carToLeft";
        Instantiate(carro_, new Vector3(-10f, -1.11f, 0), Quaternion.identity).gameObject.tag = "carToRight";
        Instantiate(carro_, new Vector3(-10f, 1.599507f, 0), Quaternion.identity).gameObject.tag = "carToRight";
    }

    void SpawnCarroCooldown()
    {
        if(cooldown <= 0)
        {
            //Faz uma a��o e reseta o cooldown
            SpawnCarro();
            cooldown = 5;
        }
        else
        {
            //Caso seja maior que 0, ele diminui o cooldown at� q seja 0
            cooldown -= Time.deltaTime;
        }
    }
}
