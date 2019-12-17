using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ThemeSelecter2 : MonoBehaviour {

    
	public GameObject Theme2;
    private static int costs;
    [SerializeField]
    private Toggle click = null;
    
    



    void Start ()
    {


        
           
        Theme2.transform.GetChild(1).gameObject.SetActive(PlayerPrefs.GetInt("Theme2.transform.GetChild(1).gameObject", 0) == 0);

    }

    public void UnlockScene()
    {

        
        
            costs = scenetoload.cost;

        if (CoinManager.Instance.Coins >= costs)
        {
            
            
            Theme2.transform.GetChild(1).gameObject.SetActive(false);
            PlayerPrefs.SetInt("Theme2.transform.GetChild(1).gameObject", 1);
            
        }






    }
   

}
