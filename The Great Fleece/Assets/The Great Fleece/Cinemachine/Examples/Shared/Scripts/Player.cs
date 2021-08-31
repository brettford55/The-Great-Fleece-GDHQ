using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    NavMeshAgent _agent;
    Animator _playerAnimator;
    Vector3 _hitpoint;
    
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _playerAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(rayOrigin, out hit))
            {
                
                _agent.SetDestination(hit.point);
                _playerAnimator.SetBool("Walk", true);
                _hitpoint = hit.point;
            }
        }

        float dis = Vector3.Distance(transform.position, _hitpoint);
        print(dis);

        if(dis < 1.5f)
        {
            print("Idle");
            _playerAnimator.SetBool("Walk", false);
        }
    }
}
