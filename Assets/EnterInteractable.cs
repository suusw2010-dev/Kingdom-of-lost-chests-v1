using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(BoxCollider))]
public class EnterInteractable : MonoBehaviour
{

    [SerializeField] private GameObject Screen;
    
    private void Reset()
    {
        // Ensure the BoxCollider is set as a trigger
        BoxCollider col = GetComponent<BoxCollider>();
        col.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger: " + other.gameObject.name);
        Screen.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && this.Screen.gameObject.activeInHierarchy)
        {
            Screen.SetActive(false);
        }
    }
}
