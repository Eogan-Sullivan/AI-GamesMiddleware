using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dimpleAI : MonoBehaviour {
    NavMeshAgent dimples;    public GameObject a;
    public Transform bruce;
	// Use this for initialization
	void Start () {
        dimples = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
       a = GameObject.FindGameObjectWithTag("Bruce");
       bruce = a.transform;
       dimples.SetDestination(bruce.position);
	}
}
