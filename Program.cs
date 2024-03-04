using Trees;

var array = new int[] { 32, 41, 51, 64, 69, 76, 93, 141, 153, 153, 161, 192, 245, 282, 309, 330, 343, 355, 360, 417, 441, 446, 454, 456, 466, 482, 493, 497, 556, 620, 624, 649, 662, 668, 729, 800, 806, 813, 821, 843, 861, 868, 882, 901, 903, 943, 948, 956, 960, 983 };
var result = RecursiveBinarySearch.Search(array, 75);

if (result is not null)
{
    Console.WriteLine("found!");
}
else
{
    Console.WriteLine("not found :C");
}