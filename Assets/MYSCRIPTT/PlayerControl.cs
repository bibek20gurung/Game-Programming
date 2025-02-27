using UnityEngine;

namespace AG3360
{
    public class PlayerControl : MonoBehaviour
    {
        public CapsuleHovering capsuleHovering; // Reference to CapsuleHovering script

        // Start is called before the first frame update
        void Start()
        {
            // Make sure the reference to CapsuleHovering is assigned
            if (capsuleHovering == null)
                Debug.LogError("CapsuleHovering script not assigned!");
        }

        // Update is called once per frame
        void Update()
        {
            // Example interaction: Increase hover height and speed when the player presses specific keys
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                capsuleHovering.SetHoverHeight(capsuleHovering.GetHoverHeight() + 1f); // Increase height
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                capsuleHovering.SetHoverHeight(capsuleHovering.GetHoverHeight() - 1f); // Decrease height
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                capsuleHovering.SetHoverSpeed(capsuleHovering.GetHoverSpeed() + 0.5f); // Increase speed
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                capsuleHovering.SetHoverSpeed(capsuleHovering.GetHoverSpeed() - 0.5f); // Decrease speed
            }
        }
    }
}

