using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public GameObject player;
	public int playerHealth = 4; 
	public GameObject finishPoint;
	public Slider healthBar;
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
	//Respawn when player dies. Gives back full health
	public void Respawn()
	{
		player.gameObject.transform.position = respawnPoint.gameObject.transform.position;
		playerHealth = 4;
		healthBar.value = playerHealth;
	}
	//when health is gone, respawn player, otherwise lower the slider(healthpoints)
	public void Damage()
	{
		if (playerHealth == 0)
			this.Respawn();
		else 
		{
			playerHealth--;
			healthBar.value = playerHealth;
		}
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
