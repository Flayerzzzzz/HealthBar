using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthVisualization : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private Health _health;

    public void Render()
    {
        StartCoroutine(HealthRender());
    }

    IEnumerator HealthRender()
    {
        while(true)
        {
            _healthBar.fillAmount = Mathf.Lerp(_healthBar.fillAmount, _health.HealthCount / _health.MaxHealth, Time.deltaTime);
            yield return new WaitUntil(() => _healthBar.fillAmount != _health.HealthCount / _health.MaxHealth);
        }
    }
}

