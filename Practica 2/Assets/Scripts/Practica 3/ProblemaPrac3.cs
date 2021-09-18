using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaPrac3 : MonoBehaviour
{
    void Start()
    {
        int [] nums = new int[] {8,1,2,2,3};                        //O(1)
        int target = 5;                                             //O(1)
        int [] result = SumaDos(nums, target);
        Debug.Log("Output: [" + result[0] + "," + result[1] + "]"); //O(1)
    }

    private int[] SumaDos(int[] nums, int target)
    {
        int tam, j;                                                 //O(1)
        tam = nums.Length;                                          //O(1)

        for(int i=0; i < tam-1; i++)                                //O(n)
        {
            j = i+1;                                                //O(n)
            while(j<tam)                                            //O(n^(1/2))
            {
                if(nums[i]+nums[j] == target)                       //O(n^(1/2))
                    return new int[] {i,j};                         //O(1)
                j++;                                                //O(n^(1/2))
            }
        }
        return new int[] {0,0};                                     //O(1)
    }
} // Complejidad: espacio: O(n), velocidad: O(n^(1/2))
