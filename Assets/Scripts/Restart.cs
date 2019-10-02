using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restartScene()
    {
        //When the restart button is pressed, beginning scene will be loaded and the score counter will reset to 0
        SceneManager.LoadScene("SampleScene");
        ScoreCounter.scoreVal = 0;
    }
}
