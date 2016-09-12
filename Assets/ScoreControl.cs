using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour {

    // Use this for initialization
    private int score = 5;
    private int scoreTime = 0;
    public int totalScore;
    private GameObject scoreText;
    private GameObject totalScoreObject;
    void Start () {

        this.totalScoreObject = GameObject.Find("Ball");
        this.scoreText.GetComponent<Text>().text = "Score:" + this.totalScoreObject.GetComponent<BallController>().totalScore;

        this.scoreText = GameObject.Find("ScoreText");
        if (tag == "SmallStarTag")
        {
            this.score = 10;
        }
        else if (tag == "LargeStarTag")
        {
            this.score = 50;
        }
        else if (tag == "smallCloudtag")
        {
            this.score = 5;
        }
        else if (tag == "LargeCloudtag")
        {
            this.score = 25;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(this.scoreTime > 0)
        {
            this.totalScoreObject.GetComponent<BallController>().totalScore += this.score;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.totalScoreObject.GetComponent<BallController>().totalScore;
            this.scoreTime -= 1;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        this.scoreTime = 60;
    }
}
