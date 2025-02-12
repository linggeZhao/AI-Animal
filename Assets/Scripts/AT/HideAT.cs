using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class HideAT : ActionTask {
        private float timer = 3f;

        protected override void OnExecute()
        {
            agent.GetComponent<Renderer>().material.color = Color.red;
        }

        protected override void OnUpdate()
        {
            timer -= Time.deltaTime; 
            if (timer <= 0)
            {
                agent.GetComponent<Renderer>().material.color = Color.white; 
                EndAction(true); 
            }
        }
    }
}