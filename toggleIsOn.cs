using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toggleIsOn : MonoBehaviour {

    public Toggle togggle;

    void Awake()
    {

        if (PlayerPrefs.GetInt("togggle.GetComponent<Toggle>()", 1) == 1)
        {
            togggle.GetComponent<Toggle>().isOn = true;
        }
        
            
        
    }

    public void ChangeValue()
    {

        if (togggle.GetComponent<Toggle>().isOn == false)
        {
            PlayerPrefs.SetInt("togggle.GetComponent<Toggle>()", 0);
        }
        else if (togggle.GetComponent<Toggle>().isOn == true)
        {
            PlayerPrefs.SetInt("togggle.GetComponent<Toggle>()", 1);
        }
    }
    

   
    

    
}
