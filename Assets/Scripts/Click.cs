using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI Score;
    [SerializeField] Text Score;
    //[SerializeField] TextMeshProUGUI Death;
    [SerializeField] GameObject square;
    [SerializeField] GameObject circle;
    [SerializeField] GameObject triangle;
    [SerializeField] GameObject skull0;
    [SerializeField] GameObject skull1;
    [SerializeField] GameObject skull2;
    [SerializeField] GameObject gameOverText;
    private static float squareTime;
    private static float circleTime;
    private static float triangleTime;
    Rigidbody2D rbS;
    Rigidbody2D rbC;
    Rigidbody2D rbT;
    private float randX;
    private float randY;
    private static int skulls;
    [SerializeField] int score;


    void Start()
    {
        rbS = square.GetComponent<Rigidbody2D>();
        rbC = circle.GetComponent<Rigidbody2D>();
        rbT = triangle.GetComponent<Rigidbody2D>();
        randX = Random.value * 20;
        randY = Random.value * 20;
        skulls = 0;
        score = 0;
        skull0.SetActive(false);
        skull1.SetActive(false);
        skull2.SetActive(false);
        gameOverText.SetActive(false);
    }

    void Update()
    {
        Score.text = "Score:" + score;

        if (skulls == 1)
        {
            skull0.SetActive(true);
        }
        if (skulls == 2)
        {
            skull1.SetActive(true);
        }
        if (skulls == 3)
        {
            skull2.SetActive(true);
        }
        if (skulls <= 3)
        {

            squareTime += Time.deltaTime;
            circleTime += Time.deltaTime;
            triangleTime += Time.deltaTime;
            

            if (squareTime > 3f)
            {
                squareTime = 0;
                float xrandom = Random.Range(-10f, 10f);
                float yrandom = Random.Range(5f, -5);

                square.transform.position = new Vector3(xrandom, yrandom, 0);


                skulls++;

            }

            if (circleTime > 2.5f)
            {
                circleTime = 0;
                float xrandom = Random.Range(-10f, 10f);
                float yrandom = Random.Range(5f, -5);

                circle.transform.position = new Vector3(xrandom, yrandom, 0);
                skulls++;
            }

            if (triangleTime > 2f)
            {
                triangleTime = 0;
                float xrandom = Random.Range(-10f, 10f);
                float yrandom = Random.Range(5f, -5);

                triangle.transform.position = new Vector3(xrandom, yrandom, 0);

                skulls++;
            }
        }
        else
        {
            gameOverText.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Start();
            // skulls = 0;
            // skull0.SetActive(false);
            // skull1.SetActive(false);
            // skull2.SetActive(false);
            // score = 0;
        }

    }

    public void squareClicked()
    {
        if (skulls <= 3)
        {
            squareTime = 0;
            float xrandom = Random.Range(-10f, 10f);
            float yrandom = Random.Range(5f, -5);

            square.transform.position = new Vector3(xrandom, yrandom, 0);
            score += 1;

        }
    }

    public void circleClicked()
    {
        if(skulls <= 3)
        {

            circleTime = 0;
            float xrandom = Random.Range(-10f, 10f);
            float yrandom = Random.Range(5f, -5);

            circle.transform.position = new Vector3(xrandom, yrandom, 0);
            score += 3;
        }
    }

    public void triangleClicked()
    {
        if(skulls<=3)
        {
            triangleTime = 0;
            float xrandom = Random.Range(-10f, 10f);
            float yrandom = Random.Range(5f, -5);

            triangle.transform.position = new Vector3(xrandom, yrandom, 0);
            score += 5;
        }
    }
            

}