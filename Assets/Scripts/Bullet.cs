using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocity;
    public float lifetime;
	float destroyTimer;
	
	public LayerMask hitDetection;
    RaycastHit rh;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float raycastLength = velocity * Time.deltaTime;
		if (Physics.Raycast(transform.position, transform.forward, out rh, raycastLength, hitDetection))
		{
			Destroy(gameObject);
		}
		else
		{
			//transform.Translate(transform.forward * raycastLength);
			transform.position += transform.forward * raycastLength;
		}
		
		destroyTimer += Time.deltaTime;
		if (destroyTimer >= lifetime)
		{
			Destroy(gameObject);
		}
    }
}
