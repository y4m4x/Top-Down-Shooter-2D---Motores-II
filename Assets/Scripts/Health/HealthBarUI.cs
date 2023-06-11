using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForegroundImage;

    public void UpdateHealthBar(HealthBar healthBar)
    {
        _healthBarForegroundImage.fillAmount = healthBar.RemainingHealthPercentage;
    }
}
