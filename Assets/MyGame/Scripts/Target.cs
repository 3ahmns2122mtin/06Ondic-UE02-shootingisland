using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] public int secToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        //secToDestroy = 2;
        //Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
