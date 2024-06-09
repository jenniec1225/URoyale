using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace UnityRoyale
{
    public class AIPlayer : MonoBehaviour
    {
        private NavMeshAgent agent;
        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    agent.SetDestination(hit.point);
                }


                // raycast check
                Debug.DrawRay(ray.origin, ray.direction * 100, color: Color.red, duration: 2);
            }
        }
    }
}
