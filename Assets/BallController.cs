using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    public int totalScore = 0;
    private float visibleposZ = -6.5f;
    private GameObject gameoverText;
	// Use this for initialization
	void Start () {
        this.gameoverText = GameObject.Find("GameOverText");
	}
	
	// Update is called once per frame
	void Update () {
	    if(this.transform.position.z < this.visibleposZ)
        {
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
        }
	}
}
