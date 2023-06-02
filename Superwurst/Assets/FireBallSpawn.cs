using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawn : MonoBehaviour
{
    [SerializeField]public new GameObject feuerball;
    public float MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFeuerball", 5f, 5f);
        
        feuerball.transform.position = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {    //Problem: Feuerball nimmt nur die Position von dem gennannten Vector2 ein d.h. er bewegt sich durch den Befehl nicht
        
        
    }
       
    public void SpawnFeuerball()
    {
        feuerball.SetActive(true);
        Instantiate(feuerball, transform.position, transform.rotation);
        
        
    }

	
}
