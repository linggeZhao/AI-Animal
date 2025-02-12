using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public float jumpForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo))
            {
                NavMeshPath path = new NavMeshPath();
                if (navAgent.CalculatePath(hitInfo.point, path) && path.status == NavMeshPathStatus.PathComplete)
                {
                    navAgent.SetDestination(hitInfo.point);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    public void Jump()
    {
        if (navAgent.isOnNavMesh)
        {
            navAgent.enabled = false; 
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Invoke(nameof(EnableNavMesh), 1f); 
        }
    }

    private void EnableNavMesh()
    {
        navAgent.enabled = true; 
    }
}
