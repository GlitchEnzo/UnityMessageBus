namespace Observer
{
    using System;
    using UnityEngine;

    public class Controller : MonoBehaviour
    {
        public StaminaBar staminaBar;

        public Player player;

        public JumpButton jumpButton;

        public event Action JumpButtonPressed;

        protected void Update()
        {
            if (jumpButton.isPressed)
            {
                float currentPercentage = staminaBar.GetValue();
                float newPercentage = currentPercentage - 25;
                staminaBar.SetValue(newPercentage);

                if (newPercentage <= 0)
                {
                    player.MakeTired();
                    jumpButton.Disable();
                }
                else
                {
                    player.Jump();
                }
            }
        }
    }
}