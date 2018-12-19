using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Garage carLot = new Garage();

        //交出集合中的每一Car对象吗
        foreach (Car c in carLot)
        {
            //Console.WriteLine("{0} is going {1} MPH", c.CarName, c.CurrentSpeed);
            Debug.Log(c.name);
            Debug.Log(c.speed);
        }

        //Console.ReadLine();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CaculateResult()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(1);

            yield return new WaitForSeconds(2f);

            Debug.Log(2);
        }

        Debug.Log(3);
    }
}

public class Car
{
    public string name;
    public int speed;

    public Car(string _name, int _speed)
    {
        name = _name;
        speed =_speed;
    }
}

public class Garage
{
    Car[] carArray = new Car[4];  //在Garage中定义一个Car类型的数组carArray,其实carArray在这里的本质是一个数组字段

    //启动时填充一些Car对象
    public Garage()
    {
        //为数组字段赋值
        carArray[0] = new Car("Rusty", 30);
        carArray[1] = new Car("Clunker", 50);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 45);
    }

    public IEnumerator GetEnumerator()
    {
        return this.carArray.GetEnumerator();
    }
}


