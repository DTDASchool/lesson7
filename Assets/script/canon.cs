using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject cible;
    public GameObject boulet;
    public GameObject spawn;
    public float power = 400f;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3 (cible.transform.position.x, 0f, cible.transform.position.z));
        transform.Rotate(new Vector3(0f, 90f, 0f));
        GameObject tempBoulet = Instantiate(boulet);
        tempBoulet.transform.parent = spawn.transform;
        tempBoulet.transform.localPosition = new Vector3(0f, 0f, 0f);
        tempBoulet.transform.GetComponent<Rigidbody>().AddForce(new Vector3(cible.transform.position.x*power, 0f, cible.transform.position.z*power));
    }
}
