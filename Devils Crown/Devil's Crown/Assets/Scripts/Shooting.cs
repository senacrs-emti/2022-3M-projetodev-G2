using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;   
    void Start(){
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
        
    }

    void Update(){
        
    }
}
