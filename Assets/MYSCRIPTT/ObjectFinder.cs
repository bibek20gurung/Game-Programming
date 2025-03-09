using UnityEngine;

namespace AG3368
{
    public class ObjectFinder : MonoBehaviour
    {
        public GameObject draggedObject; // Assigned via Inspector

        void Start()
        {
            // Option 1: Finding object by Drag-n-Drop (Inspector)
            if (draggedObject != null)
            {
                draggedObject.transform.position += Vector3.up * 2;
            }

            // Option 2: Finding object by Name
            GameObject foundObject = GameObject.Find("TargetObject");

            if (foundObject != null)
            {
                foundObject.transform.position = new Vector3(0, 2, 0);
            }

            // Finding multiple objects with the same tag
            GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("TargetTag");

            foreach (GameObject obj in foundObjects)
            {
                obj.transform.position += Vector3.up * 2;
            }
        }
    }
}
