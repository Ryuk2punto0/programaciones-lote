using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	// Start is called before the first frame update
	public int ni;
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	//Textos
	public GameObject t1;
	public GameObject t2;
	public GameObject t3;
	public GameObject t4;
	public GameObject t5;
	public GameObject t6;
    

    void Start()
	{

	}

	// Update is called once per frame
	//void Update()
	//{

	//}

 
    public void Invocar() {

		ni = ni + 1;

		if (ni == 1)
		{ p1.SetActive(true); }
		else if (ni == 2)
		{ p2.SetActive(true); }
		else if (ni == 3)
		{ p3.SetActive(true); }
	}

	public void P1()
	{
		t1.SetActive(true);
		t2.SetActive(false);
		t3.SetActive(false);
		t4.SetActive(false);
		t5.SetActive(false);
		t6.SetActive(false);

	}

	public void P2()
	{
		t1.SetActive(false);
		t2.SetActive(true);
		t3.SetActive(false);
		t4.SetActive(false);
		t5.SetActive(false);
		t6.SetActive(false);

	}

	public void P3()
	{
		t1.SetActive(false);
		t2.SetActive(false);
		t3.SetActive(true);
		t4.SetActive(false);
		t5.SetActive(false);
		t6.SetActive(false);

	}

	public void P4()
	{
		t1.SetActive(false);
		t2.SetActive(false);
		t3.SetActive(false);
		t4.SetActive(true);
		t5.SetActive(false);
		t6.SetActive(false);

	}

	public void P5()
	{
		t1.SetActive(false);
		t2.SetActive(false);
		t3.SetActive(false);
		t4.SetActive(false);
		t5.SetActive(true);
		t6.SetActive(false);

	}

	public void P6()
	{
		t1.SetActive(false);
		t2.SetActive(false);
		t3.SetActive(false);
		t4.SetActive(false);
		t5.SetActive(false);
		t6.SetActive(true);

	}
}
