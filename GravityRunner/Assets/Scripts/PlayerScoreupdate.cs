using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerScoreupdate : MonoBehaviour
{
    private Text scoreBoard;
    private int score;
    void Awake()
    {
        score = 0;
        scoreBoard = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreBoard.text = "0";
    }
    public void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Coin")
        {
            target.gameObject.SetActive(false);
            score++;
            scoreBoard.text = score.ToString();
        }
        if (target.gameObject.tag == "Rocket")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            StartCoroutine(restartGame(Random.Range(1f, 2f)));
        }
    }

    
    IEnumerator restartGame(float time) {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
