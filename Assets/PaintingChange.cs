using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PaintingChange : MonoBehaviour
{
    public InputAction action;
    public InputAction action2;
    //public GameObject starryPainting;
    public GameObject screamPainting;
    public GameObject wavePainting;
    public GameObject riverPainting;
    //public Texture starryOld;
    public Texture screamOld;
    public Texture waveOld;
    public Texture riverOld;
    //public Texture starryNew;
    public Texture screamNew;
    public Texture waveNew;
    public Texture riverNew;
    private Renderer renderer;

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        //starryPainting.GetComponent<Renderer>().material.mainTexture = starryOld;
        screamPainting.GetComponent<Renderer>().material.mainTexture = screamOld;
        wavePainting.GetComponent<Renderer>().material.mainTexture = waveOld;
        riverPainting.GetComponent<Renderer>().material.mainTexture = riverOld;
    }

    // Update is called once per frame
    void Update()
    {
        if (action.IsPressed())
        {
            //starryPainting.GetComponent<Renderer>().material.mainTexture = starryNew;
            screamPainting.GetComponent<Renderer>().material.mainTexture = screamNew;
            wavePainting.GetComponent<Renderer>().material.mainTexture = waveNew;
            riverPainting.GetComponent<Renderer>().material.mainTexture = riverNew;
        }
        if (action2.IsPressed())
        {
            //starryPainting.GetComponent<Renderer>().material.mainTexture = starryOld;
            screamPainting.GetComponent<Renderer>().material.mainTexture = screamOld;
            wavePainting.GetComponent<Renderer>().material.mainTexture = waveOld;
            riverPainting.GetComponent<Renderer>().material.mainTexture = riverOld;
        }
    }
}
