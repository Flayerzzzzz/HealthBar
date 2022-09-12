using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthCount;
    [SerializeField] private float _maxHealth;

    public float HealthCount => _healthCount;
    public float MaxHealth => _maxHealth;

    public void Damage(float damage)
    {
        _healthCount -= damage;
        _healthCount = Mathf.Clamp(_healthCount, 0, _maxHealth);
    }

    public void Heal (float heal)
    {
        _healthCount += heal;
        _healthCount = Mathf.Clamp(_healthCount, 0, _maxHealth);
    }
}
