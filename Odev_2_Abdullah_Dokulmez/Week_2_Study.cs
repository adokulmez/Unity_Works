using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week_2_Study : MonoBehaviour
{
    void bolenleriBul(int first_val, int second_val)
    {
        int[] takenValues = { first_val, second_val }; // Veri boyutu sabit ve de�i�meyecek. �nteger dizi kullan�m� performans kriteri olarak �nemlidir.

        List<int> main_list= new List<int>();       //Veri boyutu de�i�ecek ancak t�r� sabit kalacak o nednele "array list" yerine list tercih edildi.
        List<int> divisible_by_2 = new List<int>();
        List<int> divisible_by_3 = new List<int>();
        List<int> divisible_by_4 = new List<int>();
        List<int> divisible_by_5 = new List<int>();

        Array.Sort(takenValues); // Ko�ullar ile say�lardan b�y�k olan� se�ilmektense al�nan iki say�y� k���kten b�y��e s�ralad�k.
        
        for (int i = takenValues[0]; i <= takenValues[1]; i++) //Her bir say� b�l�nebilirliklerine g�re listelere s�raland�.
        {
            main_list.Add(i);
            if (i % 2 == 0) divisible_by_2.Add(i);
            if (i % 3 == 0) divisible_by_3.Add(i);
            if (i % 4 == 0) divisible_by_4.Add(i);
            if (i % 5 == 0) divisible_by_5.Add(i);
        }

        void Str_Out(string first_text, List<int> temp_list) // Sat�r tasarrufu ve okunabilirlik i�in metot olu�turuldu 
        {
            string output = first_text;
            foreach (int eleman in temp_list) output += " - " + eleman.ToString();
            print(output);
        }

        Str_Out("T�m liste : ", main_list);
        Str_Out("�kiye B�l�nenler : ", divisible_by_2);
        Str_Out("��e B�l�nenler : ", divisible_by_3);
        Str_Out("D�rde B�l�nenler : ", divisible_by_4);
        Str_Out("Be�e B�l�nenler : ", divisible_by_5);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(20, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
