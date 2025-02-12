using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class JumpAT : ActionTask {
        private ClickToMove movement;
        protected override void OnExecute() {
            movement = agent.GetComponent<ClickToMove>();
            Debug.Log("Jump");
            movement.Jump(); 
            EndAction(true);
        }
    }
}