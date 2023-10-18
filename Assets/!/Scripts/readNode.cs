using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class readNode : MonoBehaviour
{
    [SerializeField]
    private GameObject _noteImage;

    public GameObject MessagePanel;
    public GameObject crosshair;
    public bool Action = false;
    public void Start()
    {
        MessagePanel.SetActive(false);
        _noteImage.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                MessagePanel.SetActive(false);
                crosshair.SetActive(false);
                Action = false;
                _noteImage.SetActive(true);
            }
            else
            {
                MessagePanel.SetActive(true);
                crosshair.SetActive(true);
                Action = true;
                _noteImage.SetActive(false);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MessagePanel.SetActive(true);
            Action = true;
        }
    }
    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            MessagePanel.SetActive(false);
            Action = false;
            _noteImage.SetActive(false);
        }
    }
}