using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayPressed : MonoBehaviour
{
    public void PressedPlay()
    {
        SceneManager.LoadScene("Level01");
    }
}
