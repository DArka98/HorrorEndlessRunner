using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float speedMaxLimit = 18.0f;
    public float strafeSpeed = 3.0f;
    public float jumpSpeed = 2.0f;

    public int position = 0;

    Vector3 curPosition;

    public GameManager gameManager;
    public GameObject gameOverUI;
    public GameObject gameHUDUI;

    void Start()
    {
        Time.timeScale = 1.0f;
        gameOverUI.SetActive(false);
        gameHUDUI.SetActive(true);
    }

    void Update()
    {
        if(gameManager.gameOver == false)
        {
            gameManager.ScoreIncrease();
            if(moveSpeed <= speedMaxLimit)
            {
                moveSpeed += 0.001f;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            curPosition = transform.localPosition;

            if (Input.GetKeyDown(KeyCode.A) && position != 1)
            {
                position += 1;
                transform.Translate(Vector3.left * strafeSpeed);
            }
            if (Input.GetKeyDown(KeyCode.D) && position != -1)
            {
                position -= 1;
                transform.Translate(Vector3.right * strafeSpeed);
            }

            if (Input.GetKeyDown(KeyCode.W) && curPosition.y < 1)
            {
                transform.Translate(Vector3.up * jumpSpeed);
            }
        }
        else
        {
            Time.timeScale = 0;
            moveSpeed = 0.0f;
            gameHUDUI.SetActive(false);
            gameOverUI.SetActive(true);
            gameManager.DisplayFinalScore();
        }
    }
}
