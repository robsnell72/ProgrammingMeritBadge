/* package whatever; // don't place package name! */

import java.io.*;
import java.util.*;
import java.util.Arrays;

class myCode
{
    public static Integer Sum(List<Integer> nums){
        Integer sum = 0;
        
        for(Integer num : nums){
            sum += num;
        }
        
        return sum;
            
    }
        
    
    public static void main (String[] args) throws java.lang.Exception
    {
        List<Integer> numbers = Arrays.asList(1, 2, 3);
        System.out.println(Sum(numbers));
    }
}
