using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
	public _manager manager;
    // Start is called before the first frame update
    void Start()
    {
       manager = GameObject.Find ("GOmanager").GetComponent<_manager>();	 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter (Collider other)
	{ 
		if(other.gameObject.tag == "Player")
		{
			manager.score +=  manager.scoreBonus;
			if(manager.time +manager.timeBonus <manager.timeMax){
				manager.time +=manager.timeBonus  ;
			}
			else {
				manager.time = manager.timeMax;
			}
			Debug.Log("touché");
		}
	}
}
