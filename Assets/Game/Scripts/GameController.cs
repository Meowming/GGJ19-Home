using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

    public class GameController : MonoBehaviour {

        public static GameController instance = null;
        private GameObject player;

        private int level = 0;
        private PlatformerCharacter2D playerScript;
        [SerializeField]private bool enableControl = true;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);

            player = GameObject.FindGameObjectWithTag("Player");

            if (player != null)
            {
                playerScript = player.GetComponent<PlatformerCharacter2D>();
            }
        }

        // Use this for initialization
        void Start() {
        }

        // Update is called once per frame
        void Update() {

            if (!enableControl)
            {
                playerScript.enableMovment = false;
            }
            else
            {
                playerScript.enableMovment = true;
            }

        if (playerScript.isDead)
            LoadDeadScene();
        }

    private void OnLevelWasLoaded(int level)
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LoadDeadScene()
    {
        SceneManager.LoadScene("Dead");
    }

    public void SetControl(bool control)
    {
        enableControl = control;
    }

    public GameObject GetPlayer()
    {
        return player;
    }
        /*
        void LoadCurrentScene()
        {
            SceneManager.LoadScene(string.Format("level{0}", level));
        }

        void LoadNextScene()
        {
            level++;
            SceneManager.LoadScene(string.Format("level{0}", level));
        }*/
    }
