using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class IdleAT : ActionTask {

        private ClickToMove movement;
        protected override void OnExecute() {
            Debug.Log("Idle");
            EndAction(true);
		}
    }
}