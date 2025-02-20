using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.ProBuilder.Shapes;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    private bool found = false;


    // Update is called once per frame
  void Update()
    {
        if (found)
        {
            Vector3 directionToTarget = target.position - this.transform.position;
            this.transform.Translate(directionToTarget.normalized * Time.deltaTime * 2); // Move toward target
            Debug.DrawRay(this.transform.position, directionToTarget, Color.green);
            Debug.Log("Follow");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            found = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        found = false;
    }
}

