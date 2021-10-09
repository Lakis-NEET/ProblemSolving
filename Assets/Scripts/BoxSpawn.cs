
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject[] box;
    public float spawnTime = 3f;

    public GameObject dot;

    public static BoxSpawn _instance = null;
    public static BoxSpawn Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<BoxSpawn>();
            }
            return _instance;
        }
    }

    int ymax = 3;
    int xmax = 6;

    void Bangkit()
    {
        for (int i = 0; i < 2; i++)
        {
            int tag = Random.Range(0, 2);
            Vector2 posisiRandom = DaerahSpawn();
            Instantiate(box[tag], posisiRandom, Quaternion.identity);
        }
    }

    void Start()
    {
        Bangkit();
        //InvokeRepeating("Bangkit", spawnTime, spawnTime);
    }

    public Vector2 DaerahSpawn()
    {
        float xPos=0;
        float yPos=0;
        bool isNear = true;
        while (isNear) 
        {
            xPos = Random.Range(-xmax, xmax);
            yPos = Random.Range(-ymax, ymax);
            float selisihDotx = Mathf.Abs(xPos) - Mathf.Abs(dot.transform.position.x);
            float selisihDoty = Mathf.Abs(yPos) - Mathf.Abs(dot.transform.position.y);
            if (Mathf.Abs(selisihDotx) > 1)
            {
                isNear = false;
            }
            else if (Mathf.Abs(selisihDoty) > 1)
            {
                isNear = false;
            }
        }
        return new Vector2(xPos, yPos);
    }

}
