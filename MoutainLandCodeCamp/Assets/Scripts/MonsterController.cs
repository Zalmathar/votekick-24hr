using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Collider2D cl;

    private Vector2 moveVelocity;

    void Start()
    {
        cl = GetComponent<Collider2D>();

        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(EnemyUpdate());
    }
    
    IEnumerator EnemyUpdate()
    {
        while (true)
        {
            Vector2 moveInput = new Vector2(Random.Range(-1,1), Random.Range(-1,1));
            moveVelocity = moveInput.normalized * speed;
            rb.velocity = moveVelocity;
            yield return new WaitForSeconds(5);
        }
    }
}