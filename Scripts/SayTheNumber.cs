using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayTheNumber : MonoBehaviour
{
    public ParticleSystem[] WellDoneParticles;

    public AudioSource SayTheNumber_SoundSource;

    public AudioClip[] SayTheNumber_SoundClip;

    // Start is called before the first frame update
    void Start()
    {
        SayTheNumber_SoundSource = GetComponent<AudioSource>();
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

                    if (hit.collider.gameObject.name == "1")
                    {
                        WellDoneParticles[0].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[0];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "2")
                    {
                        WellDoneParticles[1].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[1];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "3")
                    {
                        WellDoneParticles[2].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[2];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "4")
                    {
                        WellDoneParticles[3].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[3];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "5")
                    {
                        WellDoneParticles[4].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[4];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "6")
                    {
                        WellDoneParticles[5].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[5];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "7")
                    {
                        WellDoneParticles[6].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[6];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "8")
                    {
                        WellDoneParticles[7].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[7];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "9")
                    {
                        WellDoneParticles[8].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[8];
                        SayTheNumber_SoundSource.Play();
                    }

                    if (hit.collider.gameObject.name == "10")
                    {
                        WellDoneParticles[9].Play();
                        SayTheNumber_SoundSource.clip = SayTheNumber_SoundClip[9];
                        SayTheNumber_SoundSource.Play();
                    }
                }
            }
        }
    }
}
