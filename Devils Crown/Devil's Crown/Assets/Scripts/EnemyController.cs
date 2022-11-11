using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour{
    [SerializeField] float Speed;
    GameObject Player; 

    void Start(){
        Player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update(){
        if (Player != null){
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }        
    }
}
