using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MonsterController : MonoBehaviour
{
    public int maxHealth = 10;
    public Text RealHealth;
    private int currentHealth;
    public float speed;
    private GameObject Monster;

    private Rigidbody2D rb;

    private Collider2D cl;

    private Vector2 moveVelocity;

    private void Start()
    {
        cl = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        Monster = FindObjectOfType<MonsterController>().gameObject;     
        StartCoroutine(EnemyUpdate());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AlterHealth(3);
        }
    }

    
    IEnumerator EnemyUpdate()
    {
        while (true)
        {
            Vector2 moveInput = new Vector2(Random.Range(-1,2), Random.Range(-1,2));
            moveVelocity = moveInput.normalized * speed; 
            rb.velocity = moveVelocity;
            yield return new WaitForSeconds(1);
        }
    }

    private void UpdateGUI()
    {
        RealHealth.text = currentHealth.ToString() + "/" + maxHealth.ToString();
    }

    public void AlterHealth(int damage)
    {
        currentHealth += damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateGUI();
    }
}