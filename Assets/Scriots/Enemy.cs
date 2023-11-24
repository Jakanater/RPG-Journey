using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Sword")
        {
            Debug.Log("Collision");
            Sword sword = collision.gameObject.GetComponent<Sword>();
            if(sword != null)
            {
                health -= sword.swordDamage;
                Debug.Log(health);
                if(health <= 0)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
