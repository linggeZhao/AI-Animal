using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckDangerCT : ConditionTask {
        public BBParameter<float> dangerValue;

        protected override bool OnCheck()
        {
            return dangerValue.value >= 100f;
        }
    }
}