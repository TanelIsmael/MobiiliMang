using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleison5 : MonoBehaviour
{

    public Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = PlayerPrefs.GetInt("Cherry") == 1;
        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }
    void ToggleValueChanged()
    {
        PlayerPrefs.SetInt("Cherry", toggle.isOn ? 1 : 0);
    }
}
