//================One dimensinal Array===============
//Declaration

// int[] nums; // Declaration
// nums = new int[5]; // Allocation
//
// nums[0] = 12; // index = 0..n-1
// nums[1] = 5;
// nums[2] = 5;
// nums[3] = -1;
// nums[4] = 8;
// Console.WriteLine(nums[3]);
// //nums[5] = 6; //Error out of boundry index
//
// nums[3] = -12;
// Console.WriteLine(nums[3]);
//
// Console.WriteLine(nums.Length);
//
// int[] nums2 = /*new int[5]*/ { 6, 7, 1, 8, 9, 12 };
// //new int i yazmasan ve arrayin size ini beyan etmesen de olr.
// //spesifik bi size belirlemek istiyosan yaz.
//
// Console.WriteLine(nums2[3]);
// Console.WriteLine("\nItterating through elements of one dimens. Array");
// for (int i = 0; i < nums2.Length; i++)
// {
//     Console.WriteLine($"{nums2[i],4}");
//}
//===============Two Dimensional Array======================

// int[,] matrix; //Declaration
// matrix = new int[3, 4]; //Allocation
// matrix[0, 0] = 3;
// matrix[0, 1] = 7;
// matrix[0, 2] = 6;
// matrix[0, 3] = -7;
// // matrix[0, 4] = 9; //Error
// Console.WriteLine(matrix[0, 3]);
//
// int[,] matrix2 = new int[3, 3] {//Combining Declaration, Allocation, and init, in one statement
//     { 6, 3, 1 },
//     { 3, 1, -1 },
//     { 8, 2, 1, }
// };
// Console.WriteLine(matrix2[1, 2]);
// Console.WriteLine("\n=========================\n");
// for (int i = 0; i < matrix2.GetLength(0); i++)//Outer Loop
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)//Inner Loop
//     {
//         Console.WriteLine($"{matrix2[i, j],5}");
//     }
//     Console.WriteLine();
// }
//=====================Jagged Array========================

// int[][] jaggedArray; //Declaration
// //int rowNum = Convert.ToInt32(Console.ReadLine());
// jaggedArray = new int[4][]; //Memory Allocation
//
// jaggedArray[0] = new int[] { 5 };
// jaggedArray[1] = new int[] { 9, 4 };
// jaggedArray[2] = new int[] { 2, -1, 7 };
// jaggedArray[3] = new int[] { 6, 8, 9, 1 };
//
// Console.WriteLine(jaggedArray[2][1]);
//
// int[][] jaggedArray2 = /*new int[4][]*/
// {   new int[]{6},//Combining Declaration, Memory Allocation and element init. No need for new int[4][0]
//     new int[]{0,1},
//     new int[]{11,6,2},
//     new int[]{0,-7,9,12}
// };
// Console.WriteLine(jaggedArray2[3][1]);
//
// Console.WriteLine("\nItteration Through Jagged Array Elements");
// for (int i = 0; i < jaggedArray.Length; i++)
// {
//     for (int j = 0; j < jaggedArray2[i].Length; j++)
//     {
// //         Console.WriteLine($"{jaggedArray2[i][j],5}");
//     }
//     Console.WriteLine();
//     Console.ReadKey();
//
// }
//
// int n;
// do
// {
//     Console.Write("Enter the value of n: ");
//     n = Convert.ToInt32(Console.ReadLine());
//
//     if (n < 1 || n > 100)//input validation
//         Console.WriteLine("Wrong input try again.");
//
// } while (n < 1 || n > 100);
//
// int[] nums = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine($"Enter the value for element number {i + 1}");
//     nums[i] = Convert.ToInt32(Console.ReadLine());
//
//     if (nums[i] >= 1 && nums[i] <= 200000) // Input validation
//         i++;
//     else
//         Console.WriteLine("Wrong input, try again.");
// }
// //Counting Pattern
// int evenCnt = 0;
//
// for (int i = 0; i < n; i++)
//     if (nums[i] % 2 == 0)
//         evenCnt++;
//
//
// Console.WriteLine($"The count of even number is {evenCnt}");
//
//
//
//
//

