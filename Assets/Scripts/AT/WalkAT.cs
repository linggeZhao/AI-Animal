using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class WalkAT : ActionTask {

        private NavMeshAgent navAgent;

		protected override void OnExecute() {
            navAgent = agent.GetComponent<NavMeshAgent>();
            Debug.Log("Walk");
        }

		protected override void OnUpdate() {
            if (!navAgent.pathPending && navAgent.remainingDistance <= navAgent.stoppingDistance)
            {
                EndAction(true);
            }
        }
	}
}