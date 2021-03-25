using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public string MoreGamesURL;
    public string RateUsURL;
    public Text Level;
    int LevelNum;
    // Start is called before the first frame update
    void Start()
    {
        LevelNum = PlayerPrefs.GetInt("Level", 1);
        Level.text = "Level " + LevelNum;
    }

    public void StartGame() {

        SceneManager.LoadScene(LevelNum);
    }

    public void QuitGame (){
        Application.Quit();
    }

    public void MoreGames() {
        Application.OpenURL(MoreGamesURL);
    }

    public void RateUs() {
        Application.OpenURL(RateUsURL);
    }

    
}
