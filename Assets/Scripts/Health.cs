using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _healthObj=100;
    private int _maxHealth=100;
    public HealthBar HealthBar;

    public void TakeHit(int damage)
    {
        _healthObj -= damage;
        HealthBar.GetHealth(_healthObj);
        if (_healthObj <= 0)
        {
            HealthBar.GetHealth(1);
            Destroy(gameObject);
        }
    }
    public void SetHit(int bonushealth)
    {
        _healthObj += bonushealth;
        HealthBar.GetHealth(_healthObj);
        if (_healthObj > _maxHealth)
        {
            _healthObj = _maxHealth;
        }
    }

}