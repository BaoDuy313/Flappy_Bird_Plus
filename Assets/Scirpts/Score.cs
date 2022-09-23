using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public float scoreAmount;

    public float pointByCoin = 1;

    public float pointWin = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreAmount.ToString("F0");
        if (scoreAmount >= pointWin)
        {
            FindObjectOfType<GameManager>().levelComplete = true;
        }
        
    }
    public void GetCoin()
    {
        scoreAmount += pointByCoin;
    }
}
