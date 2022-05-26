using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex-1;
        PlayerPrefs.SetInt("reachedLevel", nextLevel);
        SceneManager.LoadScene("LevelSelect");
        PlayerPrefs.SetInt("coin",PlayerPrefs.GetInt("coin")+Score.coinAmount);
    }
}
