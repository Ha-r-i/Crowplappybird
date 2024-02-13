using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverScreen;
    public AudioSource audio;
    public AudioClip fail;
    public AudioClip score;
    [ContextMenu("Increase Score")]
    public void addScore(int scoretoadd)
    {
       
        playerscore = playerscore + scoretoadd;
        scoretext.text = playerscore.ToString();
        audio.clip = score;
        audio.Play();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        audio.clip = fail;
        audio.Play();
        gameoverScreen.SetActive(true);
    }
}
