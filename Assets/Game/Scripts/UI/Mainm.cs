using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainm : MonoBehaviour {
	private GameController gameController;

	void Awake()
	{
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
    // Use this for initialization
    public void Goback()
    {
            SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

	public void Reload()
	{
		SceneManager.LoadScene(gameController.activeSceneName);
	}
}
