using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSystem
{
    public int maxHealth = 10;
    public Text RealHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateGUI();
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