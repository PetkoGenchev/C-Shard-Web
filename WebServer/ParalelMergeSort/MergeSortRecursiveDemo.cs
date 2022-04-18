using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParalelMergeSort
{
    public class MergeSortRecursiveDemo
    {
		public static void MergeSortRecursive(ref int[] data, int left, int right)
		{
			if (left < right)
			{
				int m = left + (right - left) / 2;

				MergeSortRecursive(ref data, left, m);
				MergeSortRecursive(ref data, m + 1, right);
				Merge(ref data, left, m, right);
			}
		}

		private static void Merge(ref int[] data, int left, int mid, int right)
		{
			int i, j, k;
			int n1 = mid - left + 1;
			int n2 = right - mid;
			int[] L = new int[n1];
			int[] R = new int[n2];

			for (i = 0; i < n1; i++)
				L[i] = data[left + i];

			for (j = 0; j < n2; j++)
				R[j] = data[mid + 1 + j];

			i = 0;
			j = 0;
			k = left;

			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					data[k] = L[i];
					i++;
				}
				else
				{
					data[k] = R[j];
					j++;
				}

				k++;
			}

			while (i < n1)
			{
				data[k] = L[i];
				i++;
				k++;
			}

			while (j < n2)
			{
				data[k] = R[j];
				j++;
				k++;
			}
		}

	}
}
