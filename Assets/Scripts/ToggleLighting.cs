using UnityEngine;
//toggles lighting
public class ToggleLighting : MonoBehaviour
{

    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
