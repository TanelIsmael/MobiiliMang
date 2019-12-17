using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleison1 : MonoBehaviour
{

    public Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = PlayerPrefs.GetInt("Spooky") == 1;
        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }
    void ToggleValueChanged()
    {
        PlayerPrefs.SetInt("Spooky", toggle.isOn ? 1 : 0);
    }
}
