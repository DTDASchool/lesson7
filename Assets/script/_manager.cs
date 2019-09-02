using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _manager : MonoBehaviour
{
	public GameObject player;
	public GameObject spawn;
	public int score;
	[HideInInspector]
	public int time;
	public float tempTime;
	public int timeMax;
	public int timeBonus;
	public int scoreBonus;
	public int scoreMax;
	
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(player, spawn.transform.position, Quaternion.identity);
		score= 0;
		time = timeMax;
    }

    // Update is called once per frame
    void Update()
    {
		if(tempTime < 1f)
		{
			tempTime += Time.deltaTime;
		}
		else 
		{
			time -= 1;
			tempTime = 0f;
		}
		
		displayScore();
    }
	
	public void displayScore()
	{
		GameObject.Find("score").GetComponent<Text>().text = score.ToString();
		GameObject.Find("TIme").GetComponent<Text>().text = time.ToString();
		
		if(score == scoreMax){
			SceneManager.LoadScene("scene2");
		}
		
		if(time <= 0){
			SceneManager.LoadScene("scene3over");
		}
	}
	
	
}
