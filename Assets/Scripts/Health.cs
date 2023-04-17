using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _damage=10;
    private int _recovery=10;
    private int _nowHealth;

     [SerializeField] private HealthBar healthBar=new HealthBar();

    private void Start()
    {
        _nowHealth = _maxHealth;
        healthBar.ChangeSlider(_nowHealth, _maxHealth);
    }

    public void Damage()
    {
        _nowHealth=Mathf.Clamp(_nowHealth -_damage, 0, _maxHealth);
        healthBar.ChangeSlider(_nowHealth, _maxHealth);
    }

    public void Recovery()
    {
        _nowHealth = Mathf.Clamp(_nowHealth + _recovery, 0, _maxHealth);
        healthBar.ChangeSlider(_nowHealth, _maxHealth);
    }
}
