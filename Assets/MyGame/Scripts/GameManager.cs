using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    private const int minHit = 0;
    public GameObject target;
    public GameObject badTarget;
    public GameObject parentOfTargets;
    public GameObject parentOfBadTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject lostObj;
    public GameObject shootSound;

    private Text textCounter;
    private bool won;
    private bool lost;
    private int scoreNew;

    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        lost = false;
        InvokeRepeating("Spawn", 1f, 2f);
        wonObj.SetActive(false);
        lostObj.SetActive(false);
        
    }

    // Spawn a Target at a random position within a specified x and y range.
    // Instantiate (makea a concrete GameObject, i.e. a clone from the given prefab target) the
    // target as child of the parentOfTargets. In this case transform.localPosition instead of
    // transform.position is important!!
    private void Spawn ()
    {
        float randomX = Random.Range(-420, 421);
        float randomY = Random.Range(-240, 241);
        float BadrandomX = Random.Range(-325, 325);
        float BadrandomY = Random.Range(-140, 141);

        Vector2 random2DPositionTarget = new Vector2(randomX, randomY);
        Vector2 random2DPositionBadTarget = new Vector2(BadrandomX, BadrandomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPositionTarget;
        GameObject myBadTarget = Instantiate(badTarget, parentOfBadTargets.transform);
        myBadTarget.transform.localPosition = random2DPositionBadTarget;


        Debug.Log(random2DPositionTarget);
    }

    // Update is called once per frame
    void Update()
    {
        if(won == true)
        {
            CancelInvoke("Spawn");
            wonObj.SetActive(true);
        }

        if(lost == true)
        {
            CancelInvoke("Spawn");
            lostObj.SetActive(true);
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

    public void DecrementScore()
    {
        scoreNew--;
        Debug.Log("decrement...." + scoreNew);
        textCounter.text = scoreNew.ToString();

        //== / >= / <= / != / < / > sind Zuweisungsoperatoren
        if (scoreNew <= minHit)
        {
            lost = true;
        }
    }
}
