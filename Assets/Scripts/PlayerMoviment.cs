using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    EntityStats entity_stats;
    public GameObject game_over;

    float move_speed;

    // Start is called before the first frame update
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();
        move_speed = entity_stats.base_speed;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentPlayer();
    }

    void MovimentPlayer()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontal * move_speed * Time.deltaTime,
            vertical * move_speed * Time.deltaTime));

        if((horizontal > 0 || horizontal < 0) && (vertical > 0 || vertical < 0))
        {
            move_speed = 0;
        }
        else
        {
            move_speed = entity_stats.base_speed;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "carToRight" || collision.gameObject.tag == "carToLeft")
        {
            Destroy(this.gameObject);
            this.enabled = false;
            game_over.SetActive(true);
        }
    }
}
