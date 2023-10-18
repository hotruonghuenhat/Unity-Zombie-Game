using UnityEngine;

public class changeCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
