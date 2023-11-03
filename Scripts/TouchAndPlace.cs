using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchAndPlace : MonoBehaviour
{
    public GameObject[] numberPrefabs;

    public int currentNumber;

    public ARRaycastManager TouchAndPlace_ARRaycastManager;
    public ARSessionOrigin TouchAndPlace_ARSessionOrigin;

    public AudioSource TouchAndPlace_SoundSource;

    public AudioClip[] TouchAndPlace_SoundClip;

    void Start()
    {
        TouchAndPlace_ARRaycastManager = GetComponent<ARRaycastManager>();
        TouchAndPlace_ARSessionOrigin = GetComponent<ARSessionOrigin>();

        TouchAndPlace_SoundSource = GetComponent<AudioSource>();

        currentNumber = 0;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (TouchAndPlace_ARRaycastManager.Raycast(ray, hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose Pose_Hit = hits[0].pose;
                    SpawnNumberObject(Pose_Hit.position);
                }
            }
        }
    }

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void SpawnNumberObject(Vector3 position)
    {
        if (currentNumber <= 10)
        {
            GameObject numberObject = Instantiate(numberPrefabs[currentNumber], position, Quaternion.identity);
            TouchAndPlace_SoundSource.clip = TouchAndPlace_SoundClip[currentNumber];
            TouchAndPlace_SoundSource.Play();
            currentNumber++;
        }
    }
}
