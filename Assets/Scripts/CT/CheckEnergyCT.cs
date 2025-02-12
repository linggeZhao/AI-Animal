using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckEnergyCT : ConditionTask {

        public BBParameter<float> energyValue;

        protected override bool OnCheck()
        {
            return energyValue.value <= 0f;
        }
    }
}