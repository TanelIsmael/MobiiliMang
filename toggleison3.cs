using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleison3 : MonoBehaviour
{

    public Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = PlayerPrefs.GetInt("Main") == 1;
        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }
    void ToggleValueChanged()
    {
        PlayerPrefs.SetInt("Main", toggle.isOn ? 1 : 0);
    }
}
