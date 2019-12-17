using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleison2 : MonoBehaviour
{

    public Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = PlayerPrefs.GetInt("Glacier") == 1;
        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }
    void ToggleValueChanged()
    {
        PlayerPrefs.SetInt("Glacier", toggle.isOn ? 1 : 0);
    }
}
