namespace DirectCoupling
{
    using UnityEngine;

    public class StaminaBar : MonoBehaviour
    {
        public Player player;

        public JumpButton jumpButton;

        private float percentage = 100;

        public float GetValue()
        {
            return percentage;
        }

        public void SetValue(float percentage)
        {
            this.percentage = percentage;

            if (this.percentage <= 0)
            {
                player.MakeTired();
                jumpButton.Disable();
            }
        }
    }
}