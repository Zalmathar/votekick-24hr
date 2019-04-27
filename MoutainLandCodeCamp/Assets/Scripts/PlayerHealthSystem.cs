using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public Text RealHealth;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateGUI();
    }

    void UpdateGUI()
    {
        RealHealth.text = currentHealth.ToString();
    }

    public void AlterHealth(int damage)
    {
        currentHealth += damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateGUI();
    }
}