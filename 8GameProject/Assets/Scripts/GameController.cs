using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public GameObject player;
	public GameObject finishPoint;
	public Text hud;
	public float time;
	public int score;
	public GameObject respawnPoint;



	// Use this for initialization
	void Start () 
	{

	}


	// Update is called once per frame
	void Update () 
	{
		time += Time.deltaTime;
		hud.text = "Time: " + (int)time + " Score: " + score;

	}

	public void Respawn()
	{
		player.gameObject.transform.position = respawnPoint.gameObject.transform.position;
	}

	public void AddPoints()
	{
		score ++;
	}

	public void EndGame()
	{
		Application.LoadLevel (2);
	}


	

}
