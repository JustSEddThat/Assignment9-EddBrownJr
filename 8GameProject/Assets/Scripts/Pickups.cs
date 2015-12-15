using UnityEngine;
using System.Collections;

public class Pickups : MonoBehaviour 
{
	public GameController gameController;

	public void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag.Equals ("GamePlayers")) 
		{
			gameController.AddPoints();
			Destroy(this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
