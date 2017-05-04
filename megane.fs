// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。
open System
let ArrayMatch (x:int [,]) (y:int [,]) m n =
     [|for i = 0 to (m - n) do
        for j = 0 to (m - n) do
            if x.[i..i+n-1,j..j+n-1] = y then
                 yield i;yield j|]
                //printfn "%d %d" i j

let m = Console.ReadLine() |> System.Int32.Parse
let x = Array2D.zeroCreate<int> m m
for i = 0 to (m-1) do
    let s : String = Console.ReadLine()
 
    for j = 0 to (m-1) do
        Array2D.set x i j (int s.[j*2] - int '0')

let n = Console.ReadLine() |> System.Int32.Parse
let y = Array2D.zeroCreate<int> n n
for i = 0 to (n-1) do
    let s : String = Console.ReadLine()
 
    for j = 0 to (n-1) do
        Array2D.set y i j (int s.[j*2] - int '0')

let ans:int array = ArrayMatch x y m n
//ArrayMatch x y m n
printfn "%d %d" ans.[0] ans.[1]

(*
open System
let m = Console.ReadLine() |> System.Int32.Parse

let s : String array = Array.create (m + 1) ""

for i = 1 to m do
    Array.set s i (Console.ReadLine())

for i = 1 to m do
    printf "%s" (Array.get s i)
    if i <> m then
        printf("_")
*)
(*
open System
let m = Console.ReadLine() |> System.Int32.Parse
let n = Console.ReadLine() |> System.Int32.Parse

let add m n = 
    m + n

printfn "%d" (add m n)
*)
(*
open System
let n = Console.ReadLine() |> System.Int32.Parse
let s = "Ann"
for i = 1 to n do
printf "%s" s
*)
(*
//PAIZAの入力のサンプル
open System

while true do
 let s = Console.ReadLine() in
  if s<>null then
   Console.WriteLine(s.ToUpper())
  else
   exit(0)
done
*)
(*
[<EntryPoint>]
let main argv = 
    let anInt = 5
    let aString = "Hello" 
    // Perform a simple calculation and bind anIntSquared to the result. 
    let anIntSquared = anInt * anInt
 
    System.Console.WriteLine(anInt)
    System.Console.WriteLine(aString)
    System.Console.WriteLine(anIntSquared)

    let square n = n * n
    // Call the function to calculate the square of anInt, which has the value 5. 
    let result = square anInt
    // Display the result.
    System.Console.WriteLine(result)

    let rec factorial n =
        if n = 0
        then 1
        else n * factorial (n - 1)
    System.Console.WriteLine(factorial 500)


    System.Console.ReadKey
    0 // 整数の終了コードを返します
*)