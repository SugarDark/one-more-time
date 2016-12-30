using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class drop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public Rigidbody Body;
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.A))
        {
            Body.velocity = new Vector3(-10 ,0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Body.velocity = new Vector3(10, 0, 0);
        }
        else
        {
            Body.velocity = new Vector3(0, -20, 0);
        }
    }
}
