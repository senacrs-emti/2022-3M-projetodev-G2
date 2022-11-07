using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour{
    [SerializeField] float speed;
    GameObject Player;


    void Start(){
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update(){
        if (Player != null){
            transform.position = Vector2.MoveTowdards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }

    }
}
