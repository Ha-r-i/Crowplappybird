using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2d;
    public float flapstrength=5;
    public LogicManagerscript logic;
    public bool birdIsalive = true;
    public AudioSource audio;
    public AudioClip jumpclip;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerscript>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&birdIsalive)
        {
            audio.clip = jumpclip;
            audio.Play();
            spawnpipe();
        }
    }
    void spawnpipe()
    {
        myrigidbody2d.velocity = Vector2.up * flapstrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdIsalive = false;
    }
}
