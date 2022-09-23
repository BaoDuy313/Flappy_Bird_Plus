using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject tapBtnUI;
    public GameObject winUI;

    public bool IsDead = false;
    public bool levelComplete = false;

    void Start()
    {
        IsDead = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead)
        {
            Invoke("GameOver", 0.5f);
            gameOverUI.SetActive(true);
        }
        if (levelComplete)
        {
            Invoke("CompleteLevel", 0.5f);
            winUI.SetActive(true);
        }
    }
    public void CompleteLevel()
    {
        tapBtnUI.SetActive(false);
        Time.timeScale = 0;
        FindObjectOfType<PlayMovement>().rb.isKinematic = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
       
        tapBtnUI.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
