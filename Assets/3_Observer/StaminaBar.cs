namespace Observer
{
    using UnityEngine;

    public class StaminaBar : MonoBehaviour
    {
        private float percentage = 100;

        public float GetValue()
        {
            return percentage;
        }

        public void SetValue(float percentage)
        {
            this.percentage = percentage;
        }
    }
}