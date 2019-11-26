using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bulletPrefab;
	public Transform muzzle;
	
	public float roundsPerMinute;
	float fireTimer;
	
	public float range;
	public LayerMask hitDetection;
	RaycastHit rh;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
		
		if (Physics.Raycast(transform.position, transform.forward, out rh, range, hitDetection))
		{
			if (rh.collider.gameObject.CompareTag("Shootable") && fireTimer >= 60 / roundsPerMinute)
			{
				
				fireTimer = 0;
				
				
				
				//Quaternion bulletDirection = Quaternion.LookRotation(rh.point - muzzle.position, Vector3.up);
				//GameObject bullet = Instantiate(bulletPrefab.gameObject, muzzle.position, bulletDirection);
				GameObject bullet = Instantiate(bulletPrefab.gameObject, muzzle.position, Quaternion.identity);
				bullet.transform.LookAt(rh.point);
				
			}
		}
    }
}
