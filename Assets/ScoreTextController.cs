using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    public Text ScoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();
    }
    void OnCollisionEnter(Collision collision)
    {
        string myTag = collision.gameObject.tag;
        if (myTag == "SmallStarTag")
        {
            score += 10;
        }else if (myTag == "LargeStarTag")
        {
            score += 20;
        }else if (myTag == "SmallCloudTag")
        {
            score += 50;
        }else if (myTag == "LargeCloudTag")
        {
            score += 100;
        }
        SetScore();
    }
    void SetScore()
    {
        ScoreText.text = string.Format("Score:{0}", score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
