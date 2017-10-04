using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;

	void Start () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
	}
	

	void Update () {
        targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        playerPos = new Vector3(-7, Mathf.Clamp(yPos, -4, 4), 0);
        gameObject.transform.position = new Vector3(7, playerPos.y,0); 
	}
}
