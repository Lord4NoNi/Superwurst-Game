using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grill : MonoBehaviour
{

    public float GrillHealth;
    public float GrillCurrentHealth;
    [SerializeField]private GameObject[] grill = new GameObject[1];
    // Start is called before the first frame update
    void Start()
    {
        GrillCurrentHealth = GrillHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(GrillCurrentHealth == 0f)
		{
            grill[0].SetActive(false);
		}
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.Mouse0)) //&& Input.GetMouseButton(0)
        {
            GrillCurrentHealth = GrillCurrentHealth - 1f;
        }
    }
}
