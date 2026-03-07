using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager managerInstance { get; private set; }

    [Header("PANELS")]
    [SerializeField] public GameObject Defeat_UI;
    [SerializeField] public GameObject Victory_UI;

    void Awake()
    {
        VerifyExistance();
    }

    void VerifyExistance()
    {
        if (managerInstance == null)
        {
            managerInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void activatePanel(GameObject panel)
    {
        panel.SetActive(true);
        PauseTime();
    }

    void PauseTime()
    {
        Time.timeScale = 0f;
    }
}
