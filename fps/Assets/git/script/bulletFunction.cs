using UnityEngine;
using System.Collections;

public class bulletFunction : MonoBehaviour {
    public float speed = 1000;
	// Use this for initialization
	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
       // rb.AddRelativeForce(0.0f, 0.0f, speed);
	}
	
	// Update is called once per frame
	void Update () {

        
	}

    void OnCollisionEnter(Collision c)
    {
       
            Destroy(this.gameObject);
      
    }
}
