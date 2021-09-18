using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Problema : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [] nums = new int[] {8,1,2,2,3};
        int [] result = ContNumerosMenores(nums);
        Debug.Log("Output: [" + string.Join(",", from item in result select item) + "]");
    }

    private int[] ContNumerosMenores(int[] nums)
    {
        int tam, i = 0, cont = 0;
        tam = nums.Length;
        int [] aux = new int [tam];
        while(tam > i)
        {
            foreach (var item in nums)
            {
                if (nums[i] > item)
                    cont++;
            }
            aux[i] = cont;
            i++;
            cont = 0;
        }
        return nums = aux;
    }
}
