using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public float lives = 3;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI livesText;
    public GameObject winTextObject;
    public GameObject loseTextObject;

    private Rigidbody rb;
    private int count;
    private float levelTimer = 0.0f;
    private float endTimer = 0.0f;
    private float endTimerMax = 3.0f;
    private float movementX;
    private float movementY;
    private bool death = false;
    private bool endLevel;
    private bool timerRunning = true;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        ApplicationData.coinCount = 0;

        SetCountText();
        SetLivesText();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
    }

    void Update()
    {
        if (timerRunning)
        {
            levelTimer += Time.deltaTime;
            SetTimerText();
        }
        
        if (death)
        {
            endLevel = true;
            loseTextObject.SetActive(true);
        }

        if (endLevel)
        {
            timerRunning = false;
            endTimer += Time.deltaTime;
            speed = 0;
        }

        if (endTimer >= endTimerMax)
        {
            endLevel = false;
            SceneManager.LoadScene("LevelSelection");
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    void SetTimerText()
    {
        timerText.text = "Time: " + levelTimer.ToString("F2");
    }

    void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    void FixedUpdate()
    {

        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndLevel")
        {
            endLevel = true;

            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("PickUp");

            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }

            winTextObject.SetActive(true);
            ApplicationData.coinCount = count;
            ApplicationData.totalCoinCount += count;
            ApplicationData.levelTime = levelTimer;
        }

        if (other.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

        if(other.tag == "Spike")
        {
            lives--;
            SetLivesText();

            if (lives <= 0)
            {
                death = true;
            }
        }
    }

}