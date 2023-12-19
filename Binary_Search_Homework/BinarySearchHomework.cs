using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] array, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end >= start)
            {
                int firstmid = start + (end - start) / 3;
                int secondmid = end - (end - start) / 3;

                if (ar[firstmid] == key)
                    return firstmid;

                if (ar[secondmid] == key)
                    return secondmid;

                if (key < ar[firstmid])
                    return TernarySearch(ar, key, start, firstmid - 1);

                else if (key > ar[secondmid])
                    return TernarySearch(ar, key, secondmid + 1, end);

                else
                    return TernarySearch(ar, key, firstmid + 1, secondmid - 1);
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
          int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    result = mid;
                    if (is_first)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
                if (!is_first && mid == array.Length - 1) break;

            }

            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
          
            int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length);
            int last = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);
            if (first == -1 || last == -1)
            {
                return 0;
            }

            int count = 0;
            for (int i = first; i <= last; i++)
                if (key == arr[i])
                    count++;

            if (count > 0)
                return count;
            else
                return 0;
        }
    }
}
