using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject asteroid;
    public Vector3 spawnValues;

    public float waitSecondsForNewSpawn;

    public Text scoreText;
    public static int score;

    private bool isGameOver;

    void Start()
    {
        if (asteroid != null)
        {
            isGameOver = false;
            score = 0;
            UpdateScore();
            StartCoroutine(SpawnAsteroids());
        }
        else
        {
            isGameOver = true;
            scoreText.text += GameController.score;
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Socre: " + score;
    }

    void Update()
    {
        if (isGameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level01");
            }
        }
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(asteroid, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(waitSecondsForNewSpawn);
        }
    }

    public void AddScore()
    {
        score += 1;
        UpdateScore();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
