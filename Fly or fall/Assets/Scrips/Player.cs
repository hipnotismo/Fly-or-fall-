using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour{

    private Vector2 targetPos ;
    public float yIncrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public Text healthDisplay;

    public void Start()
    {
        targetPos = new Vector2(-6,0);
    }

    private void Update() {

        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

     
    }

    public void UP()
    {

        if ( transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }
    }

    public void DOWN()
    {
        if ( transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);

        }
    }
}
