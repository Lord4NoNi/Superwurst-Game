using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    //leben
    public Healtbar healthbar;
    public float maxHealth = 100f;
    public float currentHealth;
    public float damageCollision;
    public float damageFeuerball;

    [SerializeField] private GameObject[] retry = new GameObject[1];
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            retry[0].SetActive(true);

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
	{
        if(other.gameObject.tag == "Enemy")
		{
            

            if(!Input.GetKey(KeyCode.Mouse0))
			{
                currentHealth = currentHealth - damageCollision;
            }


		}

      

        if(other.gameObject.tag == "Feuerball")
		{
            currentHealth = currentHealth - damageFeuerball;
		}
	}
}
