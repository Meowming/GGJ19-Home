using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCBehavior : MonoBehaviour
{
    private bool wannatalk = true;
    public TextMeshProUGUI textDisplay;
    public string[] lines;
    private int index = 0;
    private float typingSpeed = 0.005f;
    public GameObject diaBox;
    static public bool finished =false;

    private GameController gameController;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    IEnumerator Type()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&& wannatalk ==true)
        {
            StartCoroutine(Type());
            diaBox.SetActive(true);
            wannatalk = false;
            gameController.SetControl(false);
        }
      

    }

    
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            diaBox.SetActive(false);
            finished = true;
            gameController.SetControl(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (textDisplay.text == lines[index] && Input.GetKeyDown(KeyCode.Space))
        {
            NextLine();
        }
    }
}
