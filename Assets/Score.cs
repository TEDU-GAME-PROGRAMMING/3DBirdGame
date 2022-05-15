using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    Text scoreText;
    public static int coinAmount;

    // Update is called once per frame
    void Start()
    {
        coinAmount = 0;
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        scoreText.text = coinAmount.ToString();
    }

}

