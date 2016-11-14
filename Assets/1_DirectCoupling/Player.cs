namespace DirectCoupling
{
    using UnityEngine;

    public class Player : MonoBehaviour
    {
        public StaminaBar staminaBar;

        public void Jump()
        {
            float currentPercentage = staminaBar.GetValue();
            staminaBar.SetValue(currentPercentage - 25);
        }

        public void MakeTired()
        {

        }
    }
}