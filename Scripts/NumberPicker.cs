using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NumberPicker : MonoBehaviour
{
    public GameObject[] RandomNumbersToPick_GameObject;
    public GameObject RandomNumbersToPick_GameObject_Finished;
    public GameObject WellDone_GameObject_Finished;
    public GameObject Number_GAmeObject_Finished;

    public ParticleSystem[] WellDoneParticles;

    public int NumberToPick;

    public bool Finished;

    public Vector3 rotationSpeed;

    public Material DoneMaterial;
    public Material NotDoneMaterial;

    public MeshRenderer[] DoneMeshRender_Material;

    public AudioSource NumberPicker_SoundSource;

    public AudioClip[] NumberPicker_SoundClip;

    // Start is called before the first frame update
    void Start()
    {

        RandomNumbersToPick_GameObject_Finished = GameObject.Find("RandomNumber");
        WellDone_GameObject_Finished = GameObject.Find("WellDone");
        Number_GAmeObject_Finished = GameObject.Find("Numbers");
        NumberPicker_SoundSource = GetComponent<AudioSource>();


        foreach (GameObject RandomNumbersToPick_GameObject_Array in RandomNumbersToPick_GameObject)
        {
            RandomNumbersToPick_GameObject_Array.SetActive(false);
        }
        

        foreach (MeshRenderer DoneMeshRender_Material_Array in DoneMeshRender_Material)
        {
            DoneMeshRender_Material_Array.material = NotDoneMaterial;
        }

        ActivateElement(NumberToPick);
        WellDone_GameObject_Finished.SetActive(false);
        rotationSpeed = new Vector3(0, 30, 0);
        Finished = false;

        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[0];
        NumberPicker_SoundSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first detected touch

            if (touch.phase == TouchPhase.Began)
            {
                // Cast a ray from the touch position into the scene
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                { 
                    GameObject touchedObject = hit.collider.gameObject;

                    if (hit.collider.gameObject.name == "1" && NumberToPick == 0)
                    {
                        WellDoneParticles[0].Play();
                        DoneMeshRender_Material[0].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[1];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "2" && NumberToPick == 1)
                    {
                        WellDoneParticles[1].Play();
                        DoneMeshRender_Material[1].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[2];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "3" && NumberToPick == 2)
                    {
                        WellDoneParticles[2].Play();
                        DoneMeshRender_Material[2].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[3];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "4" && NumberToPick == 3)
                    {
                        WellDoneParticles[3].Play();
                        DoneMeshRender_Material[3].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[4];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "5" && NumberToPick == 4)
                    {
                        WellDoneParticles[4].Play();
                        DoneMeshRender_Material[4].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[5];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "6" && NumberToPick == 5)
                    {
                        WellDoneParticles[5].Play();
                        DoneMeshRender_Material[5].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[6];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "7" && NumberToPick == 6)
                    {
                        WellDoneParticles[6].Play();
                        DoneMeshRender_Material[6].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[7];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "8" && NumberToPick == 7)
                    {
                        WellDoneParticles[7].Play();
                        DoneMeshRender_Material[7].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[8];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "9" && NumberToPick == 8)
                    {
                        WellDoneParticles[8].Play();
                        DoneMeshRender_Material[8].material = DoneMaterial;
                        DeactivateElement(NumberToPick);
                        NumberToPick = (NumberToPick + 1) % RandomNumbersToPick_GameObject.Length;
                        ActivateElement(NumberToPick);
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[9];
                        NumberPicker_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "10" && NumberToPick == 9)
                    {
                        WellDoneParticles[9].Play();
                        DoneMeshRender_Material[9].material = DoneMaterial;
                        DoneMeshRender_Material[10].material = DoneMaterial;
                        RandomNumbersToPick_GameObject_Finished.SetActive(false);
                        Number_GAmeObject_Finished.SetActive(false);
                        WellDone_GameObject_Finished.SetActive(true);
                        WellDoneParticles[10].Play();
                        Finished = true;
                        NumberPicker_SoundSource.clip = NumberPicker_SoundClip[10];
                        NumberPicker_SoundSource.Play();
                    }
                }
            }
        }

        if (Finished == true)
        {
            WellDone_GameObject_Finished.transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }

    void ActivateElement(int index)
    {
        if (index >= 0 && index < RandomNumbersToPick_GameObject.Length)
        {
            RandomNumbersToPick_GameObject[index].SetActive(true);
        }
    }

    void DeactivateElement(int index)
    {
        if (index >= 0 && index < RandomNumbersToPick_GameObject.Length)
        {
            RandomNumbersToPick_GameObject[index].SetActive(false);
        }
    }
}
