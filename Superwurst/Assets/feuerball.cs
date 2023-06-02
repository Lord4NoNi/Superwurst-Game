using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feuerball : MonoBehaviour
{

    [SerializeField] public new GameObject fireball;
    public float MovementSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireball.transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(fireball);
            

        }
    }
}
