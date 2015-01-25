using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

    public GameObject[] ObjectPrefabs;
    public int NumberOfObjects;

    Collider Collider;
    int NumberOfObjectsInTrigger;

	// Use this for initialization
	void Start () {
        Collider = collider;
        NumberOfObjectsInTrigger = 0;
        FillWithItems();
	}
    void OnTriggerEnter(Collider other)
    {  
        if ((other.transform.parent != null) &&(other.transform.parent.tag == "Object"))
        {
            NumberOfObjectsInTrigger++;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.tag == "Object")
        {
            NumberOfObjectsInTrigger--;
            FillWithItems();
        }
    }

    void FillWithItems()
    {
        for (int i = NumberOfObjectsInTrigger; i < NumberOfObjects; i++)
        {
            GameObject Prefab = ObjectPrefabs[Random.Range(0, ObjectPrefabs.Length - 1)];
            Vector3 Position = Vector3.zero;
            Position.y += (collider.bounds.size.y / 2f);
            float Multiplier = (Random.value > 0.5) ? -1 : 1;
            Position.x += Multiplier * (Random.value * collider.bounds.size.x/3f);
            Multiplier = (Random.value > 0.5) ? -1 : 1;
            Position.z += Multiplier * (Random.value * collider.bounds.size.z / 4f);
            Position = collider.transform.localToWorldMatrix.MultiplyPoint(Position);

            Quaternion Rotation = new Quaternion();
            Rotation.eulerAngles = new Vector3(0, Random.value * 360f, 0);

            GameObject NewObject = Instantiate(Prefab, Position, Rotation) as GameObject;
        }
    }

    
}
