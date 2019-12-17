using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ThemeSelecter : MonoBehaviour {

    public static ThemeSelecter Instance;
	public GameObject Theme;
    private static int costs;
    [SerializeField]
    private Toggle click = null;


    
    void Awake ()
    {



        Theme.transform.GetChild(1).gameObject.SetActive(PlayerPrefs.GetInt("Theme.transform.GetChild(1).gameObject", 0) == 0);
       



    }

  

    public void UnlockScene()
    {

        
        
            costs = scenetoload.cost;

        if (CoinManager.Instance.Coins >= costs)
        {
            Theme.transform.GetChild(1).gameObject.SetActive(false);
            PlayerPrefs.SetInt("Theme.transform.GetChild(1).gameObject", 1);

         
        }

        
       
    }

}
