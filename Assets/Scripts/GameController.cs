using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //The [] tells Unity that we want an Array
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //The first object will spawn after
    //the spawnDelay and then every spawnTime
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 5;
    [Header("Default Spawn Time")]
    public float spawnTime = 6;

    [Header("Game Over UI Canvas")]
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        //Get a random number between the range of 0 and our
        //array length
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //spawn new hexagon that was picked randomly
        Instantiate(shapePrefabs[randomInt], Vector3.zero,Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke("Spawn");
        //Set the gameOverCanvas to be visible
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

   
}
