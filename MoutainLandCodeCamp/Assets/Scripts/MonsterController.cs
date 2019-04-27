using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float speed;
    private GameObject player;
    private GameObject Monster;

    private Rigidbody2D rb;

    private Collider2D cl;

    private Vector2 moveVelocity;

    void Start()
    {
        cl = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        Monster = FindObjectOfType<MonsterController>().gameObject;
        player = FindObjectOfType<PlayerController>().gameObject;       
        StartCoroutine(EnemyUpdate());
    }
    
    IEnumerator EnemyUpdate()
    {
        while (true)
        {
            Vector2 playerPosition = player.transform.position;
            Vector2 monsterPosition = Monster.transform.position;
            var distance = Vector2.Distance(playerPosition, monsterPosition);
            if (distance > 2)
            {
                Vector2 moveInput = new Vector2(Random.Range(-1,2), Random.Range(-1,2));
                moveVelocity = moveInput.normalized * speed; 
                rb.velocity = moveVelocity;
                yield return new WaitForSeconds(1);           
            }
            else if (distance < 2)
            {
                rb.transform.position = Vector2.MoveTowards(rb.transform.position, playerPosition, 2);
            }   
        }
    }
}