using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckMoveCT : ConditionTask {
		protected override bool OnCheck() {
            return Input.GetMouseButtonDown(0);
        }
	}
}