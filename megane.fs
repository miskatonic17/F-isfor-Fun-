open System

let ArrayMatch (x:int [,]) (y:int [,]) m n =
     [|for i = 0 to (m - n) do
        for j = 0 to (m - n) do
            if x.[i..i+n-1,j..j+n-1] = y then
                 yield i;yield j|]

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

printfn "%d %d" ans.[0] ans.[1]
