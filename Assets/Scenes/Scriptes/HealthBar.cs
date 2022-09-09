using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private float _healthCount;
    [SerializeField] private float _maxHealth;


    private void Update()
    {
        _healthBar.fillAmount = Mathf.Lerp(_healthBar.fillAmount, _healthCount / _maxHealth, Time.deltaTime * 3);
    }

    public void TakeHit(float damage)
    {
        _healthCount -= damage;

        if (_healthCount < 0)
            _healthCount = 0;
    }

    public void TakeHeal (float heal)
    {
        _healthCount += heal;

        if (_healthCount > _maxHealth)
            _healthCount = _maxHealth;
    }
}
