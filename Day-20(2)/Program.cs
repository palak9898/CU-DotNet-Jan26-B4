// generic class

class MyArray<T>
{
    public T[] arr = new T[5];
    public T this[int index]
    {
        get { return (T)arr[index]; }
        set { arr[index] = (T)value; }
    }
    
}
// class MyStringArray<T>
// {
//     string[] arr = new string[5];
// }
class DemoGenericClass
{
    static void Main(string[] args)
    {
        MyArray<int> iarr = new MyArray<int>();
        iarr.arr[0] = 22;
        iarr[1]=33;    // work with indexers
        Console.WriteLine(iarr[1]);
        Console.WriteLine(string.Join(",", iarr.arr));

        string s = "abcd";
     //   s[0] = "x";  // not work read only

        MyArray<string> myArray = new MyArray<string>();
        myArray.arr[0] ="abcd";
    }
}
