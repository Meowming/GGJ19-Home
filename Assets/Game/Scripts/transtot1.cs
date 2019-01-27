using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transtot1 : MonoBehaviour {

    // Use this for initialization
    public GameObject image1;
    // Use this for initialization
    Scene m_Scene;
    private string names;
    private void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        if (m_Scene.name == "Tutorial")
        {
            names = "calling cg";
        }
        if (m_Scene.name == "calling cg")
        {
            names = "transmit1";
        }
        if (m_Scene.name == "transmit1")
        {
            names = "level2";
        }
        if (m_Scene.name == "transbeforeend")
        {
            names = "endingcg";
        }
        if (m_Scene.name == "endingcg")
        {
            names = "Ending";
        }

    }
   
    

    // Update is called once per frame
    void Update()
    {
        if (NPCBehavior.finished == true)
        {
            Debug.Log(m_Scene.name);
            Debug.Log( names);
            SceneManager.LoadScene(names);
            NPCBehavior.finished = false;
        }
    }
}
