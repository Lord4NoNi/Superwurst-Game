using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject[] movement = new GameObject[1];
    // Start is called before the first frame update
    void Start()
    {
        movement[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
