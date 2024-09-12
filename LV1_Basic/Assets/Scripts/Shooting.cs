using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    float bulletSpeed = 1100;
    public Object bullet;
    AudioSource bulletAudio;
    // Start is called before the first frame update
    void Start()
    {
        bulletAudio = GetComponent<AudioSource>();
    }
    private void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 1f);
        bulletAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}
