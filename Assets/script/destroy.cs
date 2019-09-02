using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject effect;
    public GameObject mana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{ 
	      Destroy(transform.gameObject);
            GameObject tempseffect = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(tempseffect, 0.3f);
            GameObject tempMana = Instantiate(mana);
            tempMana.transform.parent = player.transform;
            tempMana.transform.localPosition = new Vector3(0f, 1.6f, 0f);
        }
	}
}
