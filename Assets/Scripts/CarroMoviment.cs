using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarroMoviment : MonoBehaviour
{
    EntityStats entity_stats;

    float move_speed;

    // Start is called before the first frame update
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();
        move_speed = entity_stats.base_speed;

        Destroy(this.gameObject, 20);
    }

    // Update is called once per frame

    void Update()
    {
        MovimentCarro();
    }

    void MovimentCarro()
    {
        //Aqui verificamos se nosso gameObject tem a tag especifica, caso ele tenha,
        //ele faz uma lógica, caso contrario, ele faz outra 
        if(gameObject.tag == "carToRight")
        {
            //Pega o carro da esquerda e o movimenta para a direita, até a position definida
            //(no caso, a posição 12 do eixo X)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(10, transform.position.y, 0),
                move_speed * Time.deltaTime);
        }
        else
        {
            //Pega o carro da direita e o movimenta para a esquerda, até a position definida
            //(no caso, a posição -12 do eixo X)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-10, transform.position.y, 0),
                move_speed * Time.deltaTime);
        }
    }
}
