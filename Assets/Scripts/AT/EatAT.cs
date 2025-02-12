using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class EatAT : ActionTask {
        private float timer = 5f;

        protected override void OnExecute()
        {
            Debug.Log("Eating");
        }

        protected override void OnUpdate()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Debug.Log("Done");
                EndAction(true);
            }
        }
    }
}