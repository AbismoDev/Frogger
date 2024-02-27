using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroManager : MonoBehaviour
{

    public GameObject carro_;
    ScoreManager score_manager;

    float cooldown = 0.5f;

    private void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

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
            //Faz uma ação e reseta o cooldown
            SpawnCarro();
            cooldown = (5 - (score_manager.score / 10));
        }
        else
        {
            //Caso seja maior que 0, ele diminui o cooldown até q seja 0
            cooldown -= Time.deltaTime;
        }
    }
}
