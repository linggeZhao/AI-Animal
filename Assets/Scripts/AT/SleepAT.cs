using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SleepAT : ActionTask {
        private float timer = 10f;

        protected override void OnExecute()
        {
            Debug.Log("Sleeping");
        }

        protected override void OnUpdate()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Debug.Log("Wake up");
                EndAction(true);
            }
        }
    }
}