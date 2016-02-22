using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
public class fpsProperty : MonoBehaviour {
    public GameObject obj;
    public FirstPersonController fpc;
    MouseLook mouseLook;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        keyFunction();
        Debug.Log("hoge");
	}

    void keyFunction()
    {
        cameraMoveEnable();
    }

    void cameraMoveEnable()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
        }
    }
}
