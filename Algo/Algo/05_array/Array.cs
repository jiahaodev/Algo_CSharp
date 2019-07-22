/****************************************************
	文件：Array.cs
	作者：JiahaoWu
	邮箱: jiahaodev@163.ccom
	日期：2019/07/23 1:33   	
	功能：数组的插入、删除、按照下标随机访问
*****************************************************/
using System;
using System.Collections.Generic;



public class Array
{
    private int[] data;
    private int n;
    private int count;

    public Array(int capacity) {
        this.data = new int[capacity];
        this.n = capacity;
        this.count = 0;
    }

    public int find(int index) {
        if (index < 0 || index >= count)
        {
            return -1;
        }
        return data[index];
    }

    //插入元素
    public bool insert(int index, int value) {
        if (count == n)
        {
            Console.WriteLine("没有可插入的位置");
            return false;
        }
        if (index < 0 || index > count )
        {
            Console.WriteLine("位置不合法");
            return false;
        }
        for (int i = count; i > index; i--)
        {
            data[i] = data[i - 1];
        }
        data[index] = value;
        ++count;
        return true;
    }

    //删除元素（根据索引）
    public bool remove(int index) {
        if (index < 0 || index > count)
        {
            Console.WriteLine("位置不合法");
            return false;
        }
        for (int i = index + 1; i < count; i++)
        {
            data[i - 1] = data[i];
        }
        --count;
        return true;
    }

    public void printAll() {
        for (int i = 0; i < count; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Array array = new Array(5);
        array.printAll();
        array.insert(0, 3);
        array.insert(0, 4);
        array.insert(1, 5);
        array.insert(3, 9);
        array.insert(3, 10);
        //array.insert(3, 11);
        array.printAll();

        Console.ReadKey();
    }


}

