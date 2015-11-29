using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject player;
	public GameObject spheresHaz;
	public Canvas titleUI;


	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ToMainLevel()
	{

		Application.LoadLevel (1);
		titleUI.enabled = false;
	}
	

}
