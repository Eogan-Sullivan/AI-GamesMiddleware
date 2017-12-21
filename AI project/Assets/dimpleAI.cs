using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dimpleAI : MonoBehaviour {
    NavMeshAgent dimples;    public GameObject a;
    public Transform bruce;
    int starthealth, currenthealth;
	// Use this for initialization
	void Start () {
        dimples = GetComponent<NavMeshAgent>();
        starthealth = 100;
        currenthealth = starthealth;
	}
	
	// Update is called once per frame
	void Update () {
       a = GameObject.FindGameObjectWithTag("Bruce");
       bruce = a.transform;
       dimples.SetDestination(bruce.position);

        if(currenthealth == 0)
        {
            Destroy(this);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        currenthealth = currenthealth - 5;
    }
}
