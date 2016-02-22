using UnityEngine;
using System.Collections;

public class bulletCreate : MonoBehaviour {

    public GameObject bullet;
    public Transform spawn;
    public float speed = 1000.0f;
    public float shotTime = 0.75f;
    GameObject X;
    GameObject Y;
    Vector3 force;

    float timer = -1.0f;
    void start()
    {
    }

    // Update is called once per frame(毎フレーム呼ばれる)
    void Update()
    {
        //Debug.Log(this.gameObject.transform.eulerAngles);

        if (timer >= 0.0f)
        {
            timer += Time.deltaTime;
        }
        if (timer > 1.0f)
        {
            timer = -1.0f;
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (timer == -1.0f)
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        GameObject obj = GameObject.Instantiate(bullet) as GameObject;
        obj.transform.position = spawn.position;
        
        obj.transform.eulerAngles = spawn.eulerAngles;
        force = this.gameObject.transform.forward * speed;
        timer = 0.0f;

        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.AddRelativeForce(0.0f, 0.0f, speed);
    }
}
