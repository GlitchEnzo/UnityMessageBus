namespace DirectCoupling
{
    using UnityEngine;

    public class JumpButton : MonoBehaviour
    {
        public Player player; // JumpButton is directly coupled to the specific Player class

        public bool isPressed = false;

        private bool isEnabled = true;

        public void Disable()
        {
            isEnabled = false;
        }

        public void Enable()
        {
            isEnabled = true;
        }

        private void OnPressed()
        {
            if (isEnabled)
            {
                isPressed = true;
                player.Jump();
            }
        }

        private void OnRelease()
        {
            isPressed = false;
        }
    }
}