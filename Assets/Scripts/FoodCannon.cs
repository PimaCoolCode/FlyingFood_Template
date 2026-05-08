using Unity.VisualScripting;
using UnityEngine;

public class FoodCannon : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject food;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(food, shootPoint.position, Random.rotation);
        }
    }
}
