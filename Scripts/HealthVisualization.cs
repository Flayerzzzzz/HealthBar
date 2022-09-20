using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthVisualization : MonoBehaviour
{
    [SerializeField] private Image _healthBar;
    [SerializeField] private Health _health;

    private Coroutine _healthRender;

    private void Start()
    {
        _healthRender = StartCoroutine(HealthRender());
    }

    private void OnEnable()
    {
        _health._healthChanged += Render;
    }

    private void OnDisable()
    {
        _health._healthChanged -= Render;
    }

    private void Render()
    {
        if (_healthRender != null)
        {
            StopCoroutine(_healthRender);
            _healthRender = StartCoroutine(HealthRender());
        }
    }

    IEnumerator HealthRender()
    {
        while(true)
        {
            _healthBar.fillAmount = Mathf.MoveTowards(_healthBar.fillAmount, _health.HealthCount / _health.MaxHealth, Time.deltaTime);
            yield return null;
        }
    }
}

