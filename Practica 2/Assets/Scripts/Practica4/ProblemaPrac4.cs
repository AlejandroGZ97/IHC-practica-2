using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaPrac4 : MonoBehaviour
{
    void Start()
    {
        int [] nums = new int[] {-2,1,-3,4,-1,2,1,-5,4};                                
        int result = SumaContiguaMayor(nums);
        Debug.Log("Suma: " + result); 
    }

    private int SumaContiguaMayor(int[] nums)
    {
        int tam, j, suma = 0, aux;                                                 
        tam = nums.Length;

        if(tam == 0)
            return suma;
        else if(tam == 1)
            return nums[0];                                      

        for(int i=0; i < tam; i++)                                
        {
            aux = nums[i];
            if(suma < nums[i])
                suma = nums[i];

            j = i+1;                                                
            while(j<tam)                                            
            {
                aux += nums[j];
                if(suma < aux)                       
                    suma = aux;                         
                j++;                                                
            }
        }
        return suma;                                    
    }
} 
