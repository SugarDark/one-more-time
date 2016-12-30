using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class drop2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }
    public float GenerateFrequency = 1.0f;
    float LastTimeGenerate = 0.0f;

    public static int GeneratedStairCount = 0;
    public static int FloorCount = 0;
    public int n = 10;


    public float GenerateYPos = 18f;
    public Vector2 GenerateXRange = new Vector2(-17f, 17f);

    public GameObject StairPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= LastTimeGenerate + GenerateFrequency)
        {
            GenerateAStair();
            LastTimeGenerate = Time.time;
            GeneratedStairCount++;
            if (FloorCount % n == 0)
            {
                GenerateFrequency=GenerateFrequency - 0.1f;
                n = n + 10;
            }
            if (GeneratedStairCount > 25 )
            {
                Debug.Log("A player got fucked");

                GeneratedStairCount = 0;
                SceneManager.LoadScene(1);
                n = 10;
            }
        }
    }

    void GenerateAStair()
    {
        float PosX = Random.Range(GenerateXRange.x, GenerateXRange.y);
        Vector3 SpawnPos = new Vector3(PosX, GenerateYPos, -1.55f);
        Instantiate(StairPrefab, SpawnPos, Quaternion.identity);
        FloorCount++;



    }
}
