using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("Couldn't find the Game Controller!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundaries" || other.tag == "Asteroid")
        {
            return;
        }
        if (other.tag == "Player")
        {
            gameController.GameOver();
        }
        if (other.tag != "Player")
        {   
            gameController.AddScore();
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
