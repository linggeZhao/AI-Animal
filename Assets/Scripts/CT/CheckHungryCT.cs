using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckHungryCT : ConditionTask {
		protected override bool OnCheck() {
            return GameObject.FindWithTag("Food") != null;
        }
	}
}