// Top level statements 
// Test solution here 
using System.Text;

int[] arr = {3, 8, 9, 7, 6}; 
int[] result = Rotate(arr, 3); 

StringBuilder sb = new StringBuilder("{"); 
foreach (int i in result) {
    sb.Append(i.ToString()); 
    sb.Append(", ");
}
sb.Append("}"); 

Console.WriteLine($"Result of A=[3, 8, 9, 7, 6], K=3: {sb.ToString()}");

public static partial class Program {
    /// <summary>
    /// Rotate the elements of array A, K times.
    /// Rotation means that each element is moved to the right one index, such
    /// that the last element of A becomes the first element. 
    /// </summary>
    /// <param name="a">Array on which to perform rotation</param>
    /// <param name="k">Number of rotations to perform</param>
    /// <returns></returns>
    public static int[] Rotate(int[] a, int k) {
        int temp, prev; 
        while (k-- > 0) {
            prev = a[1]; 
            a[1] = a[0]; 

            for (int i = 1; i < (a.Length - 1); i++) {
                temp = a[i + 1]; 
                a[i + 1] = prev;
                prev = temp; 
            }

            a[0] = prev; 
        }

        return a; 
    }
}