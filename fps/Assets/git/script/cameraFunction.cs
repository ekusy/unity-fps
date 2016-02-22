using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class cameraFunction : MonoBehaviour {
    Camera cam;
    [SerializeField] private MouseLook mouseLook;
	// Use this for initialization
	void Start () {
        cam = Camera.main;//GetComponent<Camera>();
        mouseLook.Init(transform, cam.transform);
	}
	
	// Update is called once per frame
	void Update () {
        RotateView();
        //mouseLook.UpdateCursorLock();
    }

    private void RotateView()
    {
        mouseLook.LookRotation(transform, cam.transform);
    }
}
