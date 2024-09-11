using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class CollitionScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Detected" + collision.gameObject.name);
        }
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger detected");
        }
    }
}