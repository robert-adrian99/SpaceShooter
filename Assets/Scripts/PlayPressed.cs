using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayPressed : MonoBehaviour
{
    /// Action for PLAY button on Start Scene
    public void PressedPlay()
    {
        SceneManager.LoadScene("Level01");
    }
}
