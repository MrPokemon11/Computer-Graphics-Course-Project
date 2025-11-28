using UnityEngine;
// scales the uvs of a given texture
public class ScaleTexture : MonoBehaviour
{

    public GameObject player;
    Renderer rend;

    private bool isActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    static float ConvertRange( //obtained from: https://stackoverflow.com/questions/4229662/convert-numbers-within-a-range-to-numbers-within-another-range
        float originalStart, float originalEnd, // original range
        float newStart, float newEnd, // desired range
        float value) // value to convert
    {
        double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
        return (float)(newStart + ((value - originalStart) * scale));
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            rend.material.SetFloat("_ScaleUVY", ConvertRange(4.5f, 46f, 1, 10, player.transform.position.x)); 
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            isActive = !isActive;
        }
    }
    
    
}
