using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ThemeSelecter1 : MonoBehaviour {

   
    public GameObject Theme1;
    private static int costs;
    [SerializeField]
    private Toggle click = null;    
    



    void Start ()
    {
        

        
        
        Theme1.transform.GetChild(1).gameObject.SetActive(PlayerPrefs.GetInt("Theme1.transform.GetChild(1).gameObject", 0) == 0);

    }

    public void UnlockScene()
    {

        
        
            costs = scenetoload.cost;

        if (CoinManager.Instance.Coins >= costs)
        {

            Theme1.transform.GetChild(1).gameObject.SetActive(false);
            PlayerPrefs.SetInt("Theme1.transform.GetChild(1).gameObject", 1);
        }

        



    }
   
}
