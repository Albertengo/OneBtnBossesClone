using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    #region code
    public void SetMaxHealth(float vidaMax)
    {
        slider.maxValue = vidaMax;
        slider.value = vidaMax;
    }
    public void SetHealth(float vida)
    {
        slider.value = vida;
    }
    public void startHealthBar(float vida)
    {
        SetMaxHealth(vida);
        SetHealth(vida);
    }
    #endregion
}
