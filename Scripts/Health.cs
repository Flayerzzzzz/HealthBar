using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthCount;
    [SerializeField] private float _maxHealth;

    public event UnityAction _healthChanged;

    public float HealthCount => _healthCount;
    public float MaxHealth => _maxHealth;

    public void Damage(float damage)
    {
        _healthCount -= damage;
        _healthCount = Mathf.Clamp(_healthCount, 0, _maxHealth);
        _healthChanged?.Invoke();
    }

    public void Heal (float heal)
    {
        _healthCount += heal;
        _healthCount = Mathf.Clamp(_healthCount, 0, _maxHealth);
        _healthChanged?.Invoke();
    }
}
