using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public BoardManager boardManager;

	private int level = 3;

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		boardManager = GetComponent<BoardManager> ();
		InitGame ();
	}

	void InitGame() {
		boardManager.SetupScene (level);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
