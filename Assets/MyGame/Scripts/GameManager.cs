using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject shootSound;

    private Text textCounter;
    private bool won;
    private int scoreNew;

    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        InvokeRepeating("Spawn", 1f, 2f);
        wonObj.SetActive(false);
    }

    // Spawn a Target at a random position within a specified x and y range.
    // Instantiate (makea a concrete GameObject, i.e. a clone from the given prefab target) the
    // target as child of the parentOfTargets. In this case transform.localPosition instead of
    // transform.position is important!!
    private void Spawn ()
    {
        float randomX = Random.Range(-420, 421);
        float randomY = Random.Range(-240, 241);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;


        Debug.Log(random2DPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if(won == true)
        {
            CancelInvoke("Spawn");
            wonObj.SetActive(true);
        }
        else
        {
            Debug.Log(won);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed");
            shootSound.GetComponent<AudioSource>().Play();
        }

    }
    public void IncrementScore()
    {
        scoreNew++;
        Debug.Log("increment...." + scoreNew);
        textCounter.text = scoreNew.ToString();

        //== / >= / <= / != / < / > sind Zuweisungsoperatoren
        if(scoreNew >= maxHit)
        {
            won = true;
        }
    }
}
