namespace Observer
{
    using UnityEngine;

    public class JumpButton : MonoBehaviour
    {
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
            }
        }

        private void OnRelease()
        {
            isPressed = false;
        }
    }
}