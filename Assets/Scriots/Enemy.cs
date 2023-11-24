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

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Sword")
        {
            Sword sword = gameObject.GetComponent<Sword>();
            if(sword != null){
                health -= sword.swordDamage;
                if(health <= 0){
                    this.gameObject.IsDestroyed();
                }
            }
        }
    }
}
