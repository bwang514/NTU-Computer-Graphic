using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{
	Transform player;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	
	
	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{
		// If the enemy and the player have health left...
			nav.SetDestination (player.position);
	} 
}