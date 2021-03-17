using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRandom : MonoBehaviour
{
	// Start is called before the first frame update	
	public List<GameObject> fires = new List<GameObject>();
	public float SpawnTime; //間隔多少時間生成Fire
	private float CountTime;    //紀錄時間
	private Vector3 SpawnPosition;  //獲得火的生成位置
    [Header("火災音效")]
    public AudioSource FireMusic;

    void Start()
    {
        FireMusic = GameObject.FindGameObjectWithTag("Fire").GetComponent<AudioSource>();
        FireMusic.Play();
    }
    void Update()
	{
		SpawnFire();
	}

	public void SpawnFire()
	{

        //隨著時間增加數值
        CountTime += Time.deltaTime;
		SpawnPosition = transform.position;
		//隨機生成火的位置
		SpawnPosition.x = Random.Range(0f, 46f);
		SpawnPosition.z = Random.Range(0f, 30f);

		//每隔一段時間產生火
		if (CountTime >= SpawnTime)
		{
			CreateFire();
			CountTime = 0;
		}
	}
	public void CreateFire()
	{
        int index = Random.Range(0, fires.Count);
		Instantiate(fires[index], SpawnPosition, Quaternion.identity);
	}
}
