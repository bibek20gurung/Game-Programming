using UnityEngine;

namespace AG3360
{
    public class CapsuleHovering : MonoBehaviour
    {
        [SerializeField] private float hoverHeight = 5f; // Private variable with a public setter method
        [SerializeField] private float hoverSpeed = 2f; // Private variable with a public setter method
        private float currentHeight;

        // Start is called before the first frame update
        void Start()
        {
            currentHeight = transform.position.y; // Initialize hover position
        }

        // Update is called once per frame
        void Update()
        {
            HoverEffect();
        }

        // Hover effect applied to capsule
        private void HoverEffect()
        {
            float newHeight = Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;
            transform.position = new Vector3(transform.position.x, currentHeight + newHeight, transform.position.z);
        }

        // Getter and Setter for hoverHeight
        public float GetHoverHeight()
        {
            return hoverHeight;
        }

        public void SetHoverHeight(float newHeight)
        {
            hoverHeight = newHeight;
        }

        // Getter and Setter for hoverSpeed
        public float GetHoverSpeed()
        {
            return hoverSpeed;
        }

        public void SetHoverSpeed(float newSpeed)
        {
            hoverSpeed = newSpeed;
        }
    }
}
