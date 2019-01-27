using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Callingtrans : MonoBehaviour {

    // Use this for initialization
    Scene m_Scene;
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (m_Scene.name == "Tutorial")
            {
                SceneManager.LoadScene("calling cg");
                NPCBehavior.finished = false;
            }
            if (m_Scene.name == "calling cg")
            {
                SceneManager.LoadScene("transmit1");
                NPCBehavior.finished = false;
            }
            if (m_Scene.name == "transmit1")
            {
                SceneManager.LoadScene("electric");
                NPCBehavior.finished = false;
            }
            if (m_Scene.name == "endingcg")
            {
                SceneManager.LoadScene("Ending");
                NPCBehavior.finished = false;
            }
            if(m_Scene.name == "level4")
            {
                SceneManager.LoadScene("transbeforeend");
                NPCBehavior.finished = false;
            }

        }
    }
}
