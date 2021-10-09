
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject[] box;

    int ymax = 3;
    int xmax = 6;

    public void Bangkit()
    {
        for (int i = 0; i < Random.Range(2,5); i++)
        {
            int tag = Random.Range(0, 2);
            float xPos = Random.Range(-xmax, xmax);
            float yPos = Random.Range(-ymax, ymax);
            Vector2 posisiRandom = new Vector2(xPos, yPos);
            Instantiate(box[tag], posisiRandom, Quaternion.identity);
        }
    }

    void Start()
    {
        Bangkit();
    }
}
