using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour {



    public Text score;
    public Text bestScore;
    public Text gold;
    public Image menuButton;
    public Image muteButton;
    public Image unMuteButton;
    public Image replayButton;
    public PlayerController playerController;
    public string scene;
    public Color colorToLoad = Color.white;
	// Use this for initialization
	void Start () {
        
        ScoreManager.Instance.Reset();
        muteButton.enabled = false;
        unMuteButton.enabled = false;
        replayButton.enabled = false;
        menuButton.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
        score.text = ScoreManager.Instance.Score.ToString();
        bestScore.text = ScoreManager.Instance.HighScore.ToString();
        gold.text = CoinManager.Instance.Coins.ToString();

        if (playerController.gameOver)
        {
            Invoke("EnableButton", 1.5f);
        }
	}


    public void SoundClick()
    {
        if (SoundManager.Instance.IsMuted())
        {
            unMuteButton.enabled = true;
            muteButton.enabled = false;
            SoundManager.Instance.ToggleMute();
        }
        else
        {
            unMuteButton.enabled = false;
            muteButton.enabled = true;
            SoundManager.Instance.ToggleMute();
        }
        SoundManager.Instance.PlaySound(SoundManager.Instance.hitButton);
    }

    public void ReplayButton()
    {
        SoundManager.Instance.PlaySound(SoundManager.Instance.hitButton);
        Initiate.Fade(SceneManager.GetActiveScene().name, colorToLoad, 4f);
        
    }

    public void MenuButton()
    {
        SoundManager.Instance.PlaySound(SoundManager.Instance.hitButton);
        Initiate.Fade(scene, colorToLoad, 2.0f);
    }
    void EnableButton()
    {
        menuButton.enabled = true;
        replayButton.enabled = true;
        if (SoundManager.Instance.IsMuted())
        {
            muteButton.enabled = true;
            unMuteButton.enabled = false;
        }
        else
        {
            muteButton.enabled = false;
            unMuteButton.enabled = true;
        }
    }
}
