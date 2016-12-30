using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class drop3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter(Collider EnterCollider)
    {
        if (EnterCollider.tag == "Player")
        {
            drop2.GeneratedStairCount = drop2.GeneratedStairCount - 1;
            Debug.Log("A player entered");
        }
        

    }
}
