using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    [SerializeField] int _maxHealth = 3;

    [SerializeField] TextMeshProUGUI _tmp;

    int _treasureCount;
    int _currentHealth;

    TankController _tankController;

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's Health: " + _currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("Player's Health: " + _currentHealth);
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void IncreaseTreasure(int amount)
    {
        _treasureCount += amount;
        _tmp.text = "Treasure: " + _treasureCount;
        Debug.Log("Player's Treasure: " + _treasureCount);
    }

    public void Kill()
    {
        gameObject.SetActive(false);
        //particles
        //sounds
    }

}
