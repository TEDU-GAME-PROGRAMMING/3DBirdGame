using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] LevelButtons;
    void Start()
    {
        foreach (Button b in LevelButtons)
            b.interactable = false;

        int reachedLevel = PlayerPrefs.GetInt("reachedLevel", 1);

        for (int i = 0; i < reachedLevel; i++)
            LevelButtons[i].interactable = true;
    }

    public void LoadScene(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }


}
