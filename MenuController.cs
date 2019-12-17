using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {



    public Text gold;
   
	
	
	// Update is called once per frame
	void Update ()
    {
        
        gold.text = CoinManager.Instance.Coins.ToString();

     
	}

  
}
