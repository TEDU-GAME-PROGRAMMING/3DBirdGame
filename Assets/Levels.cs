using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] string _nextLevelIndex;
    private Monster[] _monsters;

    private void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
    }
    void Update()
    {
        foreach (Monster monster in _monsters)
        {
            if (monster != null)
                return;

        }
        Debug.Log("You killed all of them !!!" + _nextLevelIndex);
        SceneManager.LoadScene(_nextLevelIndex);
    }
}

