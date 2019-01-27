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
            }
            if (m_Scene.name == "calling cg")
            {
                SceneManager.LoadScene("transmit1");
            }
            if (m_Scene.name == "transmit1")
            {
                SceneManager.LoadScene("electric");
            }
            if (m_Scene.name == "endingcg")
            {
                SceneManager.LoadScene("Ending");
            }

        }
    }
}
