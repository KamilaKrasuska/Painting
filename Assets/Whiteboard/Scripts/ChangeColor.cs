using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour
{
    public Material newMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("M1"))
        {
            GameObject[] tip1Objects = GameObject.FindGameObjectsWithTag("Tip1");

            foreach (GameObject tipObject in tip1Objects)
            {
                Renderer renderer = tipObject.GetComponent<Renderer>();
                if (renderer != null && newMaterial != null)
                {
                    renderer.material = newMaterial;
                }
                else
                {
                    Debug.LogWarning("Brak komponentu Tip lub nowego materiału'.");
                }
            }
        }

        if (collision.gameObject.CompareTag("M2"))
        {
            GameObject[] tip2Objects = GameObject.FindGameObjectsWithTag("Tip2");

            foreach (GameObject tipObject in tip2Objects)
            {
                Renderer renderer = tipObject.GetComponent<Renderer>();
                if (renderer != null && newMaterial != null)
                {
                    renderer.material = newMaterial;
                }
                else
                {
                    Debug.LogWarning("Brak komponentu Tip lub nowego materiału'.");
                }
            }
        }

        if (collision.gameObject.CompareTag("M3"))
        {
            GameObject[] tip3Objects = GameObject.FindGameObjectsWithTag("Tip3");

            foreach (GameObject tipObject in tip3Objects)
            {
                Renderer renderer = tipObject.GetComponent<Renderer>();
                if (renderer != null && newMaterial != null)
                {
                    renderer.material = newMaterial;
                }
                else
                {
                    Debug.LogWarning("Brak komponentu Tip lub nowego materiału'.");
                }
            }
        }
    }
}
