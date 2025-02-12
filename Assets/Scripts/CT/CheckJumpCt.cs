using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckJumpCt : ConditionTask {
		protected override bool OnCheck() {
            return Input.GetKeyDown(KeyCode.Space);
        }
	}
}