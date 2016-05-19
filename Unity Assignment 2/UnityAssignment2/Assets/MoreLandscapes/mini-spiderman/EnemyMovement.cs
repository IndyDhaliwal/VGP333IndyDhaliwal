using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	GameObject player;
	NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (nav.enabled == false)
			return;
		nav.SetDestination (player.transform.position);
	
	}
}
