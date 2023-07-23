using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week_2_Study : MonoBehaviour
{
    void bolenleriBul(int first_val, int second_val)
    {
        int[] takenValues = { first_val, second_val }; // Veri boyutu sabit ve deðiþmeyecek. Ýnteger dizi kullanýmý performans kriteri olarak önemlidir.

        List<int> main_list= new List<int>();       //Veri boyutu deðiþecek ancak türü sabit kalacak o nednele "array list" yerine list tercih edildi.
        List<int> divisible_by_2 = new List<int>();
        List<int> divisible_by_3 = new List<int>();
        List<int> divisible_by_4 = new List<int>();
        List<int> divisible_by_5 = new List<int>();

        Array.Sort(takenValues); // Koþullar ile sayýlardan büyük olaný seçilmektense alýnan iki sayýyý küçükten büyüðe sýraladýk.
        
        for (int i = takenValues[0]; i <= takenValues[1]; i++) //Her bir sayý bölünebilirliklerine göre listelere sýralandý.
        {
            main_list.Add(i);
            if (i % 2 == 0) divisible_by_2.Add(i);
            if (i % 3 == 0) divisible_by_3.Add(i);
            if (i % 4 == 0) divisible_by_4.Add(i);
            if (i % 5 == 0) divisible_by_5.Add(i);
        }

        void Str_Out(string first_text, List<int> temp_list) // Satýr tasarrufu ve okunabilirlik için metot oluþturuldu 
        {
            string output = first_text;
            foreach (int eleman in temp_list) output += " - " + eleman.ToString();
            print(output);
        }

        Str_Out("Tüm liste : ", main_list);
        Str_Out("Ýkiye Bölünenler : ", divisible_by_2);
        Str_Out("Üçe Bölünenler : ", divisible_by_3);
        Str_Out("Dörde Bölünenler : ", divisible_by_4);
        Str_Out("Beþe Bölünenler : ", divisible_by_5);
        
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
