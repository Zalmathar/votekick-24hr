using System;
using UnityEngine;

public class Player : MonoBehavior
{
    public int maxHealth = 10;
    public Text currentHealthLabel;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateGUI();
    }

    void UpdateGUI()
    {
        currenthHealthLabel.text = currentHealth.ToString();
    }

    public void AlterHealth(int damage)
    {
        currentHealth += damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateGUI();
    }
}