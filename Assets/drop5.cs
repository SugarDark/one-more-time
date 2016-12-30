using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class drop5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public SceneManager button2;
    // Update is called once per frame
    void Update() { 
    
    }

public void LoadScene(int id)
{
    SceneManager.LoadScene(id, LoadSceneMode.Single);

}

}
