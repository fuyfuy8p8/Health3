using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;

    public void ChangeSlider(int currentHealth,int maxHealth)
    {
        _healthBarSlider.value=currentHealth;
        _healthBarSlider.maxValue=maxHealth;
    }
}
