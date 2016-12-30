using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class drop4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public SceneManager button;
	// Update is called once per frame
	void Update () {
	 //   if(button)
	}

    public void LoadScene(int id)
    {
        SceneManager.LoadScene(id, LoadSceneMode.Single);

    }
}
