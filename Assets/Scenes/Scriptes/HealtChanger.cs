using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtChanger : MonoBehaviour
{
    [SerializeField] private HealthBar _health;

    public void AddTenHealthPoints()
    {
        _health.TakeHeal(10);
    }

    public void DeleteTenHealthPoints()
    {
        _health.TakeHit(10);
    }
}
